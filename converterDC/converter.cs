using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace converterDC
{

    class converter
    {
        int frequency;
        double maxInputVoltage, minInputVoltage, inputVoltage;
        double maxOutputVoltage, minOutputVoltage, outputVoltage;
        double maxOutputCurrent, outputCurrent;
        double L1, R1, R2, C1, C2;
        Eseries Eseries;
        private RDivider RDivider = new RDivider(0.81, 15, Eseries.e12);
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

     

        public void calc(double outputCurrent, double outputVoltage, double inputVoltage, Eseries ESeries)
        {
            this.outputCurrent = outputCurrent;
            this.outputVoltage = outputVoltage;
            this.inputVoltage = inputVoltage;
            this.Eseries = ESeries;
            RDivider.count(0.81, this.outputVoltage, this.Eseries);
            //dbOfEpsilons = rDivider(0.81, outputVoltage, this.ESeries);// do naprawy
        }
    }
}
