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
        protected int frequency;
        protected double inputVoltage;
        protected double outputVoltage;
        protected double realOutputVoltage;
        protected double outputCurrent;
        public double L1, R1, R2;
        public Eseries Eseries;
        protected string L1_str;
        public converter()
        {
        }

        public converter(double inputVoltage, double outputVoltage, double outputCurrent)
        {
            this.inputVoltage = inputVoltage;
            this.outputVoltage = outputVoltage;
            this.outputCurrent = outputCurrent;
        }

        public double setInputVoltage
        {
            set => inputVoltage = value;
        }

        public double setOutputVoltage
        {
            set => outputVoltage = value;
        }

        public double getRealOutputVoltage
        {
            get => realOutputVoltage;
        }

        public double setOutputCurrent
        {
            set => outputCurrent = value;
        }

        public string getL1_str
        {
            get => L1_str;
        }
        public void rdividerInput((double epsilon, double r1, double r2, double realUout) data)
        {
            this.R1 = data.r1;
            this.R2 = data.r2;
            this.realOutputVoltage = data.realUout;
        }
    }
}
