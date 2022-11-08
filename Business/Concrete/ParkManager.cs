using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;

using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;
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


        [ValidationAspect(typeof(ParkValidation))]
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

        [ValidationAspect(typeof(ParkValidation))]
        [SecuredOperation("park.update,admin")]
       
        public IResult Update(Park park)
        {
            _parkDal.Update(park);
            return new SuccessResult(Messages.ParkUpdate);
        }


  
    }
}
