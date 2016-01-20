using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage2.Models
{
    public class vehicle
    {
        public int Id { get; set; }
        public string RegNumber { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}