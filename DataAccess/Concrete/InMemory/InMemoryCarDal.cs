﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=2015, DailyPrice=30000, Description="Manual"},
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear=2014, DailyPrice=40000, Description="Hybrid"},
                new Car{Id=3, BrandId=3, ColorId=2, ModelYear=2016, DailyPrice=50000, Description="Diesel"},
                new Car{Id=4, BrandId=4, ColorId=3, ModelYear=2018, DailyPrice=60000, Description="Diesel,Manual"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id ).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
