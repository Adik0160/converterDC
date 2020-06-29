using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converterDC
{

    class RDivider
    {
        private Eseries Eseries;
        private List<double> e6 = new List<double> { 10, 15, 22, 33, 47, 68 };
        private List<double> e12 = new List<double> { 10, 12, 15, 18, 22, 27, 33, 39, 47, 56, 68, 82 };
        private List<double> e24 = new List<double> { 10, 11, 12, 13, 15, 16, 18, 20, 22, 24, 27, 30, 33, 36, 39, 43, 47, 51, 56, 62, 68, 75, 82, 91 };
        double uRef;
        double uOut;
        private (double epsilon, double r1, double r2, double realUout) opt1 = (-1, -1, -1, -1); // to też może naprawić
        private (double epsilon, double r1, double r2, double realUout) opt2 = (-1, -1, -1, -1);
        private (double epsilon, double r1, double r2, double realUout) opt3 = (-1, -1, -1, -1);

        public RDivider()
        {
            this.uRef = 0.81;
            this.uOut = 5;
            this.Eseries = Eseries.e12;
        }
        public RDivider(double uRef, double uOut, Eseries Eseries)
        {
            this.uRef = uRef;
            this.uOut = uOut;
            this.Eseries = Eseries;
        }

        public void count(double uRef, double uOut, Eseries Eseries) // TODO: pomyśleć nad wykorzystaniem zmiennych w tej klasie (czy są wgl potrzebne)
        {
            this.uRef = uRef;
            this.uOut = uOut;
            this.Eseries = Eseries;
            (double epsilon, double r1, double r2) tempOpt1 = (-1, -1, -1);
            (double epsilon, double r1, double r2) tempOpt2 = (-1, -1, -1);
            (double epsilon, double r1, double r2) tempOpt3 = (-1, -1, -1);
            var dbOfEpsilons = new List<(double epsilon, double r1, double r2)> { };
            List<double> chosenSeries = new List<double> { };
            double factor;

            switch (Eseries)
            {
                case Eseries.e6:
                    chosenSeries = e6;
                break;
                case Eseries.e12:
                    chosenSeries = e12;
                break;
                case Eseries.e24:
                    chosenSeries = e24;
                break;
            }

            factor = uOut / uRef;
            for (int i = 0; i < 3; i++)
            {
                foreach (double valR1 in chosenSeries) //R1 //todo: dodać zamianie szeregów wartości
                {
                    double tempR1;
                    tempR1 = valR1;
                    if (i == 0) tempR1 /= 10;
                    if (i == 2) tempR1 *= 10;
                    for (int j = 0; j < 3; j++)
                    {
                        foreach (double valR2 in chosenSeries)
                        {
                            double tempR2;
                            double epsilon;
                            tempR2 = valR2;
                            if (j == 0) tempR2 /= 10;
                            if (j == 2) tempR2 *= 10;
                            epsilon = factor - (tempR1 + tempR2) / tempR2;
                            //Math.Abs(epsilon), tempR1, tempR2
                            dbOfEpsilons.Add((Math.Abs(epsilon), tempR1, tempR2));
                        }
                    }
                }
            }
            dbOfEpsilons.Sort(); //sprawdzićczy sie nie psuje porównywarka (jajk sortować po elemencie - na przykład środkowym)
            // minIndexFromEpsilonList = epsilonList.IndexOf(epsilonList.Min());
            // MessageBox.Show(Convert.ToString(epsilonList[minIndexFromEpsilonList]));
            //  MessageBox.Show(Convert.ToString(minIndexFromEpsilonList));

            //var firstOption = new Tuple<double, double, double>(0, 0, 0);
            // var secondOption = new Tuple<double, double, double>(0, 0, 0);
            // var thirdOption = new Tuple<double, double, double>(0, 0, 0);
            (double r1, double r2, double epsilon) previousOpt = (0, 0, 0);
            int counter = 0;
            tempOpt1 = dbOfEpsilons[0];
            foreach ((double epsilon, double r1, double r2) index in dbOfEpsilons)
            {
                if (previousOpt.epsilon != index.epsilon) 
                {
                    counter++; //todo naprawićto ścierwo essa
                    switch (counter)
                    {
                        case 1:
                            tempOpt1 = index;
                            break;
                        case 2:
                            tempOpt2 = index;
                            break;
                        case 3:
                            tempOpt3 = index;
                            break;
                    }
                }

                if (counter >= 3) break;
                previousOpt = index;
            }
            opt1 = tupleConvertAndVoltage(tempOpt1);
            opt2 = tupleConvertAndVoltage(tempOpt2);
            opt3 = tupleConvertAndVoltage(tempOpt3);
        }

        private (double epsilon, double r1, double r2, double realUout) tupleConvertAndVoltage((double epsilon, double r1, double r2) input)
        {
            (double epsilon, double r1, double r2, double realUout) tempReturn;
            tempReturn.epsilon = input.epsilon;
            tempReturn.r1 = input.r1;
            tempReturn.r2 = input.r2;
            tempReturn.realUout = this.uRef * ((input.r1 + input.r2) / input.r2);
            return tempReturn;
        }

        public (double epsilon, double r1, double r2, double realUout) getOpt1
        {
            get { return opt1; }
        }

        public (double epsilon, double r1, double r2, double realUout) getOpt2
        {
            get { return opt2; }
        }

        public (double epsilon, double r1, double r2, double realUout) getOpt3
        {
            get { return opt3; }
        }
    }
}
