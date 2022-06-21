
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
            this.btn_CreateReport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_ReportType1 = new System.Windows.Forms.Label();
            this.lbl_ReportType2 = new System.Windows.Forms.Label();
            this.lbl_ReportType3 = new System.Windows.Forms.Label();
            this.lbl_ReportType4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CreateReport
            // 
            this.btn_CreateReport.Enabled = false;
            this.btn_CreateReport.Location = new System.Drawing.Point(566, 373);
            this.btn_CreateReport.Name = "btn_CreateReport";
            this.btn_CreateReport.Size = new System.Drawing.Size(153, 65);
            this.btn_CreateReport.TabIndex = 0;
            this.btn_CreateReport.Text = "Rapor Oluştur";
            this.btn_CreateReport.UseVisualStyleBackColor = true;
            this.btn_CreateReport.Click += new System.EventHandler(this.btn_CreateReport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_ReportType1
            // 
            this.lbl_ReportType1.AutoSize = true;
            this.lbl_ReportType1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ReportType1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType1.Location = new System.Drawing.Point(36, 35);
            this.lbl_ReportType1.Name = "lbl_ReportType1";
            this.lbl_ReportType1.Size = new System.Drawing.Size(507, 62);
            this.lbl_ReportType1.TabIndex = 2;
            this.lbl_ReportType1.Text = "· Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n" +
    "· Seyahat hakkında detaylı bilgileri\r\n· Rezervasyonun fiyatlarını";
            this.lbl_ReportType1.Click += new System.EventHandler(this.lbl_ReportType_Click);
            // 
            // lbl_ReportType2
            // 
            this.lbl_ReportType2.AutoSize = true;
            this.lbl_ReportType2.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ReportType2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType2.Location = new System.Drawing.Point(36, 119);
            this.lbl_ReportType2.Name = "lbl_ReportType2";
            this.lbl_ReportType2.Size = new System.Drawing.Size(507, 62);
            this.lbl_ReportType2.TabIndex = 3;
            this.lbl_ReportType2.Text = "· Seyahat hakkında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n" +
    "· Rezervasyonun fiyatlarını\r\n· Seyahat hakkında detaylı bilgileri\r\n";
            this.lbl_ReportType2.Click += new System.EventHandler(this.lbl_ReportType2_Click);
            // 
            // lbl_ReportType3
            // 
            this.lbl_ReportType3.AutoSize = true;
            this.lbl_ReportType3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ReportType3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType3.Location = new System.Drawing.Point(36, 206);
            this.lbl_ReportType3.Name = "lbl_ReportType3";
            this.lbl_ReportType3.Size = new System.Drawing.Size(507, 62);
            this.lbl_ReportType3.TabIndex = 4;
            this.lbl_ReportType3.Text = "· Seyahat hakkında detaylı bilgileri\r\n· Seyahat hakkında genel bilgileri ve seyah" +
    "ati yapacak kişinin kimlik bilgileri\r\n· Rezervasyonun fiyatlarını";
            this.lbl_ReportType3.Click += new System.EventHandler(this.lbl_ReportType3_Click);
            // 
            // lbl_ReportType4
            // 
            this.lbl_ReportType4.AutoSize = true;
            this.lbl_ReportType4.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ReportType4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ReportType4.Location = new System.Drawing.Point(36, 294);
            this.lbl_ReportType4.Name = "lbl_ReportType4";
            this.lbl_ReportType4.Size = new System.Drawing.Size(507, 62);
            this.lbl_ReportType4.TabIndex = 5;
            this.lbl_ReportType4.Text = "· Rezervasyonun fiyatlarını\r\n· Seyahat hakkında detaylı bilgileri\r\n· Seyahat hakk" +
    "ında genel bilgileri ve seyahati yapacak kişinin kimlik bilgileri\r\n";
            this.lbl_ReportType4.Click += new System.EventHandler(this.lbl_ReportType4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rapor Oluşturma şekli seçin";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_ReportType4);
            this.Controls.Add(this.lbl_ReportType3);
            this.Controls.Add(this.lbl_ReportType2);
            this.Controls.Add(this.lbl_ReportType1);
            this.Controls.Add(this.btn_CreateReport);
            this.Name = "frmReport";
            this.Text = "frmReport";
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
    }
}