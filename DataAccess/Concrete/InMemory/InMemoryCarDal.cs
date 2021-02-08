using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=200,Description="otomatik",ModelYear="2010"},
                new Car{Id=2,BrandId=2,ColorId=3,DailyPrice=180,Description="manuel",ModelYear="2012"},
                new Car{Id=3,BrandId=3,ColorId=6,DailyPrice=400,Description="otomatik",ModelYear="2019"},
                new Car{Id=4,BrandId=3,ColorId=4,DailyPrice=500,Description="manuel",ModelYear="2021"},
                new Car{Id=5,BrandId=4,ColorId=2,DailyPrice=250,Description="otomatik",ModelYear="2011"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=null;
            foreach (var c in _cars)
            {
                if (car.Id == c.Id)
                {
                    carToDelete = c;
                }
            }
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
