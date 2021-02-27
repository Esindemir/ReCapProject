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
        

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        

        public List<Car> GetCarsByBrandId(int id) 
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public IEnumerable<Car> GetCarssByDailyPrice()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetCarssByDailyPrice(decimal minPrice, decimal maxPrice)
        {
            return _carDal.GetAll(c => c.DailyPrice >= minPrice && c.DailyPrice <= maxPrice);
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }
    }
}
