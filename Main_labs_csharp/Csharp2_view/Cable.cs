﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp2_view
{
    public partial class Cable : Form
    {
        public string type;
        public int cable;
        public double diameter;
        public Cable()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            type = textBox1.Text;
            cable = Convert.ToInt32(textBox2.Text);
            diameter = Convert.ToDouble(textBox3.Text);
            if (cable < 0  || diameter < 0 )
                MessageBox.Show("Ошибка ввода!");
            else
                this.Close();
        }
    }
}
