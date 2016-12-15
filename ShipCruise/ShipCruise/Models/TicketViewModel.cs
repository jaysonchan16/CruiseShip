using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShipCruise.Models
{
    public class TicketViewModel
    {
        public IEnumerable<Schedule> myschedules { get; set; }
        public IEnumerable<Ticket> mytickets { get; set; }
    }
}