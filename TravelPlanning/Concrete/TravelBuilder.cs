using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlanning.Abstract;

namespace TravelPlanning.Concrete
{
    public class TravelBuilder
    {
        private ITravelFactory _seyhatFabrikası;
        private ITransportation _ulasım;
        private IAccomodation _konaklama;
        public TravelBuilder(ITravelFactory seyhatFabrikası)
        {
            _seyhatFabrikası = seyhatFabrikası;
            _ulasım = seyhatFabrikası.Transportation();
            _konaklama = seyhatFabrikası.Accomodation();
        }
        public List<AccommodationTool> GetAllAccommodationTools()
        {
            return _konaklama.GetAllAccommodationTools();
        }
        public List<TransportVehicle> GetAllTransportVehicles()
        {
            return _ulasım.GetAllTransportVehicles();
        }
    }
}
