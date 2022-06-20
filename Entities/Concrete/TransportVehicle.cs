using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TransportVehicle:IEntity
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string CompanyName { get; set; }
        public string TransportVehiclesDetails { get; set; }
        public string StartingPoint { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
    }
}
