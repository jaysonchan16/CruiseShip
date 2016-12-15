using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipCruise.Models
{
    public class PurchaseViewModel
    {
        public string shipname { get; set; }
        public string shipType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string startLocation { get; set; }
        public string destination { get; set; }
        public int seat { get; set; }
        public float price { get; set; }
        public int seatnumber { get; set; }
        public string email { get; set; }
    }
}