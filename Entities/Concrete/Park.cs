using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Park:IEntity
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int ManagementId { get; set; }
        public string ParkName { get; set; }
        public string CountyName { get; set; }
        public string Coordinates { get; set; }

    }
}
