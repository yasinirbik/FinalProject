using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);//Void'in default'u zaten public'tir dolayısıyla önlerine bir şey yazmamıza gerek yok.
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetByCategory(int categoryId);//Üürrnleri kategoriye göre listele


    }
}
