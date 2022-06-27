using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp3_model
{
    interface build
    {
        int room { get; set; }
        int place { get; set; }
        int free_place { get; }
        void move(int place);
        void load_audience(int audience);

    }
    public abstract class public_build : build
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
    public class building : public_build
    {
        public int load { get; set; }
        public int count_ { get; set; }
        public int weight { get; set; }
        public int empty_ { get; set; }
        public building()
        {
            load = 0;
            count_ = 4;
            weight = 2000;
            empty_ = 2000;
        }
        public void Load(int place)
        {

            if (place < weight)
                MessageBox.Show("Ошибка ввода.");
            free = room - place;

        }
        public void unload(int place)
        {
            if (place < 0)
                MessageBox.Show("Ошибка ввода.");
            room += place;
        }
    }
}