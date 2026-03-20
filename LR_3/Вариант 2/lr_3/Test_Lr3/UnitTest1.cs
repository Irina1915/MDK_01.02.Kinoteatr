using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Lr3
{
    [TestClass]
    public class UnitTest1
    {
        private FileDrogStorage storage;
        private Dictionary<string, List<Product> expectdProducts = new Dictionary<string, List<Product>>();

        [TestMethod]
        public void TestMethod1()
        {
            storage = new FileDrugStorage();
            expectdProducts.Add("Фрукты",
                 new List<Product>()
                 {
                    new Product ("Мандарины", 13.0, 5, 15, "../../Рисунок/Мандарины.jpg"),
                    new Product ("Гранаты", 25.0, 7, 13, "../../Рисунок/Гранат.jpg")
                 }
             );

            expectdProducts.Add("Овощи",
                new List<Product>()
                {
                    new Product ("Огурцы", 8.0, 6, 34, "../../Рисунок/Огурцы.jpg"),
                    new Product ("Помидоры", 3.0, 5, 12, "../../Рисунок/Помидоры.jpg")
                }
            );

            expectdProducts.Add("Мясо",
                new List<Product>()
                {
                    new Product ("Курица", 20.0, 10, 35, "../../Рисунок/Куриное филе.jpg"),
                    new Product ("Говядина", 13.0, 10, 10, "../../Рисунок/Филе говядины.jpg")
                }
            );
        }

        [TestMethod]
        public void TGetAllProduct()
        {
            List<Products> result = storage.LoadDateFrowCsv();

            // Подсчет общего кол-во продуктов из словаря
            int expectedTotalProduct = 0;
            foreach( var Product in expectdProducts)
            {
                expectdTotalProducts += Product.Value.Count;
            }

            Asswrt.AreEqual(expectedTotalProduct, result.Count, $"Должно быть загружено {expectedTotalProduct} продуктов");
        }
    }
}
