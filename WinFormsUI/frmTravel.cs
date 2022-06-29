using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlanning.Concrete;

namespace WinFormsUI
{
    public partial class frmTravel : Form
    {
        public frmTravel()
        {
            InitializeComponent();
        }

        TravelManager travelManager = new TravelManager(new EfTravelDal());
        UserManager userManager = new UserManager(new EfUserDal());
        List<int> transportVehiclesId = new List<int>();
        List<int> accommodationToolsId = new List<int>();
        int selectedAccommodationTools = -1;
        int selectedTransportVehicles = -1;

        public int UserId { get; set; }


        private void frmTravel_Load(object sender, EventArgs e)
        {
            if (travelManager.GetByUserId(UserId).Success != false)
            {
                dgv_TransportVehicles.Columns.Add("CompanyName", "Şirket Adı");
                dgv_TransportVehicles.Columns.Add("TypeName", "Ulaşım Aracı Tipi");
                dgv_TransportVehicles.Columns.Add("StartingPoint", "Kalkış Noktası");
                dgv_TransportVehicles.Columns.Add("Destination", "Varış Noktası");
                dgv_TransportVehicles.Columns.Add("Price", "Fiyat");
                dgv_TransportVehicles.Columns.Add("TransportVehiclesDetails", "Detaylar");
                dgv_AccommodationTools.Columns.Add("CompanyName", "Şirket Adı");
                dgv_AccommodationTools.Columns.Add("TypeName", "Konaklama Aracı Tipi");
                dgv_AccommodationTools.Columns.Add("Location", "Konum");
                dgv_AccommodationTools.Columns.Add("Price", "Fiyat");
                dgv_AccommodationTools.Columns.Add("AccommodationToolsDetails", "Detaylar");
                dgv_TransportVehicles.Rows.Add(travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleName, travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleTypeName,
                    userManager.GetById(UserId).Data.Address, travelManager.GetByUserId(UserId).Data.Location, travelManager.PriceDetailsByUserId(UserId).Data.TransportVehiclePrice,
                    travelManager.TravelVehicleDetailsByUserId(UserId).Data.TransportVehicleDetails);
                dgv_AccommodationTools.Rows.Add(travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolName, travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolTypeName,
                    travelManager.TravelDetailsByUserId(UserId).Data.Location, travelManager.PriceDetailsByUserId(UserId).Data.AccommodationToolPrice, travelManager.TravelVehicleDetailsByUserId(UserId).Data.AccommodationToolDetails);
                lbl_Info.Text = "Oluşturduğunuz Seyhat Listelenmektedir. İptal Edebilir, Yenisini Oluşturabilirsiniz. ";
            }
            else
            {
                DisgnTrue();
            }

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_CreateTravel.Visible = true;
            btn_CreateTravel.Enabled = true;
            if (Validation())
            {
                if (cmb_Accomodation.Text == "Otel" && cmb_Transportation.Text == "Uçak")
                {

                    TravelBuilder hotelPlane = new TravelBuilder(new HotelPlaneFactory());
                    GetTransportVehicles(hotelPlane, userManager, UserId);
                    GetAccommodationTools(hotelPlane);
                }
                else if (cmb_Accomodation.Text == "Çadır" && cmb_Transportation.Text == "Uçak")
                {

                    TravelBuilder tentPlane = new TravelBuilder(new TentPlaneFactory());
                    GetTransportVehicles(tentPlane, userManager, UserId);
                    GetAccommodationTools(tentPlane);
                }
                else if (cmb_Accomodation.Text == "Otel" && cmb_Transportation.Text == "Otobüs")
                {

                    TravelBuilder hotelBus = new TravelBuilder(new HotelBusFactory());
                    GetTransportVehicles(hotelBus, userManager, UserId);
                    GetAccommodationTools(hotelBus);
                }
                else if (cmb_Accomodation.Text == "Çadır" && cmb_Transportation.Text == "Otobüs")
                {

                    TravelBuilder tentBus = new TravelBuilder(new TentBusFactory());
                    GetTransportVehicles(tentBus, userManager, UserId);
                    GetAccommodationTools(tentBus);
                }
            }
        }
        private void GetTransportVehicles(TravelBuilder travelBuilder, UserManager userManager, int userId)
        {
            dgv_TransportVehicles.Columns.Add("CompanyName", "Şirket Adı");
            dgv_TransportVehicles.Columns.Add("StartingPoint", "Kalkış Noktası");
            dgv_TransportVehicles.Columns.Add("Destination", "Varış Noktası");
            dgv_TransportVehicles.Columns.Add("Price", "Fiyat");
            dgv_TransportVehicles.Columns.Add("TransportVehiclesDetails", "Detaylar");
            foreach (var item in travelBuilder.GetAllTransportVehicles())
            {
                if (userManager.GetById(userId).Data.Address == item.StartingPoint && cmb_Location.Text == item.Destination)
                {
                    dgv_TransportVehicles.Rows.Add(item.CompanyName, item.StartingPoint, item.Destination, item.Price, item.TransportVehiclesDetails);
                    transportVehiclesId.Add(item.Id);
                }
            }
            if (dgv_TransportVehicles.Rows.Count <= 1)
            {
                MessageBox.Show("Herhangi Bir Ulaşım Aracı Yok Seyhat Oluşturma Ayarlarını Değiştirin");
                frmProcess frmProcess = new frmProcess()
                {
                    UserId = UserId
                };
                frmProcess.Show();
                this.Hide();
            }

        }
        private void GetAccommodationTools(TravelBuilder travelBuilder)
        {

            dgv_AccommodationTools.Columns.Add("CompanyName", "Şirket Adı");
            dgv_AccommodationTools.Columns.Add("Location", "Konum");
            dgv_AccommodationTools.Columns.Add("Price", "Fiyat");
            dgv_AccommodationTools.Columns.Add("AccommodationToolsDetails", "Detaylar");

            foreach (var item in travelBuilder.GetAllAccommodationTools())
            {
                if (cmb_Location.Text == item.Location)
                {
                    dgv_AccommodationTools.Rows.Add(item.CompanyName, item.Location, item.Price, item.AccommodationToolsDetails);
                    accommodationToolsId.Add(item.Id);
                }

            }
            if (dgv_TransportVehicles.Rows.Count > 1 && dgv_AccommodationTools.Rows.Count <= 1)
            {
                MessageBox.Show("Herhangi Bir Konaklma Aracı Yok Seyhat Oluşturma Ayarlarını Değiştirin");
                frmProcess frmProcess = new frmProcess()
                {
                    UserId = UserId
                };
                frmProcess.Show();
                this.Hide();
            }
        }
        private bool Validation()
        {
            if (cmb_Location.Text == "") {
                
                MessageBox.Show("Lütfen Gideceğiniz Yeri Seçin.");
                return false;
            }
                
            TimeSpan result;
            result = dtp_DateOfReturn.Value - dtp_DepartureDate.Value;
            if (result.TotalDays < 0)
            {
                MessageBox.Show("Gidiş Tarihiniz Dönüş Tarihinizden Küçük Olamaz.");
                return false;
            }
                
            if (cmb_Transportation.Text == "")
            {
                MessageBox.Show("Lütfen Bir Ulaşım Aracı Seçin");
                return false;
            }
               
            if (cmb_Accomodation.Text == "")
            {
                MessageBox.Show("Lütfen Bir Konaklama Aracı Seçin");
                return false;
            }
                return true;
        }
        private void btn_CreateTravel_Click(object sender, EventArgs e)
        {
            if (dgv_TransportVehicles.RowCount == 0)
            {
                MessageBox.Show("Konumunuzdan Gitmek istediğiniz Konuma Giden Hiçbir Ulaşım Aracı Yok.");
            }
            if (selectedAccommodationTools >= 0 && selectedTransportVehicles >= 0)
            {
                AccommodationToolManager accommodationToolManager = new AccommodationToolManager(new EfAccommodationToolDal());
                TransportVehicleManager transportVehicleManager = new TransportVehicleManager(new EfTransportVehicleDal());
                TimeSpan result;
                result = dtp_DateOfReturn.Value - dtp_DepartureDate.Value;
                travelManager.Add(new Travel
                {
                    AccommodationToolsId = accommodationToolsId[selectedAccommodationTools],
                    TransportVehiclesId = transportVehiclesId[selectedTransportVehicles],
                    DepartureDate = dtp_DepartureDate.Value,
                    DateOfReturn = dtp_DateOfReturn.Value,
                    Location = cmb_Location.Text,
                    UserId = UserId,
                    Price = (accommodationToolManager.GetById(accommodationToolsId[selectedAccommodationTools]).Data.Price * (int)result.TotalDays) +
                    (transportVehicleManager.GetById(transportVehiclesId[selectedTransportVehicles]).Data.Price * 2)
                });
                btn_CreateTravel.Enabled = false;
                MessageBox.Show("Seyhatiniz Oluşturuldu");               
                dgv_TransportVehicles.Columns.Clear();
                dgv_AccommodationTools.Columns.Clear();
                DisgnFalse();
                frmTravel_Load(sender, e);
            }
            else
            {
                if (selectedAccommodationTools < 0)
                    MessageBox.Show("Lütfen Bir Konaklama Aracı Seçin");
                if (selectedTransportVehicles < 0)
                    MessageBox.Show("Lütfen Bir Ulaşım Aracı Seçin");
            }
            
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (travelManager.GetByUserId(UserId).Success == true)
            {
                DialogResult selected = new DialogResult();
                if (selectedTransportVehicles >= 0 )
                {
                    selected = MessageBox.Show("Ulaşım aracını silmek üzeresiniz silerseniz buna bağlı konaklama aracınızda silinecektir. Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (selected == DialogResult.Yes)
                    {                      
                        travelManager.Delete(travelManager.GetByUserId(UserId).Data);
                        frmTravel_Load(sender, e);
                        dgv_AccommodationTools.Columns.Clear();
                        dgv_TransportVehicles.Columns.Clear();
                        DisgnTrue();
                    }

                }
                else if (selectedAccommodationTools >= 0)
                {
                    selected = MessageBox.Show("Konaklama aracını silmek üzeresiniz silerseniz buna bağlı ulaşım aracınızda silinecektir. Onaylıyor musunuz?", "ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (selected == DialogResult.Yes)
                    {
                        travelManager.Delete(travelManager.GetByUserId(UserId).Data);
                        frmTravel_Load(sender, e);
                        dgv_AccommodationTools.Columns.Clear();
                        dgv_TransportVehicles.Columns.Clear();
                        DisgnTrue();
                    }

                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz bir şey seçin.");
                }
            }
            else
            {
                MessageBox.Show("Hiçbir tatiliniz yok");
            }
        }
        private void DisgnTrue()
        {
            lbl_DateOfReturn.Visible = true;
            lbl_DateOfReturn.Visible = true;
            lbl_Location.Visible = true;
            lbl_DateOfReturn.Visible = true;
            dtp_DateOfReturn.Visible = true;
            dtp_DepartureDate.Visible = true;
            cmb_Location.Visible = true;
            btn_Show.Visible = true;
            lbl_TransportVehicles.Visible = true;
            lbl_AccommodationTools.Visible = true;
            cmb_Accomodation.Visible = true;
            cmb_Transportation.Visible = true;
            btn_Delete.Visible = false;
            lbl_Info.Text = "Seyhat Oluşturmak İçin Gerekli Alanları Doldurun.";
        }
        private void DisgnFalse()
        {
            lbl_DateOfReturn.Visible = false;
            lbl_DateOfReturn.Visible = false;
            lbl_Location.Visible = false;
            dtp_DateOfReturn.Visible = false;
            dtp_DepartureDate.Visible = false;
            cmb_Location.Visible = false;
            btn_Show.Visible = false;
            lbl_TransportVehicles.Visible = false;
            lbl_AccommodationTools.Visible = false;
            cmb_Accomodation.Visible =  false;
            cmb_Transportation.Visible = false;
            btn_Delete.Visible = true;
            lbl_Info.Text = "Oluşturduğunuz Seyhat Listelenmektedir. İptal Edebilir, Yenisini Oluşturabilirsiniz. ";
        }
        private void dgv_TransportVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_TransportVehicles.RowCount > dgv_TransportVehicles.SelectedCells[0].RowIndex + 1)
            {
                selectedTransportVehicles = dgv_TransportVehicles.SelectedCells[0].RowIndex;
            }
        }
        private void dgv_AccommodationTools_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_AccommodationTools.RowCount > dgv_AccommodationTools.SelectedCells[0].RowIndex + 1)
            {
                selectedAccommodationTools = dgv_AccommodationTools.SelectedCells[0].RowIndex;
            }
        }

        private void btn_Show_MouseHover(object sender, EventArgs e)
        {
            btn_Show.ForeColor = Color.PowderBlue;
        }

        private void btn_Show_MouseLeave(object sender, EventArgs e)
        {
            btn_Show.ForeColor = Color.Black;
        }

        private void btn_Delete_MouseHover(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.Red;
        }

        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.Black;
        }

        private void btn_CreateTravel_MouseHover(object sender, EventArgs e)
        {
            btn_CreateTravel.ForeColor = Color.Green;
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
            //FrmProcess yüklenilidği zaman mevcut müşterinin ID'sinin
            //aktarılması gerekiyor açılan yeni FrmProcess sayfasına
            frmProcess frmProcess = new frmProcess() { UserId = this.UserId };
            frmProcess.Show();
            this.Hide();
        }
    }
}
