using ReportingProcesses.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingProcesses.Concrete
{
    public class HtmlReportBuilder : IReportBuilder
    {

        public HtmlReportBuilder(Report report) : base(report)
        {

        }



        public override string BuildPriceDetails()
        {

          
            return string.Format("<table><tr><th> Fiyat Bilgileri </th></tr><tr><td> Ulasım Aracı Fiyatı:</td>" +
                "<td>{0}</td></tr> <tr><td> Konaklama Aracı Fiyatı:</td><td>{1}</td></tr><tr><td> Toplam Fiyat:</td><td>{2}</td></tr> </table>",this.report.priceDetails.TransportVehiclePrice,this.report.priceDetails.AccommodationToolPrice,report.priceDetails.TravelPrice);
        }
        public override string BuildTravelDetails()
        {
            return string.Format("<table><tr><th> Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri </th></tr>" +
                "<tr><td> Adı:</td><td>{0}</td></tr><tr><td> Soy Adı:</td> <td>{1}</td></tr><tr><td>Adresi:</td><td>{2}</td></tr><tr><td>Tatilin Konumu:</td><td>{3}</td>" +
                "</tr><tr><td> Gidiş Tarihi:</td><td>{4}</td></tr><tr><td> Dönüş Tarihi:</td><td>{5}</td></tr></table>"
                ,report.travelDetails.Name,report.travelDetails.LastName,report.travelDetails.Address,report.travelDetails.Location,report.travelDetails.DepartureDate,report.travelDetails.DateOfReturn);
        }
        public override string BuildTravelVehicleDetails()
        {
            return string.Format("<table> <tr><th> Seyahat hakkında detaylı bilgileri(ulaşım ve konaklama bilgileri) </th></tr><tr><td> Ulaşım Aracı Tipi:</td><td>{0}</td>"+
                     "</tr><tr><td> Ulaşım Aracı Adı:</td><td>{1}</td></tr><tr><td> Ulaşım Aracı Detayları:</td><td>{2}</td></tr><tr>"+
                     "<td> Konaklama Aracı Tipi:</td><td>{3}</td></tr><tr> <td> Konaklama Aracı Adı:</td><td>{4}</td></tr><tr><td> Konaklama Aracı Detayları:</td>"+
                     "<td>{5}</td></tr></table>"
                ,report.travelVehicleDetails.TransportVehicleTypeName,report.travelVehicleDetails.TransportVehicleName,report.travelVehicleDetails.TransportVehicleDetails,
                report.travelVehicleDetails.AccommodationToolTypeName,report.travelVehicleDetails.AccommodationToolName,report.travelVehicleDetails.AccommodationToolDetails
                );
        }

    }
}
