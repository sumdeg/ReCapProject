using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Id);
            }
            Console.ReadKey();

        }
    }
}
