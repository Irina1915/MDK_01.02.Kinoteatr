using ClassLr_3.Views;
using lr_3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLr_3
{
    public class ProductModul : Dobavlenie
    {
        List<Product> Dobavlenie.LoadDataFromCsv()
        {
            List<Product> allTovar = new List<Product>();
            string path = "data3.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split(';');
                allTovar.Add(new Product(lines[1], Convert.ToInt32(lines[2]), Convert.ToInt32(lines[3]), Convert.ToInt32(lines[4]), lines[5]));
            }
            info.Close();
            return allTovar;
        }

    }
}
