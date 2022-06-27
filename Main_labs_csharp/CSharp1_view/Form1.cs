using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СSharp1_model;
using Region = СSharp1_model.Region;
//Жадобин Иван 9 группа

// 4 задача Создать объект класса Государство, используя классы Область, Район, Город. 
// Методы: вывести столицу, количество областей, площадь, областные центры.

namespace CSharp1_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        State state = null;
        private void button1_Click(object sender, EventArgs e)
        {
            state = new State(textBox1.Text);
            MessageBox.Show($"Столица {textBox1.Text} создана!");
            textBox1.Enabled = false;
            textBox6.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button6.Enabled = true;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Region region = new Region(textBox6.Text);
            state.add_region(region);
            MessageBox.Show($"Регион {textBox6.Text} добавлен!");
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            District district = new District(textBox2.Text);
            state.add_district(district);
            MessageBox.Show($"Площадь {textBox2.Text} добавлена!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            City city = new City(textBox3.Text);
            state.add_city(city);
            MessageBox.Show($"областной центр {textBox3.Text} добавлен!");
        }
   
        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Название столицы: {state.get_Name()}\n" +
               $"Количество областей: {state.count_region()}\n" +
             $"Количество площадей {state.count_district()}\n" +
             $"Количество областных центров: {state.count_city()}");
        }
    }
}
