using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp1
{
    class City
    {
        private string name;
        public City(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}