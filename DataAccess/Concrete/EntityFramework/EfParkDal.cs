using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfParkDal : EfEntityRepositoryBase<Park, IbbProjectContext>, IParkDal
    {
        public List<ParkJoinDto> GetParkJoins()
        {
            using(IbbProjectContext context = new IbbProjectContext())
            {
                var result = from p in context.Parks
                             join t in context.ParkTypes
                             on p.TypeId equals t.Id
                             join m in context.Managements
                             on p.ManagementId equals m.Id
                             select new ParkJoinDto
                             {
                                 ParkId = p.Id,
                                 ParkName=p.ParkName,
                                 CountyName=p.CountyName,
                                 TypeName=t.TypeName,
                                 ManagementName=m.ManagementName,
                                 Coordinates=p.Coordinates
                             };
                return result.ToList();
            }
        }
    }
}
