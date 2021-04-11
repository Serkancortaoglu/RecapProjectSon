using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public  interface IEntityRepository<T> where T:class,IEntity,new()
    {

      List<T>  Get(Expression<Func<T, bool>> filter=null);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T item);
        void Update(T item);
        void Delete(T item);

        List<T> GetCarsByBrandId(Expression<Func<T,bool>> filter);
        List<T> GetCarsByColorId(Expression<Func<T, bool>> filter);


    }
}
