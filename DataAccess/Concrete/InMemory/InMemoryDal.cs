using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _car;
        public InMemoryDal()
        {
            _car = new List<Car>
            {
                new Car
                {
                      BrandId=7,
                ColorId=17,
                Id=27,
                DailyPrice=77,
                Description="Good"



            }
            };


        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car cartoDelete = _car.SingleOrDefault(p => p.BrandId == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }


}




