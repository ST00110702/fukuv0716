﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0716
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + textBox2.Text;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
