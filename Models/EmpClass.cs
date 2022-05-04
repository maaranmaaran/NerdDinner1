using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NerdDinner.Models
{
    public class EmpClass
    {
        public int DinnerID { get; set; }
        public string Title { get; set; }
        public int EventDate { get; set; }
        public string Description { get; set; }
        public string HostedBy { get; set; }
        public int ContactPhone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
    }
}