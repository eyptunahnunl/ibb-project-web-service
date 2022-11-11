using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class IsPark :IEntity
    {

        public int Id { get; set; }
        public string ParkName { get; set; }
        public string LocationName { get; set; }
        public string ParkType { get; set; }
        public string CapacityofPark { get; set; }
        public string CountyName { get; set; }
        public string WorkingTime { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
    }
}
