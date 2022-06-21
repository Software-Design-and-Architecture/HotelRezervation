using System;
using System.Collections.Generic;
using System.Text;
using ReportingProcesses.Abstract;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ReportingProcesses.Concrete
{
    public class JsonReportBuilder : IReportBuilder
    {
        public JsonReportBuilder(Report report):base (report)
        {

        }

        public override string BuildPriceDetails()
        {
            string front= "\"Fiyat Bilgileri\": [";
            string jsonString = JsonSerializer.Serialize(report.priceDetails);
            jsonString += "],";
            return front+jsonString;
        }

        public override string BuildTravelDetails()
        {
            string front = "\"Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\": [";
            string jsonString = JsonSerializer.Serialize(report.travelDetails);
            //string json = report.travelDetails.DepartureDate.ToString() + report.travelDetails.DateOfReturn.ToString();
            jsonString += "],";
            return front+jsonString;
        }

        public override string BuildTravelVehicleDetails()
        {
            string front = "\"Seyahat hakkında detaylı bilgileri(ulaşım ve konaklama bilgileri)\": [";
            string jsonString = JsonSerializer.Serialize(report.travelVehicleDetails);
            //string json = report.travelVehicleDetails.TransportVehicleDetails.ToString() + report.travelVehicleDetails.AccommodationToolName.ToString();
            jsonString += "],";
            return front + jsonString;
        }
    }
}
