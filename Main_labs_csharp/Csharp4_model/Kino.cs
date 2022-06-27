using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp4_model
{
    class Kino : Public_build
    {
        public int CountFilms { get; set; } // Количсетво фильмов
        public int CountFilmsOfDay { get; set; }

        public Kino(int FilmsOfDay)
        {
            this.CountFilmsOfDay = FilmsOfDay;
            CountFilms = 0;
        }
        public Kino()
        {
            this.CountFilmsOfDay = 65;
            CountFilms = 0;
        }
        public void Films_count()
        {
            CountFilms++;
        }
        public void Nuber_of_session(int FilmsOfDay)
        {
            if (FilmsOfDay > 0)
                this.CountFilmsOfDay = FilmsOfDay;
            else
                MessageBox.Show("Номер сеанса должен быть положителен");
        }
    }
}
