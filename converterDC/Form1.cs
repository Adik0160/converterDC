﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboESeries.SelectedIndex = 1; //wartości domyślne tablicy szeregu
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
            int i;
            i = comboESeries.SelectedIndex;
            converter AP3211 = new converter();
            AP3211.calc(Convert.ToDouble(textIout.Text), Convert.ToDouble(textUout.Text), Convert.ToDouble(textUin.Text), comboESeries.SelectedIndex);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
