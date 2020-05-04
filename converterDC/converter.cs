using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterDC
{

    class converter
    {
        int frequency;
        double maxInputVoltage, minInputVoltage, inputVoltage;
        double maxOutputVoltage, minOutputVoltage, outputVoltage;
        double maxOutputCurrent, outputCurrent;
        double L1, R1, R2, C1, C2;
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

        public void enterValues(double outputCurrent, double outputVoltage, double inputVoltage)
        {
            this.outputCurrent = outputCurrent;
            this.outputVoltage = outputVoltage;
            this.inputVoltage = inputVoltage;
        }
    }
}
