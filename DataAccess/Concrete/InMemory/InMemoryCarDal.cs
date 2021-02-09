using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id=2,BrandId=3,ColorId=6,DailyPrice=340,ModelYear="2021",Description="BMW" },
            new Car { Id = 1, BrandId = 7, ColorId = 3, DailyPrice = 280, ModelYear = "2013", Description = "Audi" },
            new Car { Id = 5, BrandId = 2, ColorId = 1, DailyPrice = 200, ModelYear = "2008", Description = "Hyundai" },
            new Car { Id = 6, BrandId = 1, ColorId = 2, DailyPrice = 190, ModelYear = "2005", Description = "Honda" },
            new Car { Id = 4, BrandId = 5, ColorId = 8, DailyPrice = 230, ModelYear = "2001", Description = "Nissan" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           /* Car carToDelete=null;
            foreach (var c in _cars)
            {
                if (car.Id==c.Id)
                {
                    carToDelete = c;
                }
            }*/
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id== car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _cars.Where(c => c.Id == Id).ToList();  
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
