using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //'O' Open Closed Principle 
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("CategorId = 2 ");
            Console.WriteLine("-------------------------");
            foreach (var product in productManager.GetAllByCategoryId(2)) //CategoryId = 2 olanlar listelendi
            {
                Console.WriteLine(product.ProductName);//Northwinddeki ürünleri lsitler
            }
            Console.WriteLine();
            Console.WriteLine("50<UnitPrice<100");
            Console.WriteLine("-------------------------");
            foreach (var product in productManager.GetByUnitPrice(50,100))//50<UnitPirce<100 olan üürnlerin ismini listeler
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
