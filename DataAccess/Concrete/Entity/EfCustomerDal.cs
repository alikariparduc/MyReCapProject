using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Entity
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, SqlDbContext>, ICustomerDal
    {
        public List<CustomerDto>GetAllCarDetails()
        {
            using (SqlDbContext context = new SqlDbContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id
                             select new CustomerDto
                             {
                                 CustomerId = c.Id,
                                 UserId = u.Id,
                                 CustomerFirstName = u.FirstName,
                                 CustomerEmail = u.Email,
                                 CustomerLastName = u.LastName,
                                 CompanyName = c.CompanyName
                                 

                             };
                return result.ToList();

            }
        }
    }
}
