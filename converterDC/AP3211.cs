using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converterDC
{
    class AP3211:converter //TODO: powrzucać stałe jak max voltage itp do filtrowania danych
    {

        public AP3211()
        {
            base.frequency = 1400000;
        }

        public void calc()
        {
            double tempNumerator, tempDenominator;
            tempNumerator = base.inputVoltage - base.realOutputVoltage;
            tempDenominator = base.frequency * base.inputVoltage * outputCurrent * 0.26;
            base.L1 = base.realOutputVoltage * (tempNumerator / tempDenominator);
            base.L1_str = siChanger(base.L1);
        }

        private string siChanger(double value)
        {
            List<string> si = new List<string> {"", "m", "µ", "n", "p"};
            int i = 0;
            while(value < 1)
            {
                value *= 1000;
                i++;
            }   
            string output = Convert.ToString(Math.Round(value, 2)) + " " + si[i];
            return output;
        }

    }
}
