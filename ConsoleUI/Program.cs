using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarName = "Ford", DailyPrice = 20000 });
            carManager.Add(new Car { CarName = "jeep", DailyPrice = 30000 });
                

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("ModelName:" + car.CarName + "CarId:" + car.Id + "Description:" + car.Description);
            }
            foreach (var car in carManager.GetCarssByDailyPrice(150,200))
            {
                Console.WriteLine("Car Name:" + car.CarName + "Model:" + car.ModelYear );


            }
        }
    } 
}
