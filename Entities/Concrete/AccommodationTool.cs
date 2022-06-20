using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AccommodationTool:IEntity
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string CompanyName { get; set; }
        public string AccommodationToolsDetails { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
    }
}
