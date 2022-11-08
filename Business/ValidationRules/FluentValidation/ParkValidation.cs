using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ParkValidation :AbstractValidator<Park>
    {
        public ParkValidation()
        {
            RuleFor(park => park.ParkName).NotEmpty();
            RuleFor(park => park.CountyName).NotEmpty();
            RuleFor(park => park.Id).NotEmpty();
        }
    }
}
