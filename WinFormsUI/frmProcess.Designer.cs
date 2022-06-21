
namespace WinFormsUI
{
    partial class frmProcess
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
            this.btn_CreateTravel = new System.Windows.Forms.Button();
            this.btn_CreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateTravel
            // 
            this.btn_CreateTravel.Location = new System.Drawing.Point(101, 131);
            this.btn_CreateTravel.Name = "btn_CreateTravel";
            this.btn_CreateTravel.Size = new System.Drawing.Size(214, 99);
            this.btn_CreateTravel.TabIndex = 0;
            this.btn_CreateTravel.Text = "Seyhat Oluştur";
            this.btn_CreateTravel.UseVisualStyleBackColor = true;
            this.btn_CreateTravel.Click += new System.EventHandler(this.btn_CreateTravel_Click);
            // 
            // btn_CreateReport
            // 
            this.btn_CreateReport.Location = new System.Drawing.Point(398, 133);
            this.btn_CreateReport.Name = "btn_CreateReport";
            this.btn_CreateReport.Size = new System.Drawing.Size(241, 95);
            this.btn_CreateReport.TabIndex = 1;
            this.btn_CreateReport.Text = "Rapor Oluştur";
            this.btn_CreateReport.UseVisualStyleBackColor = true;
            this.btn_CreateReport.Click += new System.EventHandler(this.btn_CreateReport_Click);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CreateReport);
            this.Controls.Add(this.btn_CreateTravel);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateTravel;
        private System.Windows.Forms.Button btn_CreateReport;
    }
}