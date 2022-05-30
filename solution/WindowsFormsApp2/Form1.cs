using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        _Cable cable;
        _Cable_q cable_q;
        private void data_cabel(DataGridView go)
        {
            go.RowCount = 1;
            go.ColumnCount = 3;
            go.Columns[0].HeaderCell.Value = "Тип";
            go.Columns[0].Width =50;
            go.Columns[1].HeaderCell.Value = "Кол-во жил кабеля";
            go.Columns[1].Width = 100;
            go.Columns[2].HeaderCell.Value = "Диаметр";
            go.Columns[2].Width = 100;
        }
        public Form1()
        {
            InitializeComponent();
            cable = new _Cable();
            cable_q = new _Cable_q();
            data_cabel(dataGridView1);
            data_cabel(dataGridView2);
            dataGridView2.ColumnCount++;
            dataGridView2.Columns[3].HeaderCell.Value = "Наличие оплетки: ";
            dataGridView2.Columns[3].Width = 114;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cable nf = new Cable();
            nf.ShowDialog();
            cable.read(nf.type, nf.cable, nf.diameter);
            dataGridView1.Rows[0].Cells[0].Value = nf.type;
            dataGridView1.Rows[0].Cells[1].Value = nf.cable;
            dataGridView1.Rows[0].Cells[2].Value = nf.diameter;
            this.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Q = " + cable.quality_q());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Провод\n\r" + cable.ToString());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Enabled = false;
            Cable_q nf = new Cable_q();
            nf.ShowDialog();
            cable_q.read(nf.type, nf.cable, nf.diameter, nf.braid);
            dataGridView2.Rows[0].Cells[0].Value = nf.type;
            dataGridView2.Rows[0].Cells[1].Value = nf.cable;
            dataGridView2.Rows[0].Cells[2].Value = nf.diameter;
            dataGridView2.Rows[0].Cells[3].Value = nf.braid;
            this.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Q = " + cable_q.quality_q());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кабель\n\r" + cable_q.ToString());
        }
    }
}
