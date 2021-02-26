using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            /* Car car1 = new Car
             {
                 BrandId=2,
                 ColorId=3,
                 Model="Opel",
                 DailyPrice=180,
                 Description="Astra"
             };
             carManager.Add(car1);*/
            carManager.GetCarDetails().ForEach(c => Console.WriteLine(c.CarName+"/"+c.ColorName));
            Console.ReadKey();

        }
    }
}
