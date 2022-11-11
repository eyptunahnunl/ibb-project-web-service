using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class IsParkManager : IIsParkService
    {
        IIsParkDal _isParkDal;

        public IsParkManager(IIsParkDal isParkDal)
        {
            _isParkDal = isParkDal;
        }



        public IResult Add(IsPark isPark)
        {
            _isParkDal.Add(isPark);
            return new SuccessResult(Messages.ParkAdded);
        }

        public IDataResult<List<IsPark>> GetAllIsPark()
        {
            return new SuccessDataResult<List<IsPark>>(_isParkDal.GetAll(), Messages.IsParkListed);
        }

        public IResult Update(IsPark isPark)
        {
            throw new NotImplementedException();
        }
        

    }
}
