using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Generic Constrait
    public interface IEntityRepository<T>where T: class,IEntity,new()//T, IEntity YA DA IEntity'den implemente bir nesne olabilir.fakat new()'lenebilir dde olmalı şartıı getiririz, İnterfaevler new'lenemez dolayısıyla IEntity olamaz fakat T, IEntity'den implemente nesneler olur.sadece o nesneleri koyabiliriz
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//Filtre koyarak istediğimiz ürüneri listelyebilmemizi sağlayan yapı. Burada filtre null
        T Get(Expression<Func<T, bool>> filter);//Filtre koyarak istediğimiz ürüneri listelyebilmemizi sağlayan yapı
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
