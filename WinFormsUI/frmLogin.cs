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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            
            foreach (var item in userManager.GetAll().Data)
            {
                if (txt_UserName.Text ==item.UserName && txt_Password.Text==item.Password)
                {
                    frmProcess frmProcess = new frmProcess() { UserId = item.Id };
                    frmProcess.Show();
                    this.Hide();
                }
  
            }
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun");
            }

        }

        private void llbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
