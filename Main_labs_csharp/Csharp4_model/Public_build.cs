using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp4_model
{
    public abstract class Public_build : Build
    {
        public int free { get; set; }
        public int room { get; set; }
        public int place { get; set; }
        public int free_place { get; set; }
        public int seance { get; set; }

        public void move(int place)
        {
            if (place > 0)
            {
                room += place;
                seance -= place;
            }
            else
                MessageBox.Show("Ошибка ввода.");
        }
        public void load_audience(int audience)
        {
            if (place + audience > free_place)
            {
                MessageBox.Show("Ошибка ввода.");
            }
            else
                place += audience;
        }
    }
}
