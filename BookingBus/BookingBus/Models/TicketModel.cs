using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingBus.Models
{
    public class TicketModel
    {
        public string FromCity { get; set; }

        public string ToCity { get; set; }

        public DateTime Time { get; set; }

        public int PlacesCount { get; set; }
    }
}