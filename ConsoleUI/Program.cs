using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //'O' Open Closed Principle 
    class Program
    {
        static void Main(string[] args)
        {
            // ProductGetTest();
            //ProductTest0();
            //ProductTest();
            // CategoryTest();
           // ProductTest1();

        }

        private static void ProductTest1()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "  - - -   " + product.CategoryName + " - - - " + product.UnitsInStock);//Bir tabloda datalar join edildi ve birden fazla satır ekrana getirildi.
            }
        }

        private static void ProductGetTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine();
            Console.WriteLine("All  Of Products ");
            Console.WriteLine("-------------------------");
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);//Kategori Adları listelenir.
            }
        }

        private static void ProductTest0()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("CategoryId = 2 ");
            Console.WriteLine("-------------------------");
            foreach (var product in productManager.GetAllByCategoryId(1)) //CategoryId = 2 olanlar listelendi
            {
                Console.WriteLine(product.ProductName);//Northwinddeki ürünleri lsitler
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("50<UnitPrice<100");
            Console.WriteLine("-------------------------");
            foreach (var product in productManager.GetByUnitPrice(50, 100))//50<UnitPirce<100 olan üürnlerin ismini listeler
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
