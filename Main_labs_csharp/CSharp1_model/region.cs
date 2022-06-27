using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSharp1_model
{
    public class Region
    {
       private string name;

        public Region(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
