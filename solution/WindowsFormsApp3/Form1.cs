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
    public partial class Form1 : Form
    {
        List<building> wt;
        private void print_build(DataGridView dv)
        {
            dv.RowCount = 1;
            int i = 0;
            foreach (building build in wt)
            {
                dv.RowCount++;
                dv.Rows[i].HeaderCell.Value = i;
                dv.Rows[i].Cells[0].Value = build.load;
                dv.Rows[i].Cells[1].Value = build.weight;
                dv.Rows[i].Cells[2].Value = build.seance;
                dv.Rows[i].Cells[3].Value = build.room;
                dv.Rows[i].Cells[4].Value = build.free;
                i++;
            }
        }
        public Form1()
        {
            InitializeComponent();
            wt = new List<building>();
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "Кoл-во этажей";
            dataGridView1.Columns[0].Width = 105;
            dataGridView1.Columns[1].HeaderCell.Value = "Кoл-во залов";
            dataGridView1.Columns[1].Width = 105;
            dataGridView1.Columns[2].HeaderCell.Value = "Сеансы";
            dataGridView1.Columns[2].Width = 105;
            dataGridView1.Columns[3].HeaderCell.Value = "Места";
            dataGridView1.Columns[3].Width = 105;
            dataGridView1.Columns[4].HeaderCell.Value = "Свободные местa";
            dataGridView1.Columns[4].Width = 105;
        }
               
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int seance = Convert.ToInt32(textBox1.Text);
            if (seance < 0 || wt.Count == 0)
                MessageBox.Show("Ошибка ввода.");
            else
                foreach (building construction in wt)
                {
                    construction.seance += seance;
                }
            print_build(dataGridView1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int place = Convert.ToInt32(textBox3.Text);

            foreach (building construction in wt)
            {
                construction.unload(place);
            }
            print_build(dataGridView1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int free_place = Convert.ToInt32(textBox2.Text);
                foreach (building construction in wt)
                {
                    construction.Load(free_place);
                }
            print_build(dataGridView1);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            this.Enabled = false;
            add_build nf = new add_build();
            nf.ShowDialog();
            wt.Add(nf.building);
            this.Enabled = true;
            print_build(dataGridView1);
        }
    }
}
