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
            frmTravel frmTravel = new frmTravel() { UserId = this.UserId };
            frmTravel.Show();
            this.Hide();

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

        private void btn_CreateReport_MouseHover(object sender, EventArgs e)
        {
            btn_CreateReport.ForeColor = Color.Salmon;
        }

        private void btn_CreateReport_MouseLeave(object sender, EventArgs e)
        {
            btn_CreateReport.ForeColor = Color.Black;
        }

        private void btn_CreateTravel_MouseHover(object sender, EventArgs e)
        {
            btn_CreateTravel.ForeColor = Color.DarkTurquoise;
        }

        private void btn_CreateTravel_MouseLeave(object sender, EventArgs e)
        {
            btn_CreateTravel.ForeColor = Color.Black;
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
