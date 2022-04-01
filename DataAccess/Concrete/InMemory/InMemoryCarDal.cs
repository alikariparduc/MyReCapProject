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
        List<Car> _cars = null; // _cars adında Car classı tipinde bir liste oluştur ve başlangıç deperini null yap.
        public InMemoryCarDal() // Constructor. InMemoryCarDal newlendiğinde _cars listesini doldur bir anlamda dbden veriyi çek.
        {
            _cars = new List<Car>{
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=150,Description="Renault Clio-Dolu Paket" },
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2021,DailyPrice=200,Description="Hyundai Blue-Otomatik Vites"},
                new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2022,DailyPrice=212,Description="Mazda 3-Düz Vites"},
                new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2019,DailyPrice=222,Description="Honda Civic-Otomatik Vites"},
            };
        
        }
     
        public void Add(Car car)
        {
            _cars.Add(car);//_cars listesine Car tipinde car isminde gelen değerleri Add(ekle).
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);//_cars listesi içinde sana car nesnesiyle gönderilen car.Id değerini bul 
            _cars.Remove(carToDelete);// ve sil
        }

        public List<Car> GetAll()
        {
            return _cars; // Tüm listeyi dön.
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList(); // Verilen marka ıdsine göre listeyi dön.
        }

        public void Update(Car car)// car ile gönderilen değerleri update et.
        {
            Car carToUpdatete = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdatete.Id = car.Id;
            carToUpdatete.BrandId = car.BrandId;
            carToUpdatete.ColorId = car.ColorId;
            carToUpdatete.ModelYear = car.ModelYear;
            carToUpdatete.DailyPrice = car.DailyPrice;
            carToUpdatete.Description = car.Description;
        }
    }
}
