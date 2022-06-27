using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_model
{
    class Cafe :Public_build
    {
        public int Count_food { get; set; }
        public int Count_place { get; set; }

        public Cafe(int count_place)
        {
            this.Count_place = count_place;
            Count_food = 0;
        }
        public Cafe()
        {
            this.Count_place = 2;
            Count_food = 0;
        }
        public void Count_of_food(int food)
        {
            Count_food += food;
        }
        public void Leftover_food()
        {
            while (Count_food > 0)
                Count_food -= Count_place;
            Count_food = 0;
        }
    }
}