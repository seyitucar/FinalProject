﻿using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    // O : Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            // Alttaki koddan EfProductDal yerine herhangi bir database metodu seçilerek hiçbir koda dokunmadan değişim sağlanabilir. InMemoryProductDal seçilebilir.

            ProductTest();
            //IoC
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
    }
}