using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new EfCarsDal());
            {
                foreach (var s in manager.GetCarsByBrandId(18))
                {
                    Console.WriteLine(s.Description);
                }
            }


        }
    }
}
