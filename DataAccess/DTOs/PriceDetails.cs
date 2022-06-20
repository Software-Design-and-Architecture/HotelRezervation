using Core;

namespace DataAccess.DTOs
{
    public class PriceDetails:IDto
    {
        public decimal TransportVehiclePrice { get; set; }
        public decimal AccommodationToolPrice { get; set; }
        public decimal TravelPrice { get; set; }
    }
}
