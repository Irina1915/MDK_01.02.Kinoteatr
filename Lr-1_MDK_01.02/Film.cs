using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_1_MDK_01._02
{
    class Film
    {
        private string name_;
        private string genre_;
        private double prise_;
        private DateTime datefilm_;


        public string Name
        {
            get { return name_; }
        }

        public string Genre
        {
            get { return genre_; }
        }

        public string Prise
        {
            get { return Convert.ToString(prise_); }
        }

        public string DateFilm
        {
            get { return Convert.ToString(datefilm_); }
        }

        public Film(string name, string genre, double prise, DateTime datefilm)
        {
            name_ = name;
            genre_ = genre;
            prise_ = prise;
            datefilm_ = datefilm;
        }

    }
}
