using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace converterDC
{

    class converter //TODO: pohermetyzować śmieci
    {
        protected int frequency;
        public double inputVoltage;
        public double outputVoltage, realOutputVoltage;
        public double outputCurrent;
        public double L1, R1, R2;
        public Eseries Eseries;
        public string L1_str;
        List<Tuple<double, double, double>> dbOfEpsilons = new List<Tuple<double, double, double>> { };
        public converter() 
        {
        }

        public void rdividerInput((double epsilon, double r1, double r2, double realUout) data)
        {
            this.R1 = data.r1;
            this.R2 = data.r2;
            this.realOutputVoltage = data.realUout;
        }
    }
}
