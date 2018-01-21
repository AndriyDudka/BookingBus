using BookingBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookingBus.Services
{
    public class TicketsService
    {
        private List<TicketModel> tickets = new List<TicketModel>();

        public TicketsService()
        {
            tickets = new List<TicketModel>
            {
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 06:15"), PlacesCount = 36},
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 07:45"), PlacesCount = 36},
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 08:15"), PlacesCount = 36},
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 08:45"), PlacesCount = 36},
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 09:15"), PlacesCount = 36},
                new TicketModel{FromCity = "Мукачево", ToCity = "Ужгород", Time = Convert.ToDateTime("25.01.2018 09:45"), PlacesCount = 36}
            };
        }

        public List<TicketModel> GetTickets()
        {
            List<TicketModel> res = tickets;
            return res;
        }
    }
}