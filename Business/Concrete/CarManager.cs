using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal; // Bir db ye bağımlı çalışmamak için dbleri implemente eden referanslarını tutan interfaceye erişiyoruz.
        //Böylece ister oracelede ister sqlde acceste çalışabilir sistem geçişini kolayca sağlayabilriz.
        public CarManager(ICarDal carDal) //Bu constructorda CarManager newlendiğinde ICarDal tipinde bir carDal isteyecek yani türkçesi
            //hangi veritabananında çalışıcam ben bana söyle diyecek.
        {
            _carDal = carDal;//_carDal nesnesine hangi dbde olacağı aktarılacak.Böylece GetAll metodu çağırıldığında hangi dbnin verisini
            //getireceğini anlayacak.
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();//Yukarıda belirtilen dbdeki GetAll _carDal nesnesi yardımıyla çağırılacak.
        }
    }
}
