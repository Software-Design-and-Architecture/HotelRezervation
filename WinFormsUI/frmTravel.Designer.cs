
namespace WinFormsUI
{
    partial class frmTravel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_TransportVehicles = new System.Windows.Forms.DataGridView();
            this.btn_Show = new System.Windows.Forms.Button();
            this.cmb_Transportation = new System.Windows.Forms.ComboBox();
            this.cmb_Accomodation = new System.Windows.Forms.ComboBox();
            this.btn_CreateTravel = new System.Windows.Forms.Button();
            this.dtp_DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateOfReturn = new System.Windows.Forms.DateTimePicker();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_AccommodationTools = new System.Windows.Forms.DataGridView();
            this.cmb_Location = new System.Windows.Forms.ComboBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_DepartureDate = new System.Windows.Forms.Label();
            this.lbl_DateOfReturn = new System.Windows.Forms.Label();
            this.lbl_TransportVehicles = new System.Windows.Forms.Label();
            this.lbl_AccommodationTools = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccommodationTools)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TransportVehicles
            // 
            this.dgv_TransportVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransportVehicles.Location = new System.Drawing.Point(47, 12);
            this.dgv_TransportVehicles.Name = "dgv_TransportVehicles";
            this.dgv_TransportVehicles.RowHeadersWidth = 51;
            this.dgv_TransportVehicles.RowTemplate.Height = 29;
            this.dgv_TransportVehicles.Size = new System.Drawing.Size(747, 175);
            this.dgv_TransportVehicles.TabIndex = 7;
            this.dgv_TransportVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransportVehicles_CellClick);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(344, 645);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(155, 49);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = "Listele";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Visible = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // cmb_Transportation
            // 
            this.cmb_Transportation.FormattingEnabled = true;
            this.cmb_Transportation.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cmb_Transportation.Location = new System.Drawing.Point(348, 431);
            this.cmb_Transportation.Name = "cmb_Transportation";
            this.cmb_Transportation.Size = new System.Drawing.Size(151, 28);
            this.cmb_Transportation.TabIndex = 5;
            this.cmb_Transportation.Visible = false;
            // 
            // cmb_Accomodation
            // 
            this.cmb_Accomodation.FormattingEnabled = true;
            this.cmb_Accomodation.Items.AddRange(new object[] {
            "Otel",
            "Çadır"});
            this.cmb_Accomodation.Location = new System.Drawing.Point(348, 470);
            this.cmb_Accomodation.Name = "cmb_Accomodation";
            this.cmb_Accomodation.Size = new System.Drawing.Size(151, 28);
            this.cmb_Accomodation.TabIndex = 4;
            this.cmb_Accomodation.Visible = false;
            // 
            // btn_CreateTravel
            // 
            this.btn_CreateTravel.Location = new System.Drawing.Point(627, 431);
            this.btn_CreateTravel.Name = "btn_CreateTravel";
            this.btn_CreateTravel.Size = new System.Drawing.Size(155, 49);
            this.btn_CreateTravel.TabIndex = 10;
            this.btn_CreateTravel.Text = "Seyhat Oluştur";
            this.btn_CreateTravel.UseVisualStyleBackColor = true;
            this.btn_CreateTravel.Visible = false;
            this.btn_CreateTravel.Click += new System.EventHandler(this.btn_CreateTravel_Click);
            // 
            // dtp_DepartureDate
            // 
            this.dtp_DepartureDate.Location = new System.Drawing.Point(249, 554);
            this.dtp_DepartureDate.Name = "dtp_DepartureDate";
            this.dtp_DepartureDate.Size = new System.Drawing.Size(250, 27);
            this.dtp_DepartureDate.TabIndex = 11;
            this.dtp_DepartureDate.Visible = false;
            // 
            // dtp_DateOfReturn
            // 
            this.dtp_DateOfReturn.Location = new System.Drawing.Point(249, 602);
            this.dtp_DateOfReturn.Name = "dtp_DateOfReturn";
            this.dtp_DateOfReturn.Size = new System.Drawing.Size(250, 27);
            this.dtp_DateOfReturn.TabIndex = 12;
            this.dtp_DateOfReturn.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(637, 514);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(103, 49);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Seyhati Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_AccommodationTools
            // 
            this.dgv_AccommodationTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccommodationTools.Location = new System.Drawing.Point(47, 210);
            this.dgv_AccommodationTools.Name = "dgv_AccommodationTools";
            this.dgv_AccommodationTools.RowHeadersWidth = 51;
            this.dgv_AccommodationTools.RowTemplate.Height = 29;
            this.dgv_AccommodationTools.Size = new System.Drawing.Size(747, 175);
            this.dgv_AccommodationTools.TabIndex = 14;
            this.dgv_AccommodationTools.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AccommodationTools_CellClick);
            // 
            // cmb_Location
            // 
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Items.AddRange(new object[] {
            "İstanbul",
            "İzmir",
            "Ankara",
            "Antalya"});
            this.cmb_Location.Location = new System.Drawing.Point(249, 514);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(250, 28);
            this.cmb_Location.TabIndex = 15;
            this.cmb_Location.Visible = false;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(83, 517);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(155, 20);
            this.lbl_Location.TabIndex = 16;
            this.lbl_Location.Text = "Gitmek istediğiniz yer:";
            this.lbl_Location.Visible = false;
            // 
            // lbl_DepartureDate
            // 
            this.lbl_DepartureDate.AutoSize = true;
            this.lbl_DepartureDate.Location = new System.Drawing.Point(73, 561);
            this.lbl_DepartureDate.Name = "lbl_DepartureDate";
            this.lbl_DepartureDate.Size = new System.Drawing.Size(165, 20);
            this.lbl_DepartureDate.TabIndex = 17;
            this.lbl_DepartureDate.Text = "Gitmek istediğiniz tarih:";
            this.lbl_DepartureDate.Visible = false;
            // 
            // lbl_DateOfReturn
            // 
            this.lbl_DateOfReturn.AutoSize = true;
            this.lbl_DateOfReturn.Location = new System.Drawing.Point(64, 607);
            this.lbl_DateOfReturn.Name = "lbl_DateOfReturn";
            this.lbl_DateOfReturn.Size = new System.Drawing.Size(174, 20);
            this.lbl_DateOfReturn.TabIndex = 18;
            this.lbl_DateOfReturn.Text = "Dönmek istediğiniz tarih:";
            this.lbl_DateOfReturn.Visible = false;
            // 
            // lbl_TransportVehicles
            // 
            this.lbl_TransportVehicles.AutoSize = true;
            this.lbl_TransportVehicles.Location = new System.Drawing.Point(47, 434);
            this.lbl_TransportVehicles.Name = "lbl_TransportVehicles";
            this.lbl_TransportVehicles.Size = new System.Drawing.Size(295, 20);
            this.lbl_TransportVehicles.TabIndex = 19;
            this.lbl_TransportVehicles.Text = "Kullanmak İstediğiniz Ulaşım Aracını Seçin: ";
            this.lbl_TransportVehicles.Visible = false;
            // 
            // lbl_AccommodationTools
            // 
            this.lbl_AccommodationTools.AutoSize = true;
            this.lbl_AccommodationTools.Location = new System.Drawing.Point(18, 473);
            this.lbl_AccommodationTools.Name = "lbl_AccommodationTools";
            this.lbl_AccommodationTools.Size = new System.Drawing.Size(324, 20);
            this.lbl_AccommodationTools.TabIndex = 20;
            this.lbl_AccommodationTools.Text = "Kullanmak İstediğiniz Konaklama Aracını Seçin: ";
            this.lbl_AccommodationTools.Visible = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(73, 399);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(0, 20);
            this.lbl_Info.TabIndex = 21;
            // 
            // frmTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 710);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.lbl_AccommodationTools);
            this.Controls.Add(this.lbl_TransportVehicles);
            this.Controls.Add(this.lbl_DateOfReturn);
            this.Controls.Add(this.lbl_DepartureDate);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.cmb_Location);
            this.Controls.Add(this.dgv_AccommodationTools);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dtp_DateOfReturn);
            this.Controls.Add(this.dtp_DepartureDate);
            this.Controls.Add(this.btn_CreateTravel);
            this.Controls.Add(this.dgv_TransportVehicles);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.cmb_Transportation);
            this.Controls.Add(this.cmb_Accomodation);
            this.Name = "frmTravel";
            this.Text = "Travel";
            this.Load += new System.EventHandler(this.frmTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccommodationTools)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_TransportVehicles;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox cmb_Transportation;
        private System.Windows.Forms.ComboBox cmb_Accomodation;
        private System.Windows.Forms.Button btn_CreateTravel;
        private System.Windows.Forms.DateTimePicker dtp_DepartureDate;
        private System.Windows.Forms.DateTimePicker dtp_DateOfReturn;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_AccommodationTools;
        private System.Windows.Forms.ComboBox cmb_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_DateOfReturn;
        private System.Windows.Forms.Label lbl_DepartureDate;
        private System.Windows.Forms.Label lbl_TransportVehicles;
        private System.Windows.Forms.Label lbl_AccommodationTools;
        private System.Windows.Forms.Label lbl_Info;
    }
}

