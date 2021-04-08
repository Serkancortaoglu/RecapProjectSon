using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new InMemoryDal());
            {
                foreach (var s in manager.GetAll())
                {
                    Console.WriteLine(s.BrandId+" "+s.DailyPrice+""+s.Description);
                }
            }


        }
    }
}
