using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace converterDC
{
    public partial class Form1 : Form
    {
        AP3211 AP3211_1, AP3211_2, AP3211_3;
        RDivider Rdivider;
        public Form1()
        {
            InitializeComponent();
        }

        private void changeValues(int chose)
        {
            switch(chose)
            {
                case 0:
                    labelR1.Text = Convert.ToString(AP3211_1.R1) + " kΩ";
                    labelR2.Text = Convert.ToString(AP3211_1.R2) + " kΩ";
                    labelUout.Text = Convert.ToString(AP3211_1.getRealOutputVoltage) + " V";
                    labelL1.Text = AP3211_1.getL1_str + "H";
                    break;
                case 1:
                    labelR1.Text = Convert.ToString(AP3211_2.R1) + " kΩ";
                    labelR2.Text = Convert.ToString(AP3211_2.R2) + " kΩ";
                    labelUout.Text = Convert.ToString(AP3211_2.getRealOutputVoltage) + " V";
                    labelL1.Text = AP3211_2.getL1_str + "H";
                    break;
                case 2:
                    labelR1.Text = Convert.ToString(AP3211_3.R1) + " kΩ";
                    labelR2.Text = Convert.ToString(AP3211_3.R2) + " kΩ";
                    labelUout.Text = Convert.ToString(AP3211_3.getRealOutputVoltage) + " V";
                    labelL1.Text = AP3211_3.getL1_str + "H";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboESeries.SelectedIndex = 1; //wartości domyślne tablicy szeregu
            AP3211_1 = new AP3211();
            AP3211_2 = new AP3211();
            AP3211_3 = new AP3211();
            Rdivider = new RDivider();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double outputVoltage = Convert.ToDouble(textUout.Text);
            double inputVoltage = Convert.ToDouble(textUin.Text);
            double outputCurrent = Convert.ToDouble(textIout.Text);
            Eseries Eseries = (Eseries)comboESeries.SelectedIndex;

            AP3211_1.setOutputVoltage = outputVoltage;
            AP3211_2.setOutputVoltage = outputVoltage;
            AP3211_3.setOutputVoltage = outputVoltage;

            AP3211_1.setInputVoltage = inputVoltage;
            AP3211_2.setInputVoltage = inputVoltage;
            AP3211_3.setInputVoltage = inputVoltage;

            AP3211_1.setOutputCurrent = outputCurrent;
            AP3211_2.setOutputCurrent = outputCurrent;
            AP3211_3.setOutputCurrent = outputCurrent;

            AP3211_1.Eseries = Eseries;
            AP3211_2.Eseries = Eseries;
            AP3211_3.Eseries = Eseries;

            Rdivider.count(0.81, outputVoltage, Eseries);
            AP3211_1.rdividerInput(Rdivider.getOpt1);
            AP3211_2.rdividerInput(Rdivider.getOpt2);
            AP3211_3.rdividerInput(Rdivider.getOpt3);

            AP3211_1.calc();
            AP3211_2.calc();
            AP3211_3.calc();

            labelUin.Text = textUin.Text + " V";

            changeValues(0);

            radioFirstOption.Text = "Uout = " + Convert.ToString(AP3211_1.getRealOutputVoltage) + " V";
            radioSecondOption.Text = "Uout = " + Convert.ToString(AP3211_2.getRealOutputVoltage) + " V";
            radioThirdOption.Text = "Uout = " + Convert.ToString(AP3211_3.getRealOutputVoltage) + " V";
            radioFirstOption.Visible = true;
            radioSecondOption.Visible = true;
            radioThirdOption.Visible = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioFirstOption_CheckedChanged(object sender, EventArgs e)
        {
            changeValues(0);
        }

        private void radioSecondOption_CheckedChanged(object sender, EventArgs e)
        {
            changeValues(1);
        }

        private void radioThirdOption_CheckedChanged(object sender, EventArgs e)
        {
            changeValues(2);
        }
    }
}
