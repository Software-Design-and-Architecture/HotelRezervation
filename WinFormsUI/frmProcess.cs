using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class frmProcess : Form
    {
        public int UserId { get; set; }
        public frmProcess()
        {
            InitializeComponent();
        }
        TravelManager travelManager = new TravelManager(new EfTravelDal());
        private void btn_CreateTravel_Click(object sender, EventArgs e)
        {


        }

        private void btn_CreateReport_Click(object sender, EventArgs e)
        {
            if (travelManager.GetByUserId(UserId).Success != false)
            {
                frmReport frmReport = new frmReport() { UserId = this.UserId };
                frmReport.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Önce Bir Seyhat Oluşturun");
            }
            

        }
    }
}
