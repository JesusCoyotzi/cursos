﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana
{
    public partial class Form1 : Form
    {
        static string msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg = textBox1.Text;
            label1.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
