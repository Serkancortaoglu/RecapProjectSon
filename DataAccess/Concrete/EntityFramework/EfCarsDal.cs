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
    public class EfCarsDal : ICarDal
    {
        public void Add(Car item)
        {
            using (CarContext context = new CarContext())
            {
                var addedEntity = context.Entry(item);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car item)
        {
            using (CarContext context = new CarContext())
            {
                var deleteToEntity = context.Entry(item);
                deleteToEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                return filter == null
                   ? context.Set<Car>().ToList()
                   : context.Set<Car>().Where(filter).ToList();
            }

        }
            public List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter = null)
            {
            using (CarContext context = new CarContext())
            {
                return filter == null
                   ? context.Set<Car>().ToList()
                   : context.Set<Car>().Where(filter).ToList();
            }

        }

            public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
            {
            using (CarContext context = new CarContext())
            {
                return filter == null
                   ? context.Set<Car>().ToList()
                   : context.Set<Car>().Where(filter).ToList();
            }
        }

            public void Update(Car item)
            {
               using (CarContext context=new CarContext())
              {
                var updateEntity = context.Entry(item);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
              }
            }
        }
    }


