using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4_model
{
    interface Build
    {
        int free { get; set; }
        int room { get; set; }
        int place { get; set; }
        int free_place { get; set; }
        int seance { get; set; }
        void move(int place);
        void load_audience(int audience);
    }
}
