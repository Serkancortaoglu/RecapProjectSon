using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 & car.Description.Length >= 2)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız ");
            }
             _carDal.Add(car);
         }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetCarsByBrandId(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetCarsByColorId(p => p.ColorId == Id);
        }
    }
}
