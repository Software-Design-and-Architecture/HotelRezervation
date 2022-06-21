using ReportingProcesses.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReportingProcesses.Abstract
{
    public abstract class IReportBuilder
    {
        protected Report report;

        public IReportBuilder(Report report)
        {
            this.report = report;
        }

        public abstract string BuildPriceDetails();
        public abstract string BuildTravelDetails();
        public abstract string BuildTravelVehicleDetails();

       

    }
}
