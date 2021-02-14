using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //AddCar(carManager);
            //GetAll(carManager);
            //GetByBrandId(carManager);

            foreach (var carDetail in carManager.GetCarDetails())
            {
                Console.WriteLine(carDetail.CarName + "-"+ carDetail.BrandName + "-" + carDetail.ColorName + "-" + carDetail.DailyPrice);
            }

            //brandManager.Add(new Brand {Name = "Yeşil" });
            //Console.WriteLine(brandManager.GetById(2).Name);

            //carManager.Update(new Car { Id=2,BrandId = 1, ColorId = 1, DailyPrice = 42, Description = "Otomatik", ModelYear = "3000" });

            Console.ReadLine();
        }

        private static void GetByBrandId(CarManager carManager)
        {
            foreach (var item in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(item.DailyPrice);

            }
        }

        private static void AddCar(CarManager carManager)
        {
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 42, Description = "Otomatik", ModelYear = "2011" });
            carManager.Add(new Car { BrandId = 2, ColorId = 5, DailyPrice = 200, Description = "Manual", ModelYear = "2015" });
            carManager.Add(new Car { BrandId = 3, ColorId = 4, DailyPrice = 100, Description = "Otomatik", ModelYear = "2000" });
            carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 422, Description = "Manual", ModelYear = "2021" });
        }

        private static void GetAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}
