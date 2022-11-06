using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
     public class ParkManager : IParkService
    {
        IParkDal _parkDal;

        public ParkManager(IParkDal parkDal)
        {
            _parkDal = parkDal;
        }

        [SecuredOperation("admin,park.add")]
        public IResult Add(Park park)
        {
            _parkDal.Add(park);
            return new SuccessResult(Messages.ParkAdded);
        }
        
        public IDataResult<List<Park>> GetAll()
        {
            return new SuccessDataResult<List<Park>>(_parkDal.GetAll(), Messages.ParkListed);
        }

        public IDataResult<List<ParkJoinDto>> GetParkDetails()
        {
            return new SuccessDataResult<List<ParkJoinDto>>(_parkDal.GetParkJoins(),Messages.ParkDetailListed);
           

        }

        public IResult Update(Park park)
        {
            throw new NotImplementedException();
        }
    }
}
