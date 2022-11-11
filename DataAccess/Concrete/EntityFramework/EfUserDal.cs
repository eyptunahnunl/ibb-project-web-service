using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, IbbProjectContext>, IUserDal
    {
        public void AddClaim(UserOperationClaim operationClaim)
        {
            using (var context = new IbbProjectContext())
            {
                var addedClaim = context.Entry(operationClaim);
                addedClaim.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new IbbProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<OperationClaim> GetOperationClaims()
        {
            using (var context = new IbbProjectContext())
            {
                var result = from claims in context.OperationClaims
                             select claims;
                return result.ToList();
            }
        }
          
        public List<OperationClaim> GetUserClaims(int userId)
        {
            using (var context = new IbbProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == userId
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }


    }
}
