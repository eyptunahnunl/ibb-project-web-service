using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Castle.Core.Resource;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult AddClaim(UserOperationClaim operationClaim)
        {
            var businessResult = BusinessRules.Run(
                    CheckIfAlreadyHaveClaim(operationClaim)
                );
            if (businessResult != null)
            {
                return businessResult;
            }
            _userDal.AddClaim(operationClaim);
            return new SuccessResult();
        }

        [SecuredOperation("user")]
        public IDataResult<List<OperationClaim>> GetOperationClaims()
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetOperationClaims());

        }
        public IDataResult<List<OperationClaim>> GetUserClaims(int userId)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetUserClaims(userId));
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            
            return new SuccessResult();
        }
        public IDataResult<User> GetByMail(string email)
        {
            var result = _userDal.Get(u => u.Email == email);
            if (result != null)
            {
                return new SuccessDataResult<User>(result);
            }
            return new ErrorDataResult<User>(Messages.UserDoesntExists);
        }

        //public IDataResult<List<OperationClaim>> GetClaims(User user)
        //{

        //    return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user), Messages.UserClaim);
        //}


        ///Methodss
        ///
        private IResult CheckIfAlreadyHaveClaim(UserOperationClaim operationClaim)
        {
            var claims = GetUserClaims(operationClaim.UserId);
            if (claims.Data.Any(c => operationClaim.OperationClaimId == c.Id))
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

    }
}
