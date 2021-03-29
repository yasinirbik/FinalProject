using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();//Tüm ürünleri listele//List döndürür//Data'yı da IResult'ı da döndürecektir.
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IResult Add(Product product);//Herhangi bir veritipi döndürmez
        IDataResult<List<ProductDetailDto>> GetProductDetails();//IDataResult'tan sonra ki kısım istenilen T'dir.
        IDataResult<Product> GetById(int productId); // Product Döndürür ve de IResult'ı
        IResult Update(Product product);

    }
}
