using Business.Concrete;
using DataAccess.Concrete.Entity;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InMemoryCarDal inMemoryCarDal = new InMemoryCarDal(); Bu şekilde  InMemoryCarDal db ye erişim sağlanır onun üzerindne gider.

            //CarManager carManager = new CarManager(new EfMemoryCarDal());//Burda ise sadece parantez içindeki değere bakar db bağımlılığından kurtarır.
            //foreach (var cars in carManager.GetAll())
            //{
            //    Console.WriteLine(cars.Description); 
            //}

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
