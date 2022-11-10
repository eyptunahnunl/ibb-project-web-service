using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ParkJoinDto : IDto
    {
        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public string CountyName { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string ManagementName { get; set; }
        public string TypeName { get; set; }
    }
}
