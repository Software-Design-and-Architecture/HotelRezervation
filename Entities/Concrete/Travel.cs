using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Travel:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime DateOfReturn { get; set; }
        public string Location { get; set; }
        public int TransportVehiclesId { get; set; }
        public int AccommodationToolsId { get; set; }
        public decimal Price { get; set; }
    }
}
