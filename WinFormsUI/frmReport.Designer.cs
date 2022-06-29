
namespace WinFormsUI
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.btn_CreateReport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_ReportType1 = new System.Windows.Forms.Label();
            this.lbl_ReportType2 = new System.Windows.Forms.Label();
            this.lbl_ReportType3 = new System.Windows.Forms.Label();
            this.lbl_ReportType4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CreateReport
            // 
            this.btn_CreateReport.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateReport.Enabled = false;
            this.btn_CreateReport.FlatAppearance.BorderSize = 2;
            this.btn_CreateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_CreateReport.ForeColor = System.Drawing.Color.Black;
            this.btn_CreateReport.Location = new System.Drawing.Point(54, 475);
            this.btn_CreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateReport.Name = "btn_CreateReport";
            this.btn_CreateReport.Size = new System.Drawing.Size(667, 73);
            this.btn_CreateReport.TabIndex = 0;
            this.btn_CreateReport.Text = "Rapor Oluştur";
            this.btn_CreateReport.UseVisualStyleBackColor = false;
            this.btn_CreateReport.Click += new System.EventHandler(this.btn_CreateReport_Click);
            this.btn_CreateReport.MouseLeave += new System.EventHandler(this.btn_CreateReport_MouseLeave);
            this.btn_CreateReport.MouseHover += new System.EventHandler(this.btn_CreateReport_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_ReportType1
            // 
            this.lbl_ReportType1.AutoSize = true;
            this.lbl_ReportType1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReportType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReportType1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ReportType1.ForeColor = System.Drawing.Color.Black;
            this.lbl_ReportType1.Location = new System.Drawing.Point(54, 78);
            this.lbl_ReportType1.Name = "lbl_ReportType1";
            this.lbl_ReportType1.Size = new System.Drawing.Size(667, 77);
            this.lbl_ReportType1.TabIndex = 2;
            this.lbl_ReportType1.Text = "· Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n" +
    "· Seyahat hakkında detaylı bilgileri\r\n· Rezervasyonun fiyatlarını";
            this.lbl_ReportType1.Click += new System.EventHandler(this.lbl_ReportType_Click);
            this.lbl_ReportType1.MouseLeave += new System.EventHandler(this.lbl_ReportType1_MouseLeave);
            this.lbl_ReportType1.MouseHover += new System.EventHandler(this.lbl_ReportType1_MouseHover);
            // 
            // lbl_ReportType2
            // 
            this.lbl_ReportType2.AutoSize = true;
            this.lbl_ReportType2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReportType2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReportType2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ReportType2.Location = new System.Drawing.Point(54, 180);
            this.lbl_ReportType2.Name = "lbl_ReportType2";
            this.lbl_ReportType2.Size = new System.Drawing.Size(667, 77);
            this.lbl_ReportType2.TabIndex = 3;
            this.lbl_ReportType2.Text = "· Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n" +
    "· Rezervasyonun fiyatlarını\r\n· Seyahat hakkında detaylı bilgileri\r\n";
            this.lbl_ReportType2.Click += new System.EventHandler(this.lbl_ReportType2_Click);
            this.lbl_ReportType2.MouseLeave += new System.EventHandler(this.lbl_ReportType2_MouseLeave);
            this.lbl_ReportType2.MouseHover += new System.EventHandler(this.lbl_ReportType2_MouseHover);
            // 
            // lbl_ReportType3
            // 
            this.lbl_ReportType3.AutoSize = true;
            this.lbl_ReportType3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReportType3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReportType3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ReportType3.Location = new System.Drawing.Point(54, 282);
            this.lbl_ReportType3.Name = "lbl_ReportType3";
            this.lbl_ReportType3.Size = new System.Drawing.Size(667, 77);
            this.lbl_ReportType3.TabIndex = 4;
            this.lbl_ReportType3.Text = "· Seyahat hakkında detaylı bilgileri\r\n· Seyahat hakkında genel bilgileri ve seyah" +
    "ati yapacak kişinin kimlik bilgileri\r\n· Rezervasyonun fiyatlarını";
            this.lbl_ReportType3.Click += new System.EventHandler(this.lbl_ReportType3_Click);
            this.lbl_ReportType3.MouseLeave += new System.EventHandler(this.lbl_ReportType3_MouseLeave);
            this.lbl_ReportType3.MouseHover += new System.EventHandler(this.lbl_ReportType3_MouseHover);
            // 
            // lbl_ReportType4
            // 
            this.lbl_ReportType4.AutoSize = true;
            this.lbl_ReportType4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ReportType4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ReportType4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ReportType4.Location = new System.Drawing.Point(54, 384);
            this.lbl_ReportType4.Name = "lbl_ReportType4";
            this.lbl_ReportType4.Size = new System.Drawing.Size(667, 77);
            this.lbl_ReportType4.TabIndex = 5;
            this.lbl_ReportType4.Text = "· Rezervasyonun fiyatlarını\r\n· Seyahat hakkında detaylı bilgileri\r\n· Seyahat hakk" +
    "ında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n";
            this.lbl_ReportType4.Click += new System.EventHandler(this.lbl_ReportType4_Click);
            this.lbl_ReportType4.MouseLeave += new System.EventHandler(this.lbl_ReportType4_MouseLeave);
            this.lbl_ReportType4.MouseHover += new System.EventHandler(this.lbl_ReportType4_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(225, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rapor İçeriğini Seçiniz";
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Back.Image")));
            this.pcr_Back.Location = new System.Drawing.Point(20, 12);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(26, 18);
            this.pcr_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Back.TabIndex = 27;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackColor = System.Drawing.Color.Transparent;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.Image")));
            this.pcr_Exit.Location = new System.Drawing.Point(787, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(26, 18);
            this.pcr_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Exit.TabIndex = 26;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 559);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ReportType4);
            this.Controls.Add(this.lbl_ReportType3);
            this.Controls.Add(this.lbl_ReportType2);
            this.Controls.Add(this.lbl_ReportType1);
            this.Controls.Add(this.btn_CreateReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReport";
            this.Text = "frmReport";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateReport;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl_ReportType1;
        private System.Windows.Forms.Label lbl_ReportType2;
        private System.Windows.Forms.Label lbl_ReportType3;
        private System.Windows.Forms.Label lbl_ReportType4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}