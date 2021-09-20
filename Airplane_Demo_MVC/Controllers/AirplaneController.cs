using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airplane_Demo_MVC.Models;
namespace Airplane_Demo_MVC.Controllers
{
    public class AirplaneController : Controller
    {
        public IActionResult Index()
        {
            List<AirplaneInfo> list = new List<AirplaneInfo>()
            {
                new AirplaneInfo()
                {
                    Flightnumber = "65AAD",
                    Source = "Chennai",
                    Destination = "Mumbai",
                    Arrival = Convert.ToDateTime("18:00"),
                    Departure = Convert.ToDateTime("21:25"),
                    Duration=Convert.ToDateTime("3:25"),
                    TicketFare = "7677"
                },
                new AirplaneInfo()
                {
                    Flightnumber = "87AAR",
                    Source = "Delhi",
                    Destination = "Mumbai",
                    Arrival = Convert.ToDateTime("15:00"),
                    Departure = Convert.ToDateTime("17:25"),
                    Duration=Convert.ToDateTime("2:25"),
                    TicketFare = "8977"
                },
            };
            return View(list);
        }
    }
}
