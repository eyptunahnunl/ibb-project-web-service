using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IParkService
    {
        IDataResult<List<Park>> GetAll();
        IDataResult<List<ParkJoinDto>> GetParkDetails();
        IResult Add(Park park);
        IResult Update(Park park);

    }
}
