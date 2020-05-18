using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace converterDC
{

    enum series
    {
        E12 = 0,
        E24 = 1
    }

    class converter
    {
        int frequency;
        double maxInputVoltage, minInputVoltage, inputVoltage;
        double maxOutputVoltage, minOutputVoltage, outputVoltage;
        double maxOutputCurrent, outputCurrent;
        double L1, R1, R2, C1, C2;
        int ESeries;
        List<Tuple<double, double, double>> dbOfEpsilons = new List<Tuple<double, double, double>> { };
        public converter() //domyślnie ap3211
        {
            this.frequency = 1400000; //Hz
            this.maxInputVoltage = 18; //V
            this.minInputVoltage = 4.5; //V
            this.maxOutputVoltage = 15; //V
            this.minOutputVoltage = 0.81; //V
            this.maxOutputCurrent = 1.5; //A
        }
        public converter(int frequency, double maxInputVoltage, double minInputVoltage, double maxOutputVoltage, double minOutputVoltage, double maxOutputCurrent)
        {
            this.frequency = frequency; //Hz
            this.maxInputVoltage = maxInputVoltage; //V
            this.minInputVoltage = minInputVoltage; //V
            this.maxOutputVoltage = maxOutputVoltage; //V
            this.minOutputVoltage = minOutputVoltage; //V
            this.maxOutputCurrent = maxOutputCurrent; //A
        }

        ~converter()
        {
            MessageBox.Show("Destruktor");
        }

        public void calc(double outputCurrent, double outputVoltage, double inputVoltage, int ESeries)
        {
            this.outputCurrent = outputCurrent;
            this.outputVoltage = outputVoltage;
            this.inputVoltage = inputVoltage;
            this.ESeries = ESeries;
            dbOfEpsilons = rDivider(0.81, outputVoltage, this.ESeries);
        }
        
        private List<Tuple<double, double, double>> rDivider(double Uref, double Vout, int ESeries)
        {
            List<double> E12 = new List<double> { 10, 12, 15, 18, 22, 27, 33, 39, 47, 56, 68, 82 };
            List<double> E24 = new List<double> { 10, 11, 12, 13, 15, 16, 18, 20, 22, 24, 27, 30, 33, 36, 39, 43, 47, 51, 56, 62, 68, 75, 82, 91 };
            List<double> ser = new List<double> { };

            var dbOfEpsilons = new List<Tuple<double, double, double>> { };
            double factor;


            if (ESeries == 0) ser = E12; else ser = E24;

            factor = Vout / Uref;
            for (int i = 0; i < 3; i++)
            {
                foreach (double valR1 in ser) //R1 //todo: dodać zamianię szeregów wartości
                {
                    double tempR1;
                    tempR1 = valR1;
                    if (i == 0) tempR1 /= 10;
                    if (i == 2) tempR1 *= 10;
                    for (int j = 0; j < 3; j++)
                    {
                        foreach (double valR2 in ser)
                        {
                            double tempR2;
                            double epsilon;
                            tempR2 = valR2;
                            if (j == 0) tempR2 /= 10;
                            if (j == 2) tempR2 *= 10;
                            epsilon = factor - (tempR1 + tempR2)/tempR2;
                            dbOfEpsilons.Add(new Tuple<double, double, double> (Math.Abs(epsilon), tempR1, tempR2));
                        }
                    }
                }
            }
            dbOfEpsilons.Sort();
            // minIndexFromEpsilonList = epsilonList.IndexOf(epsilonList.Min());
            // MessageBox.Show(Convert.ToString(epsilonList[minIndexFromEpsilonList]));
            //  MessageBox.Show(Convert.ToString(minIndexFromEpsilonList));

            var firstOption = new Tuple<double, double, double>(0, 0, 0);
            var secondOption = new Tuple<double, double, double>(0, 0, 0);
            var thirdOption = new Tuple<double, double, double>(0, 0, 0);
            var previous = new Tuple<double, double, double>(0, 0, 0);
            int counter = 0;
            firstOption = dbOfEpsilons[0];
            foreach (Tuple <double, double, double> index in dbOfEpsilons)
            {
                if (previous.Item1 != index.Item1)
                {
                    counter++; //todo naprawićto ścierwo essa
                    switch (counter)
                    {
                        case 1:
                            firstOption = index;
                        break;
                        case 2:
                            secondOption = index;
                        break;
                        case 3:
                            thirdOption = index;
                        break;
                    }
                }
                
                if (counter >= 3) break;
                previous = index;
            }

            return new List<Tuple<double, double, double>> { firstOption, secondOption, thirdOption }; ///dokonczyćreturna
        }

    }
}
