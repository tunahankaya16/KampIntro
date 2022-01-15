using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Abstract;

namespace DataAccess.Concrete
{
  public  class InMemoryDal: ICarDal
    {
        List<Car> _Cars;

        public InMemoryDal()
        {
            _Cars = new List<Car>
        {
            new Car{ID=1,BrandId="Tesla",ModelYear=2019,Description="Red Tesla Model S Electric Sedan Automobile.",ColorId="Red",DailyPrice=150},
            new Car{ID=2,BrandId="Ford",ModelYear=2013,Description="Blue Ford Mustang Sport Car.",ColorId="Blue",DailyPrice=50},
            new Car{ID=3,BrandId="Mercedes",ModelYear=2021,Description="Grey Mercedes A Class Sedan Automobile.",ColorId="Grey",DailyPrice=130},
            new Car{ID=4,BrandId="Audi",ModelYear=2020,Description="Black Audi A6 Sedan Automobile.",ColorId="Black",DailyPrice=250}
        };
        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car toDelete = _Cars.SingleOrDefault(c => c.ID == car.ID);
            _Cars.Remove(toDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars; 
        }

        public void Update(Car car)
        {
            Car toUpdate = _Cars.SingleOrDefault(c => c.ID==car.ID);
            toUpdate.ID = car.ID;
            toUpdate.BrandId = car.BrandId;
            toUpdate.ColorId = car.ColorId;
            toUpdate.ModelYear = car.ModelYear;
            toUpdate.DailyPrice = car.DailyPrice;
            toUpdate.Description = car.Description;
        }
    }
}
