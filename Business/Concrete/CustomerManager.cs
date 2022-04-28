using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;//Buradaki getAll çalıştır diyebilmek için referans tip oluşturuyorum.
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
           
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerCreateMessage);
            

        }

        

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.CustomerListMessage);
        }

        public IDataResult<List<CustomerDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<CustomerDto>>(_customerDal.GetAllCarDetails(), Messages.CustomerListMessage);
        }
    }
}
