using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lr_3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Product>> products_ = new Dictionary<string, List<Product>>();
        private Dictionary<string, List<Product>> tovar_ = new Dictionary<string, List<Product>>();
        private Dictionary<string, int> orderItems_ = new Dictionary<string, int>();

        public MainForm()
        {
            InitializeComponent();
            FotoPictureBox.Size = new Size(190, 270);
            FotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            products_.Add("Фрукты",
                new List<Product>()
                {
                    new Product ("Мандарины", 13.0, 5, 15, "../../Рисунок/Мандарины.jpg"),
                    new Product ("Гранаты", 25.0, 7, 13, "../../Рисунок/Гранат.jpg")
                }
            );

            products_.Add("Овощи",
                new List<Product>()
                {
                    new Product ("Огурцы", 8.0, 6, 34, "../../Рисунок/Огурцы.jpg"),
                    new Product ("Помидоры", 3.0, 5, 12, "../../Рисунок/Помидоры.jpg")
                }
            );

            products_.Add("Мясо",
                new List<Product>()
                {
                    new Product ("Курица", 20.0, 10, 35, "../../Рисунок/Куриное филе.jpg"),
                    new Product ("Говядина", 13.0, 10, 10, "../../Рисунок/Филе говядины.jpg")
                }
            );


            List<string> allCategories = products_.Keys.ToList();
            ProductListBox.DataSource = allCategories;
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = ProductListBox.SelectedItem.ToString();
            List<Product> productSelectedCategory = products_[selectedCategory];

            ProductComboBox.DataSource= productSelectedCategory;
            ProductComboBox.DisplayMember = "Name";
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = ProductComboBox.SelectedItem as Product;
            PriceLabel.Text = selectedProduct.Price;
            DataLabel.Text = selectedProduct.Data;
            labelKol_vo.Text = selectedProduct.Kol_vo;

            if (selectedProduct.Foto != null)
            {
                FotoPictureBox.Image = Image.FromFile(selectedProduct.Foto);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string genre = ProductListBox.SelectedItem as string;
            // Получаем список товаров для этой категории
            if (tovar_.TryGetValue(genre, out List<Product> films))
            {
                // Очищаем RichTextBox перед выводом
                TextRichBox.Clear();

                // Перебираем все товары и выводим их информацию
                foreach (var film in films)
                {
                    TextRichBox.AppendText($"Название: {film.Name}, ");
                    TextRichBox.AppendText($"Осталось прокатов: {film.Kol_vo}\n");
                }
            }
        }

        private void buttonOt_Click(object sender, EventArgs e)
        {
            Product selectedFilms = ProductComboBox.SelectedItem as Product;
            if (selectedFilms != null)
            {
                string drugName = selectedFilms.Name;
                int quantity = (int)NumericUpDown.Value;
                if (orderItems_.ContainsKey(drugName))
                {
                    orderItems_[drugName] += quantity;
                }
                else
                {
                    orderItems_[drugName] = quantity;
                }

                string orderText = "Заказано товаров:\n";
                foreach (var item in orderItems_)
                {
                    orderText += $"{item.Key}: {item.Value}.\n";

                }

                MessageBox.Show(orderText, "Текущий заказ");
            }
        }
    }
}
