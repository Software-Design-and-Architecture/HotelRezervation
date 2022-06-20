using Core;
using System;

namespace DataAccess.DTOs
{
    public class TravelDetails:IDto
    {
        public DateTime DepartureDate { get; set; }
        public DateTime DateOfReturn { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
