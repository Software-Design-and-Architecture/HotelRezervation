using ReportingProcesses.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingProcesses.Concrete
{
    public class ReportManager
	{
        private IReportBuilder reportBuilder;
        public ReportManager(IReportBuilder reportBuilder)
        {
            this.reportBuilder = reportBuilder;
        }
		
		public string Build()
        {
			string report = reportBuilder.BuildTravelDetails();
			report += reportBuilder.BuildTravelVehicleDetails();
			report += reportBuilder.BuildPriceDetails();
			
			return report;
        }
		public string Build2()
		{
			string report = reportBuilder.BuildTravelDetails();
			report += reportBuilder.BuildPriceDetails();
			report += reportBuilder.BuildTravelVehicleDetails();
			return report;
		}
		public string Build3()
		{
			string report = reportBuilder.BuildTravelVehicleDetails();
			report += reportBuilder.BuildTravelDetails();
			report += reportBuilder.BuildPriceDetails();
			return report;
		}
		public string Build4()
		{
			string report = reportBuilder.BuildPriceDetails();
			report += reportBuilder.BuildTravelVehicleDetails();
			report += reportBuilder.BuildTravelDetails();
			return report;
		}
	}
}
