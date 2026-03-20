using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_3
{
    internal class Product
    {
        private string name_;
        private double price_;
        private int expiryDate_;
        private string foto_;
        private int kol_vo_;

        public Product(string name, double price, int kol_vo,int date, string foto) 
        {
            name_ = name;
            price_ = price;
            expiryDate_ = date;
            foto_ = foto;
            kol_vo_ = kol_vo;
        }

        public string Name
        {
            get { return name_; }
        }

        public string Price
        {
            get { return price_.ToString(); }
        }

        public string Kol_vo
        {
            get { return kol_vo_.ToString(); }
        }


        public string Data
        {
            get { return expiryDate_.ToString(); }
        }

        public string Foto
        {
            get { return foto_.ToString(); }
        }
    }
}
