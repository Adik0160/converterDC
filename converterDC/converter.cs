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
        public double maxInputVoltage, minInputVoltage, inputVoltage;
        public double maxOutputVoltage, minOutputVoltage, outputVoltage, realOutputVoltage;
        public double maxOutputCurrent, outputCurrent;
        public double L1, R1, R2, C1, C2;
        public Eseries Eseries;
        public RDivider RDivider;
        List<Tuple<double, double, double>> dbOfEpsilons = new List<Tuple<double, double, double>> { };
        public converter() 
        {
            RDivider = new RDivider(0.81, 5, Eseries.e12);
        }

        public void calc()
        {
            RDivider.count(0.81, this.outputVoltage, this.Eseries);
            R1 = RDivider.getOpt1.r1;
            R2 = RDivider.getOpt1.r2;
            realOutputVoltage = RDivider.getOpt1.realUout;
        }

    }
}
