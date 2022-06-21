using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text=="" || txt_Password.Text=="")
            {
                MessageBox.Show("Lütfen gerekli alanları doldurun");
            }
            else
            {
                UserManager userManager = new UserManager(new EfUserDal());
                foreach (var item in userManager.GetAll().Data)
                {
                    if (item.UserName == txt_UserName.Text && item.Password == txt_Password.Text)
                    {
                        MessageBox.Show("Bu kullanıcı zaten var lütfen giriş yapın");
                        frmLogin frmLogin = new frmLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                }
                userManager.Add(new User
                {
                    UserName= txt_UserName.Text,
                    Address = txt_Address.Text,
                    LastName = txt_LastName.Text,
                    Name = txt_Name.Text,
                    Password = txt_Password.Text
                });
                frmLogin frmLogin2 = new frmLogin();
                frmLogin2.Show();
                this.Hide();

            }
        }
    }
}
