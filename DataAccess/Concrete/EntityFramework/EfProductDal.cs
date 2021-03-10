using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal//IproductDal'ı almamızın sebebi product'a çzel ifadeleri IProductDal'a yaıp buraya implemente edeceğiz.
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext ())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
                //20-25 arasındaki kod bloğu der ki products ile join'i birleşitr ortak kategori Id 'ler üzerinden ve Colıumn'Lar ProdcutDetail Calssımızdaki verilerle eşleşsin.
            }
        }
    }
}
