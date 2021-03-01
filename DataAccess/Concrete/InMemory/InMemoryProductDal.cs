using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() // Constructor ctor//Proh-jeyi çalıstırdığımızda bellkete böyle bir veri olusturdu.
        {
            _products = new List<Product> { 
                new Product{ProductId = 1, CategoryId = 1,ProductName ="Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId = 2, CategoryId = 1,ProductName ="Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId = 3, CategoryId = 2,ProductName ="Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId = 4, CategoryId = 2,ProductName ="Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId = 5, CategoryId = 2,ProductName ="Mouse", UnitPrice = 85, UnitsInStock = 1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // _products.Remove(product);//BU ÇALIŞMAZ. REFERANS DEĞERİ KAYNAKLI
            //Product productToDelete;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }

            //    _products.Remove(productToDelete);
            //30-38 arası bir veriyi silmek için kullanabileceğimiz kod ama LINQ (Language Integrated Query) ile asagidaki sekilde deha kolayca da yazabiliriz

            Product productToDelete =  _products.SingleOrDefault(p=>p.ProductId == product.ProductId);//Her bir p için p nin product Id'si benim parametre ile gönderdiğim product'ın PrıductId ' sine eşit mi 

            _products.Remove(productToDelete);

            }

        public List<Product> GetAll()
        {
            return _products; //veritabanını olduğu gibi döndürürüz.
        }


        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //ürünün bütün verilerini güncelleriz eşitlerme yaparak    
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetByCategory(int categoryId)
        {
            //where kosuluna uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}

