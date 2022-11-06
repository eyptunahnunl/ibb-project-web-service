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
        where TEntity : class,IEntity,new()
        where TContext: DbContext,new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext()) // using bitince bellekten atan yapı
            {
                var addedEntity = context.Entry(entity); // veri kaynağı ile eşleştirdi. Referansı yakaladı
                addedEntity.State = EntityState.Added; // Eklendi
                context.SaveChanges();   //Değişiklikler kaydedildi. 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) // using bitince bellekten atan yapı
            {
                var deletedEntity = context.Entry(entity); // veri kaynağı ile eşleştirdi. Referansı yakaladı
                deletedEntity.State = EntityState.Deleted; // Eklendi
                context.SaveChanges();   //Değişiklikler kaydedildi. 
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) // using bitince bellekten atan yapı
            {
                var updatedEntity = context.Entry(entity); // veri kaynağı ile eşleştirdi. Referansı yakaladı
                updatedEntity.State = EntityState.Modified; // Eklendi
                context.SaveChanges();   //Değişiklikler kaydedildi. 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();



                // select * from product çalıştıp listeye döndürüyor gibi düşünülebilir. 
            }
        }

    }
}
