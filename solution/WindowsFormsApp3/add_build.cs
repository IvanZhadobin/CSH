using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp3
{
    public partial class add_build : Form
    {
        public building building;
        public add_build()
        {
            InitializeComponent();
            building = new building();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wt = Convert.ToInt32(textBox2.Text);
            int max_wt = Convert.ToInt32(textBox1.Text);
            if (wt < 0 || max_wt < 0)
            {
                MessageBox.Show("Ошибка ввода");
            }
            else
            {
                building.load = max_wt;
                building.weight = wt;
                building.empty_ = wt;
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
