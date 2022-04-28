using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();//Liste olduğu için IDataResult tipinde dönüş olacak.
        IResult Add(User user);//Ekleme işleminde geriye data döndürmeyeceği için IResult olacak sadece mesaj dönecek.
    }
}
