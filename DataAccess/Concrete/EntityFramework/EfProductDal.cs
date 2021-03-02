using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        //NuGet //microdoftentityframworkcore.sqlserver ekledik DataAccess'e
        //veritabanı ile kendi classlarımızı ilişkilendirmek için context kurarız(Northwindcontext)
        public void Add(Product entity)
        {
            // usingi niye yazdık garbage colllecter. IDisposable pattern implementasyonu araştır
            using (NorthwindContext context = new NorthwindContext ()) //USİNG TAB TAB
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext ())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext()) 
            {
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();//filter = null ise Product veritabanının tümünü listeye çevir ve bana ver(sql'deki select * from products ile aynı) : filtre varsa da ":" sonrası çalışır Ternary operatörü
            }
        }

        public List<Product> GetAllByCategoryıd(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext()) //USİNG TAB TAB
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
