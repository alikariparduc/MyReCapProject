using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.Entity
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, SqlDbContext>, IRentalDal
    {
        
      
    }
}
