using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        void AddClaim(UserOperationClaim operationClaim);
        List<OperationClaim> GetOperationClaims();
        List<OperationClaim> GetUserClaims(int userId);

    }
}
