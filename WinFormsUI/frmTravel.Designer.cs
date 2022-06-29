
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTravel));
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
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccommodationTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_TransportVehicles
            // 
            this.dgv_TransportVehicles.AllowUserToAddRows = false;
            this.dgv_TransportVehicles.AllowUserToDeleteRows = false;
            this.dgv_TransportVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TransportVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TransportVehicles.Location = new System.Drawing.Point(33, 42);
            this.dgv_TransportVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_TransportVehicles.Name = "dgv_TransportVehicles";
            this.dgv_TransportVehicles.ReadOnly = true;
            this.dgv_TransportVehicles.RowHeadersWidth = 51;
            this.dgv_TransportVehicles.RowTemplate.Height = 29;
            this.dgv_TransportVehicles.Size = new System.Drawing.Size(772, 131);
            this.dgv_TransportVehicles.TabIndex = 7;
            this.dgv_TransportVehicles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TransportVehicles_CellClick);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.Transparent;
            this.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show.FlatAppearance.BorderSize = 2;
            this.btn_Show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(360, 493);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(136, 37);
            this.btn_Show.TabIndex = 6;
            this.btn_Show.Text = "Listele";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Visible = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            this.btn_Show.MouseLeave += new System.EventHandler(this.btn_Show_MouseLeave);
            this.btn_Show.MouseHover += new System.EventHandler(this.btn_Show_MouseHover);
            // 
            // cmb_Transportation
            // 
            this.cmb_Transportation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmb_Transportation.FormattingEnabled = true;
            this.cmb_Transportation.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cmb_Transportation.Location = new System.Drawing.Point(277, 356);
            this.cmb_Transportation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Transportation.Name = "cmb_Transportation";
            this.cmb_Transportation.Size = new System.Drawing.Size(219, 23);
            this.cmb_Transportation.TabIndex = 5;
            this.cmb_Transportation.Visible = false;
            // 
            // cmb_Accomodation
            // 
            this.cmb_Accomodation.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmb_Accomodation.FormattingEnabled = true;
            this.cmb_Accomodation.Items.AddRange(new object[] {
            "Otel",
            "Çadır"});
            this.cmb_Accomodation.Location = new System.Drawing.Point(277, 383);
            this.cmb_Accomodation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Accomodation.Name = "cmb_Accomodation";
            this.cmb_Accomodation.Size = new System.Drawing.Size(219, 23);
            this.cmb_Accomodation.TabIndex = 4;
            this.cmb_Accomodation.Visible = false;
            // 
            // btn_CreateTravel
            // 
            this.btn_CreateTravel.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateTravel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateTravel.FlatAppearance.BorderSize = 2;
            this.btn_CreateTravel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateTravel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateTravel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTravel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_CreateTravel.Location = new System.Drawing.Point(669, 332);
            this.btn_CreateTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateTravel.Name = "btn_CreateTravel";
            this.btn_CreateTravel.Size = new System.Drawing.Size(136, 37);
            this.btn_CreateTravel.TabIndex = 10;
            this.btn_CreateTravel.Text = "Seyhat Oluştur";
            this.btn_CreateTravel.UseVisualStyleBackColor = false;
            this.btn_CreateTravel.Visible = false;
            this.btn_CreateTravel.Click += new System.EventHandler(this.btn_CreateTravel_Click);
            this.btn_CreateTravel.MouseLeave += new System.EventHandler(this.btn_CreateTravel_MouseLeave);
            this.btn_CreateTravel.MouseHover += new System.EventHandler(this.btn_CreateTravel_MouseHover);
            // 
            // dtp_DepartureDate
            // 
            this.dtp_DepartureDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtp_DepartureDate.Location = new System.Drawing.Point(277, 437);
            this.dtp_DepartureDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DepartureDate.Name = "dtp_DepartureDate";
            this.dtp_DepartureDate.Size = new System.Drawing.Size(219, 24);
            this.dtp_DepartureDate.TabIndex = 11;
            this.dtp_DepartureDate.Value = new System.DateTime(2022, 6, 29, 15, 32, 0, 0);
            this.dtp_DepartureDate.Visible = false;
            // 
            // dtp_DateOfReturn
            // 
            this.dtp_DateOfReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dtp_DateOfReturn.Location = new System.Drawing.Point(277, 465);
            this.dtp_DateOfReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_DateOfReturn.Name = "dtp_DateOfReturn";
            this.dtp_DateOfReturn.Size = new System.Drawing.Size(219, 24);
            this.dtp_DateOfReturn.TabIndex = 12;
            this.dtp_DateOfReturn.Value = new System.DateTime(2022, 6, 29, 15, 32, 8, 0);
            this.dtp_DateOfReturn.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 2;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Delete.Location = new System.Drawing.Point(700, 385);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(105, 37);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Seyhati Sil";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_Delete_MouseLeave);
            this.btn_Delete.MouseHover += new System.EventHandler(this.btn_Delete_MouseHover);
            // 
            // dgv_AccommodationTools
            // 
            this.dgv_AccommodationTools.AllowUserToAddRows = false;
            this.dgv_AccommodationTools.AllowUserToDeleteRows = false;
            this.dgv_AccommodationTools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AccommodationTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccommodationTools.Location = new System.Drawing.Point(33, 177);
            this.dgv_AccommodationTools.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_AccommodationTools.Name = "dgv_AccommodationTools";
            this.dgv_AccommodationTools.ReadOnly = true;
            this.dgv_AccommodationTools.RowHeadersWidth = 51;
            this.dgv_AccommodationTools.RowTemplate.Height = 29;
            this.dgv_AccommodationTools.Size = new System.Drawing.Size(772, 131);
            this.dgv_AccommodationTools.TabIndex = 14;
            this.dgv_AccommodationTools.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AccommodationTools_CellClick);
            // 
            // cmb_Location
            // 
            this.cmb_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cmb_Location.FormattingEnabled = true;
            this.cmb_Location.Items.AddRange(new object[] {
            "İstanbul",
            "İzmir",
            "Ankara",
            "Antalya"});
            this.cmb_Location.Location = new System.Drawing.Point(277, 410);
            this.cmb_Location.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Location.Name = "cmb_Location";
            this.cmb_Location.Size = new System.Drawing.Size(219, 23);
            this.cmb_Location.TabIndex = 15;
            this.cmb_Location.Visible = false;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Location.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Location.Location = new System.Drawing.Point(146, 413);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(125, 15);
            this.lbl_Location.TabIndex = 16;
            this.lbl_Location.Text = "Gitmek istediğiniz yer:";
            this.lbl_Location.Visible = false;
            // 
            // lbl_DepartureDate
            // 
            this.lbl_DepartureDate.AutoSize = true;
            this.lbl_DepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DepartureDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DepartureDate.Location = new System.Drawing.Point(137, 444);
            this.lbl_DepartureDate.Name = "lbl_DepartureDate";
            this.lbl_DepartureDate.Size = new System.Drawing.Size(134, 15);
            this.lbl_DepartureDate.TabIndex = 17;
            this.lbl_DepartureDate.Text = "Gitmek istediğiniz tarih:";
            this.lbl_DepartureDate.Visible = false;
            // 
            // lbl_DateOfReturn
            // 
            this.lbl_DateOfReturn.AutoSize = true;
            this.lbl_DateOfReturn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DateOfReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_DateOfReturn.Location = new System.Drawing.Point(129, 472);
            this.lbl_DateOfReturn.Name = "lbl_DateOfReturn";
            this.lbl_DateOfReturn.Size = new System.Drawing.Size(142, 15);
            this.lbl_DateOfReturn.TabIndex = 18;
            this.lbl_DateOfReturn.Text = "Dönmek istediğiniz tarih:";
            this.lbl_DateOfReturn.Visible = false;
            // 
            // lbl_TransportVehicles
            // 
            this.lbl_TransportVehicles.AutoSize = true;
            this.lbl_TransportVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TransportVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_TransportVehicles.Location = new System.Drawing.Point(31, 359);
            this.lbl_TransportVehicles.Name = "lbl_TransportVehicles";
            this.lbl_TransportVehicles.Size = new System.Drawing.Size(240, 15);
            this.lbl_TransportVehicles.TabIndex = 19;
            this.lbl_TransportVehicles.Text = "Kullanmak İstediğiniz Ulaşım Aracını Seçin: ";
            this.lbl_TransportVehicles.Visible = false;
            // 
            // lbl_AccommodationTools
            // 
            this.lbl_AccommodationTools.AutoSize = true;
            this.lbl_AccommodationTools.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AccommodationTools.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_AccommodationTools.Location = new System.Drawing.Point(5, 386);
            this.lbl_AccommodationTools.Name = "lbl_AccommodationTools";
            this.lbl_AccommodationTools.Size = new System.Drawing.Size(266, 15);
            this.lbl_AccommodationTools.TabIndex = 20;
            this.lbl_AccommodationTools.Text = "Kullanmak İstediğiniz Konaklama Aracını Seçin: ";
            this.lbl_AccommodationTools.Visible = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Info.Location = new System.Drawing.Point(33, 321);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(37, 15);
            this.lbl_Info.TabIndex = 21;
            this.lbl_Info.Text = "..........";
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(779, 9);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(26, 18);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 22;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Back.Image")));
            this.pcr_Back.Location = new System.Drawing.Point(12, 9);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(26, 18);
            this.pcr_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Back.TabIndex = 23;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // frmTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 559);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTravel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel";
            this.Load += new System.EventHandler(this.frmTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TransportVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccommodationTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
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
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.PictureBox pcr_Back;
    }
}

