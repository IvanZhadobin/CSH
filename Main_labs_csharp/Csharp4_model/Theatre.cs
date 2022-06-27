using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp4_model
{
    public class Theatre : Public_build
    {

        public int load { get; set; }
        public int count_ { get; set; }
        public int weight { get; set; }
        public int empty_ { get; set; }
        public Theatre()
        {
            load = 0;
            count_ = 4;
            weight = 2000;
            empty_ = 2000;
        }
        public void Place(int place)
        {

            if (place < weight)
                MessageBox.Show("Ошибка ввода.");
            free = room - place;

        }
        public void Free_place(int place)
        {
            if (place < 0)
                MessageBox.Show("Ошибка ввода.");
            room += place;
        }
    }
}



