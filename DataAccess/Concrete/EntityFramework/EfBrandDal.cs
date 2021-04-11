using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brands item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brands item)
        {
            throw new NotImplementedException();
        }

        public List<Brands> Get(Expression<Func<Brands, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetCarsByBrandId(Expression<Func<Brands, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetCarsByColorId(Expression<Func<Brands, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Brands item)
        {
            throw new NotImplementedException();
        }
    }
}
