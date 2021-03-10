using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()//TEntityy class olmalı IEntity yazılmasın diye new'ledik
        where TContext:DbContext,new()
        {
          public void Add(TEntity entity)
            {
                // usingi niye yazdık garbage colllecter. IDisposable pattern implementasyonu araştır
                using (TContext context = new TContext()) //USİNG TAB TAB
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
            }

            public void Delete(TEntity entity)
            {
                using (TContext context = new TContext())
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }

            public TEntity Get(Expression<Func<TEntity, bool>> filter)
            {
                using (TContext context = new TContext())
                {
                    return context.Set<TEntity>().SingleOrDefault(filter);
                    //SingleOrDefault tek öğe, FirstOrDefault kullanılrısa da ilk geleni verir
                }
            }

            public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
            {
                using (TContext context = new TContext())
                {
                    return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();//filter = null ise Product veritabanının tümünü listeye çevir ve bana ver(sql'deki select * from products ile aynı) : filtre varsa da ":" sonrası çalışır Ternary operatörü
                }
            }

            public List<TEntity> GetAllByCategoryıd(Func<object, object> p)
            {
                throw new NotImplementedException();
            }

            public void Update(TEntity entity)
            {
                using (TContext context = new TContext()) //USİNG TAB TAB
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
}
