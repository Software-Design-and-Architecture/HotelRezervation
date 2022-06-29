using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.DTOs;
using ReportingProcesses.Abstract;
using ReportingProcesses.Concrete;
using System.Text.Json;


namespace WinFormsUI
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        public int UserId { get; set; }
        int reportType;
        TravelManager travelManager = new TravelManager(new EfTravelDal());

        public void ReportTypeEnabled()
        {
            lbl_ReportType1.Visible = true;
            lbl_ReportType2.Visible = true;
            lbl_ReportType3.Visible = true;
            lbl_ReportType4.Visible = true;
        }

        private void btn_CreateReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            

            
            PriceDetails priceDetails = new PriceDetails()
            {
                AccommodationToolPrice = travelManager.PriceDetailsByUserId(UserId).Data.AccommodationToolPrice,
                TransportVehiclePrice = travelManager.PriceDetailsByUserId(UserId).Data.TransportVehiclePrice,
                TravelPrice = travelManager.PriceDetailsByUserId(UserId).Data.TravelPrice
            };
            TravelDetails travelDetails = new TravelDetails()
            {
                DateOfReturn = travelManager.TravelDetailsByUserId(UserId).Data.DateOfReturn,
                DepartureDate = travelManager.TravelDetailsByUserId(UserId).Data.DepartureDate,
                LastName = travelManager.TravelDetailsByUserId(UserId).Data.LastName,
                Location = travelManager.TravelDetailsByUserId(UserId).Data.Location,
                Name=travelManager.TravelDetailsByUserId(UserId).Data.Name,
                Address=travelManager.TravelDetailsByUserId(UserId).Data.Address
            };
            TravelVehicleDetails travelVehicleDetails = new TravelVehicleDetails()
            {
                AccommodationToolDetails = travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolDetails,
                AccommodationToolName= travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolName,
                AccommodationToolTypeName=travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolTypeName,
                TransportVehicleDetails=travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleDetails,
                TransportVehicleName=travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleName,
                TransportVehicleTypeName=travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleTypeName
            };


            report.priceDetails = priceDetails;
            report.travelDetails = travelDetails;
            report.travelVehicleDetails = travelVehicleDetails;
           
                       
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML |*.html| XML |*.xml| JSON |*.json";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    if (saveFileDialog1.FilterIndex == 1)
                    {
                        IReportBuilder htmlRaporBuilder = new HtmlReportBuilder(report);
                        ReportManager reportManager = new ReportManager(htmlRaporBuilder);
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName.ToString());

                        string str = BuildReport(reportManager, reportType);
                        streamWriter.Write(str);
                        streamWriter.Close();
                        ReportTypeEnabled();
                    }
                    else if (saveFileDialog1.FilterIndex == 2)
                    {
                        IReportBuilder xmlReportBuilder = new XmlReportBuilder(report);
                        ReportManager reportManager = new ReportManager(xmlReportBuilder);
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName.ToString());
                        string str = "<?xml version = \"1.0\" encoding = \"utf-8\" standalone =\"no\"?><body>";
                        str += BuildReport(reportManager, reportType);
                        str+="</body>";
                        streamWriter.Write(str);
                        streamWriter.Close();
                        ReportTypeEnabled();
                    }
                    else 
                    {
                        IReportBuilder jsonReportBuilder = new JsonReportBuilder(report);
                        ReportManager reportManager = new ReportManager(jsonReportBuilder);
                        StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName.ToString());
                        string str = "{";
                        str += BuildReport(reportManager, reportType);
                        str = str.Remove(str.Length - 1, 1) + "}";
                        JsonSerializer.Serialize(str);
                        streamWriter.Write(str);
                        streamWriter.Close();
                        ReportTypeEnabled();
                    }               
            }
        }

        private void lbl_ReportType_Click(object sender, EventArgs e)
        {
            reportType = 1;
            lbl_ReportType2.Visible = false;
            lbl_ReportType3.Visible = false;
            lbl_ReportType4.Visible = false;
            btn_CreateReport.Enabled = true;
        }

        private void lbl_ReportType2_Click(object sender, EventArgs e)
        {
            reportType = 2;
            lbl_ReportType1.Visible = false;
            lbl_ReportType3.Visible = false;
            lbl_ReportType4.Visible = false;
            btn_CreateReport.Enabled = true;
        }

        private void lbl_ReportType3_Click(object sender, EventArgs e)
        {
            reportType = 3;
            lbl_ReportType2.Visible = false;
            lbl_ReportType1.Visible = false;
            lbl_ReportType4.Visible = false;
            btn_CreateReport.Enabled = true;
        }

        private void lbl_ReportType4_Click(object sender, EventArgs e)
        {
            reportType = 4;
            lbl_ReportType2.Visible = false;
            lbl_ReportType3.Visible = false;
            lbl_ReportType1.Visible = false;
            btn_CreateReport.Enabled = true;
        }
        private string BuildReport(ReportManager reportManager,int reportType)
        {
            if (reportType==1)
            {
                return reportManager.Build();
            }
            else if (reportType==2)
            {
                return reportManager.Build2();

            }
            else if (reportType == 3)
            {
                return reportManager.Build3();
            }
            else if (reportType == 4)
            {
                return reportManager.Build4();
            }
            else
            {
                return null;
            }

        }

        private void btn_CreateReport_MouseHover(object sender, EventArgs e)
        {
            btn_CreateReport.ForeColor = Color.MediumPurple;
        }

        private void btn_CreateReport_MouseLeave(object sender, EventArgs e)
        {
            btn_CreateReport.ForeColor = Color.Black;
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmProcess frmProcess = new frmProcess() { UserId = this.UserId };
            frmProcess.Show();
            this.Hide();
        }

        private void lbl_ReportType1_MouseHover(object sender, EventArgs e)
        {
            lbl_ReportType1.ForeColor = Color.Crimson;
        }

        private void lbl_ReportType1_MouseLeave(object sender, EventArgs e)
        {
            lbl_ReportType1.ForeColor = Color.Black;

        }

        private void lbl_ReportType2_MouseHover(object sender, EventArgs e)
        {
            lbl_ReportType2.ForeColor = Color.Crimson;
        }

        private void lbl_ReportType2_MouseLeave(object sender, EventArgs e)
        {
            lbl_ReportType2.ForeColor = Color.Black;
        }

        private void lbl_ReportType3_MouseHover(object sender, EventArgs e)
        {
            lbl_ReportType3.ForeColor = Color.Crimson;
        }

        private void lbl_ReportType3_MouseLeave(object sender, EventArgs e)
        {
            lbl_ReportType3.ForeColor = Color.Black;
        }

        private void lbl_ReportType4_MouseHover(object sender, EventArgs e)
        {
            lbl_ReportType4.ForeColor = Color.Crimson;
        }

        private void lbl_ReportType4_MouseLeave(object sender, EventArgs e)
        {
            lbl_ReportType4.ForeColor = Color.Black;
        }
    }
}
