using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIsParkService
    {
        IDataResult<List<IsPark>> GetAllIsPark();
        
        IResult Add(IsPark isPark);
        IResult Update(IsPark isPark);
    }
}
