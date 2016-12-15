using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShipCruise.Models
{
    public class Ticket
    {
        public int id { get; set; }
        public int seatnumber { get; set; }
        public string shipType { get; set; }
        public string shipName { get; set; }
        public string startLocation { get; set; }
        public string destination { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float price { get; set; }
        public string email { get; set; }
        
    }

}