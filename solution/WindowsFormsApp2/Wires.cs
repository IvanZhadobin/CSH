using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class _Cable
    {
        string type;
        int cable;
        double diameter;

        public _Cable()
        {
            cable = 0;
            diameter = 0;
            type = "";
        }
        public virtual void read(string type, int cable, double diameter)
        {
            this.type = type;
            this.cable = cable;
            this.diameter = diameter;
        }
        public virtual double quality_q()
        {
            return diameter / cable;
        }
        public override string ToString()
        {
            return "Тип: " + type + "Кол-во жил: " + cable + "Диаметр: " + diameter;
        }

    }
    class _Cable_q : _Cable
    {
        string braid;
        public _Cable_q()
        {
            braid = "";
        }
        public void read(string type, int cable, double diameter, string braid)
        {
            base.read(type, cable, diameter);
            this.braid = braid;
        }

        public override double quality_q()
        {
            switch (braid)
            {
                case "есть":
                    return base.quality_q() * 2;
                case "нет":
                    return base.quality_q() * 0.7;
                default:
                    return base.quality_q();
            }
        }
        public override string ToString()
        {
            return base.ToString() + "Наличие оплетки: " + braid;
        }
    }
}
