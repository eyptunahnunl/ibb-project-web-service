using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {

        //IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<OperationClaim>> GetUserClaims(int userId);
        IDataResult<List<OperationClaim>> GetOperationClaims();
        IResult AddClaim(UserOperationClaim operationClaim);

        IResult Add(User user);
        IDataResult<User> GetByMail(string email);






    }
}
