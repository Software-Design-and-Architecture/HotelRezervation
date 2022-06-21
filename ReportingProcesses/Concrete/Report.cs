using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.DTOs;
using ReportingProcesses.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingProcesses.Concrete 
{ 
    public class Report
    {
        public PriceDetails priceDetails = new PriceDetails();
        public TravelDetails travelDetails = new TravelDetails();
        public TravelVehicleDetails travelVehicleDetails = new TravelVehicleDetails();
    }
}
