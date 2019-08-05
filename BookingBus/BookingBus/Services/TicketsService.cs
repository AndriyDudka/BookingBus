using System;
using System.Collections.Generic;
using System.Globalization;
using BookingBus.Models;

namespace BookingBus.Services
{
    public class TicketsService
    {
        private readonly List<TicketModel> tickets = new List<TicketModel>();

        public TicketsService()
        {
            tickets = new List<TicketModel>
            {
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("25.01.2018 06:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("25.01.2018 07:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("25.01.2018 08:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("26.01.2018 08:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("25.01.2018 09:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Мукачево", ToCity = "Ужгород",
                    Time = Convert.ToDateTime("25.01.2018 09:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },

                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("23.01.2018 06:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("24.01.2018 07:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("25.01.2018 08:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("26.01.2018 08:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("25.01.2018 09:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Ужгород", ToCity = "Мукачево",
                    Time = Convert.ToDateTime("25.01.2018 09:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },

                new TicketModel
                {
                    FromCity = "Крисовці", ToCity = "Пацканьово",
                    Time = Convert.ToDateTime("23.01.2018 06:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Крисовці", ToCity = "Пацканьово",
                    Time = Convert.ToDateTime("24.01.2018 07:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Крисовці", ToCity = "Пацканьово",
                    Time = Convert.ToDateTime("25.01.2018 08:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "Крисовці", ToCity = "Пацканьово",
                    Time = Convert.ToDateTime("26.01.2018 08:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },

                new TicketModel
                {
                    FromCity = "УжНУ", ToCity = "Армія",
                    Time = Convert.ToDateTime("25.01.2018 09:15", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                },
                new TicketModel
                {
                    FromCity = "УжНУ", ToCity = "Армія",
                    Time = Convert.ToDateTime("25.01.2018 09:45", CultureInfo.GetCultureInfo("uk-UA")), PlacesCount = 36
                }
            };
        }

        public List<TicketModel> GetTickets(string from, string to, string date)
        {
            var res = new List<TicketModel>();
            foreach (var ticket in tickets)
            {
                if (ticket.FromCity == from && ticket.ToCity == to && ticket.Time.Date == Convert.ToDateTime(date))
                {
                    res.Add(ticket);
                }
            }

            return res;
        }
    }
}