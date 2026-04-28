using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLr_3;
using lr_3;
using static Test_Lr.UnitTest1;
using System.IO;

namespace Test_Lr
{
    [TestClass]
    public class UnitTest1
    {
        private ProductModul storage;
        private List<Product> allProduct;

        [TestInitialize]
        public void TestInitialize()
        {
            storage = new ProductModul();
            allProduct = storage.LoadDataFromCsv();
        }

        [TestMethod]
        public void TCalculateTotalPrice()
        {

            Product product = allProduct[0]; //трансформеры

            double shows = 5;

            double totalPrice = product.Price * shows;

            Assert.AreEqual(250, product.Price, "Цена продукта не совпадает");
            Assert.AreEqual(1250, totalPrice, "Итоговая сумма должна быть 1250");
        }



        [TestMethod]
        public void TFilterGenre()
        {

            List<Product> expectedAction = new List<Product>();
            expectedAction.Add(allProduct[0]);
            expectedAction.Add(allProduct[1]);
            List<Product> expectedFantasy = new List<Product>();
            expectedFantasy.Add(allProduct[2]);
            expectedFantasy.Add(allProduct[3]);

            List<Product> actionProduct = new List<Product>();
            foreach (Product product in allProduct)
            {
                if (product.Name == "Овощи")
                {
                    actionProduct.Add(product);
                }


            }
            List<Product> fantasyProduct = new List<Product>();
            foreach (Product product in allProduct)

            {
                if (product.Name == "Фрукты")
                {
                    fantasyProduct.Add(product);
                }
            }

            CollectionAssert.AreEqual(expectedAction, actionProduct, "Список продуктов категории овощи не совпадает");
            CollectionAssert.AreEqual(expectedFantasy, fantasyProduct, "Список продуктов категории фрукты не совпадает");
        }


        [TestMethod]
        public void TGetAllMovies()
        {

            List<Product> expectedMovies = new List<Product>();
            expectedMovies.Add(new Product("Мандарины", 13.0, 5, 15, "../../Рисунок/Мандарины.jpg"));
            expectedMovies.Add(new Product("Гранаты", 25.0, 7, 13, "../../Рисунок/Гранат.jpg"));
            expectedMovies.Add(new Product("Огурцы", 8.0, 6, 34, "../../Рисунок/Огурцы.jpg"));
            expectedMovies.Add(new Product("Помидоры", 3.0, 5, 12, "../../Рисунок/Помидоры.jpg"));
            expectedMovies.Add(new Product("Курица", 20.0, 10, 35, "../../Рисунок/Куриное филе.jpg"));
            expectedMovies.Add(new Product("Говядина", 13.0, 10, 10, "../../Рисунок/Филе говядины.jpg"));



            Assert.AreEqual(expectedMovies.Count, allProduct.Count, "Количество продуктов не совпадает");

            for (int i = 0; i < expectedMovies.Count; i++)
            {
                Assert.AreEqual(expectedMovies[i].Name, allProduct[i].Name);
                Assert.AreEqual(expectedMovies[i].Price, allProduct[i].Price);
                Assert.AreEqual(expectedMovies[i].Kol_vo, allProduct[i].Kol_vo);
                Assert.AreEqual(expectedMovies[i].Data, allProduct[i].Data);
                Assert.AreEqual(expectedMovies[i].Foto, allProduct[i].Foto);
            }

        }

        [TestMethod]
        public void FilterFilms_ByGenre_ReturnsOnlyMatchingFilms() // Проверка фильтрации фильмов по жанру
        {

            List<Product> product = new List<Product>
            {
               new Product("Огурцы", 8.0, 6, 34, "../../Рисунок/Огурцы.jpg"),
               new Product("Помидоры", 3.0, 5, 12, "../../Рисунок/Помидоры.jpg")
            };

                List<Product> allProduct = product;
                List<Product> fantasyProduct = new List<Product>();
                foreach (Product products in allProduct)
                {

                if (products.Name == "Овощи")
                {
                    fantasyProduct.Add(products);
                }
                }

            List<Product> result = fantasyProduct;

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Властелин колец", result[0].Name);
            Assert.AreEqual("Гарри Поттер", result[1].Name);
        }

        
    }
}

    


    

