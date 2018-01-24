using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingBus.Services;

namespace BookingBus.Controllers
{
    public class HomeController : Controller
    {
        private static TicketsService _ticketService;

        public HomeController()
        {
            _ticketService = new TicketsService();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TicketsTable(string from, string to, string date)
        {
            var tickets = _ticketService.GetTickets(from, to, date);
            return View(tickets);
        }
    }
}