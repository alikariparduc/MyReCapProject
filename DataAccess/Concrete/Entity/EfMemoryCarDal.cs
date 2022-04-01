using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity
{
    public class EfMemoryCarDal:ICarDal
    {
        List<Car> _cars = null;
        public EfMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=150,Description="BMW 320-Dolu Paket" },
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=200,Description="Mercedess C-Otomatik Vites"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2022,DailyPrice=212,Description="Volvo S-Düz Vites"},
                new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2019,DailyPrice=222,Description="Dacia Duster-Otomatik Vites"},
            };
        }

        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
