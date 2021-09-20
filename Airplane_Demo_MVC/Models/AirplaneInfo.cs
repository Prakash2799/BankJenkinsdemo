using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Airplane_Demo_MVC.Models
{
    public class AirplaneInfo
    {
        public string Flightnumber { get; set; }
        
        public string Source { get; set; }
        public string Destination { get; set; }
        [DisplayFormat(DataFormatString ="{0:HH:mm}",ApplyFormatInEditMode = true)]
        public DateTime Arrival { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
                public DateTime Departure { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
    
        public DateTime Duration { get; set; }
        public string TicketFare { get; set; }

    }
}
