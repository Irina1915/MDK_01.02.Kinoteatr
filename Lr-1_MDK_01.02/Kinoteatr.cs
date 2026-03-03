using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_1_MDK_01._02
{
    class Kinoteatr
    {
        private List<Film> films = new List<Film>();
        public void FilmUser(string Genre, DateTime DataFilm)
        {
            List<Film> findFilms = new List<Film>();
            foreach(Film film in films)
            {
            }
        }

        public bool Kino (string g1, string g2)
        {
            return g1.ToLower() == g2.ToLower();
        }
    }
}
