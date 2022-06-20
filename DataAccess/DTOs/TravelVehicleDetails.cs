using Core;

namespace DataAccess.DTOs
{
    public class TravelVehicleDetails:IDto
    {
        public string TransportVehicleTypeName { get; set; }
        public string TransportVehicleName { get; set; }
        public string TransportVehicleDetails { get; set; }
        public string AccommodationToolTypeName { get; set; }
        public string AccommodationToolName { get; set; }
        public string AccommodationToolDetails { get; set; }

    }
}
