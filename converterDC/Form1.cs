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
        AP3211 AP3211;
        public Form1()
        {
            InitializeComponent();
        }

        private void changeValues(int chose)
        {
            switch(chose)
            {
                case 0:
                    labelR1.Text = Convert.ToString(AP3211.RDivider.getOpt1.r1);
                    labelR2.Text = Convert.ToString(AP3211.RDivider.getOpt1.r2);
                    labelUout.Text = Convert.ToString(AP3211.RDivider.getOpt1.realUout);
                break;
                case 1:
                    labelR1.Text = Convert.ToString(AP3211.RDivider.getOpt2.r1);
                    labelR2.Text = Convert.ToString(AP3211.RDivider.getOpt2.r2);
                    labelUout.Text = Convert.ToString(AP3211.RDivider.getOpt2.realUout);
                break;
                case 2:
                    labelR1.Text = Convert.ToString(AP3211.RDivider.getOpt3.r1);
                    labelR2.Text = Convert.ToString(AP3211.RDivider.getOpt3.r2);
                    labelUout.Text = Convert.ToString(AP3211.RDivider.getOpt3.realUout);
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboESeries.SelectedIndex = 1; //wartości domyślne tablicy szeregu
            AP3211 = new AP3211();
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
            AP3211.outputVoltage = Convert.ToDouble(textUout.Text);
            AP3211.inputVoltage = Convert.ToDouble(textUin.Text);
            AP3211.outputCurrent = Convert.ToDouble(textIout.Text);
            AP3211.Eseries = (Eseries)comboESeries.SelectedIndex;
            AP3211.calc();
            labelUin.Text = textUout.Text;
            labelR1.Text = Convert.ToString(AP3211.R1);
            labelR2.Text = Convert.ToString(AP3211.R2);
            labelUout.Text = Convert.ToString(AP3211.realOutputVoltage);
            radioFirstOption.Text = "Uout = " + Convert.ToString(AP3211.RDivider.getOpt1.realUout) + " V";
            radioSecondOption.Text = "Uout = " + Convert.ToString(AP3211.RDivider.getOpt2.realUout) + " V";
            radioThirdOption.Text = "Uout = " + Convert.ToString(AP3211.RDivider.getOpt3.realUout) + " V";
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
