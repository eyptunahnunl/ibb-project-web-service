
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


//Not.Namespace => isim uzayı 
//Core katmanı bu projeye bağımlı olmamalı.
//Genel sınıfları içermeli.
//Evrensel olmalı bütün .net projelerinde kullanılabilir olmalıdır.


namespace Core.DataAccess
{
    //Generic constraint
    //class : referans tip olabilir
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new(): newlenebilir olmali. (IEntity Interface olduğu için newlenemez !)
    public interface IEntityRepository<T> where T:class,IEntity,new() // T değişken ne verirsen onu alıyor ona yarıyor.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // ....GetAll(p=>p.CategoryId==2 gibi filtrelerin yazılmasını sağlar. Filter yoksa bütün datayı verir ! 
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
