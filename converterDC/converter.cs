using System;
using System.Collections.Generic;
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
            rDivider(0.81, 5, this.ESeries);
        }
        
        private (double, double, double) rDivider(double Uref, double Vout, int ESeries)
        {
            List<double> E12 = new List<double> { 10, 12, 15, 18, 22, 27, 33, 39, 47, 56, 68, 82 };
            List<double> E24 = new List<double> { 10, 11, 12, 13, 15, 16, 18, 20, 22, 24, 27, 30, 33, 36, 39, 43, 47, 51, 56, 62, 68, 75, 82, 91 };
            double factor;
            factor = Vout / Uref;
            for (int i = 0; i < 3; i++)
            {
                foreach (double valR1 in E12) //R1 //todo: dodać zamianię szeregów wartości
                {
                    double tempR1 = valR1;
                    if (i == 0) tempR1 /= 10;
                    if (i == 2) tempR1 *= 10;
                    for (int j = 0; j < 3; j++)
                    {
                        foreach (double valR2 in E12)
                    }
                }
            }

            return (0, 0, 0);
        }

    }
}
