
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcess));
            this.btn_CreateTravel = new System.Windows.Forms.Button();
            this.btn_CreateReport = new System.Windows.Forms.Button();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
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
            this.btn_CreateTravel.ForeColor = System.Drawing.Color.Black;
            this.btn_CreateTravel.Location = new System.Drawing.Point(172, 227);
            this.btn_CreateTravel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateTravel.Name = "btn_CreateTravel";
            this.btn_CreateTravel.Size = new System.Drawing.Size(187, 74);
            this.btn_CreateTravel.TabIndex = 0;
            this.btn_CreateTravel.Text = "Seyhat Oluştur";
            this.btn_CreateTravel.UseVisualStyleBackColor = false;
            this.btn_CreateTravel.Click += new System.EventHandler(this.btn_CreateTravel_Click);
            this.btn_CreateTravel.MouseLeave += new System.EventHandler(this.btn_CreateTravel_MouseLeave);
            this.btn_CreateTravel.MouseHover += new System.EventHandler(this.btn_CreateTravel_MouseHover);
            // 
            // btn_CreateReport
            // 
            this.btn_CreateReport.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateReport.FlatAppearance.BorderSize = 2;
            this.btn_CreateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_CreateReport.ForeColor = System.Drawing.Color.Black;
            this.btn_CreateReport.Location = new System.Drawing.Point(446, 227);
            this.btn_CreateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CreateReport.Name = "btn_CreateReport";
            this.btn_CreateReport.Size = new System.Drawing.Size(187, 74);
            this.btn_CreateReport.TabIndex = 0;
            this.btn_CreateReport.Text = "Rapor Oluştur";
            this.btn_CreateReport.UseVisualStyleBackColor = false;
            this.btn_CreateReport.Click += new System.EventHandler(this.btn_CreateReport_Click);
            this.btn_CreateReport.MouseLeave += new System.EventHandler(this.btn_CreateReport_MouseLeave);
            this.btn_CreateReport.MouseHover += new System.EventHandler(this.btn_CreateReport_MouseHover);
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
            this.pcr_Back.TabIndex = 25;
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
            this.pcr_Exit.TabIndex = 24;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // frmProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 559);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.btn_CreateReport);
            this.Controls.Add(this.btn_CreateTravel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProcess";
            this.Text = "frmProcess";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateTravel;
        private System.Windows.Forms.Button btn_CreateReport;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}