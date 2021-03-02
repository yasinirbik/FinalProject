using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlar.
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//override on yaz çıkan ilk öneriye tıkla
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = Northwind; Trusted_Connection = true");//Hangi veritabını ile ilişkilendireceğimizi belirten kod bloğu(11-13)
            //Northwind'e bağladıkTrusted_connection kısmı şifreye gerek duymadan bağlanmasını sağlar.
        }
        public DbSet<Product> Products { get; set; }//BENDE Kİ PRODUCT'I NORTHWİNDE DEKİ PRODUCTS'LA İLİŞKİLENDİRDİ
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
