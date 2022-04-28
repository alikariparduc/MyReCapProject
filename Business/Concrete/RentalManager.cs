using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {

            var result =(_rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate > rental.RentDate));
            if (result.Count>0)
            {
                return new ErrorResult(Messages.RentalErrorMessage);
            }
            
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalToAddMessage);

            
            

        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
                
        }

        public IDataResult<List<Rental>> GetAllByReturnDate()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.ReturnDate<DateTime.Now));
        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
