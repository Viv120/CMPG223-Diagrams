
namespace Book_Exchange_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.TopGraphic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGraphic = new System.Windows.Forms.Panel();
            this.btnReloadApplicants = new System.Windows.Forms.Button();
            this.btnDeleteApps = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReloadDonors = new System.Windows.Forms.Button();
            this.btnDeleteDonors = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.Applicants = new System.Windows.Forms.Panel();
            this.gbApplicants = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchApp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchApplicant = new System.Windows.Forms.TextBox();
            this.cbDeleteApp = new System.Windows.Forms.ComboBox();
            this.lblApplicantID = new System.Windows.Forms.Label();
            this.btnDelReload = new System.Windows.Forms.Button();
            this.TopGraphic.SuspendLayout();
            this.ButtonGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Applicants.SuspendLayout();
            this.gbApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopGraphic
            // 
            this.TopGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopGraphic.BackgroundImage")));
            this.TopGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopGraphic.Controls.Add(this.label1);
            this.TopGraphic.Location = new System.Drawing.Point(376, 0);
            this.TopGraphic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopGraphic.Name = "TopGraphic";
            this.TopGraphic.Size = new System.Drawing.Size(1719, 341);
            this.TopGraphic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(732, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // ButtonGraphic
            // 
            this.ButtonGraphic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGraphic.BackgroundImage")));
            this.ButtonGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonGraphic.Controls.Add(this.btnReloadApplicants);
            this.ButtonGraphic.Controls.Add(this.btnDeleteApps);
            this.ButtonGraphic.Controls.Add(this.btnReports);
            this.ButtonGraphic.Controls.Add(this.pictureBox1);
            this.ButtonGraphic.Controls.Add(this.btnBack);
            this.ButtonGraphic.Controls.Add(this.btnReloadDonors);
            this.ButtonGraphic.Controls.Add(this.btnDeleteDonors);
            this.ButtonGraphic.Controls.Add(this.btnShowBooks);
            this.ButtonGraphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonGraphic.Location = new System.Drawing.Point(0, 0);
            this.ButtonGraphic.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonGraphic.Name = "ButtonGraphic";
            this.ButtonGraphic.Size = new System.Drawing.Size(341, 1388);
            this.ButtonGraphic.TabIndex = 5;
            // 
            // btnReloadApplicants
            // 
            this.btnReloadApplicants.BackColor = System.Drawing.Color.Teal;
            this.btnReloadApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadApplicants.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReloadApplicants.Location = new System.Drawing.Point(20, 746);
            this.btnReloadApplicants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReloadApplicants.Name = "btnReloadApplicants";
            this.btnReloadApplicants.Size = new System.Drawing.Size(307, 110);
            this.btnReloadApplicants.TabIndex = 34;
            this.btnReloadApplicants.Text = "Reload Applicant table";
            this.btnReloadApplicants.UseVisualStyleBackColor = false;
            this.btnReloadApplicants.Click += new System.EventHandler(this.btnReloadApplicants_Click);
            // 
            // btnDeleteApps
            // 
            this.btnDeleteApps.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteApps.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApps.Location = new System.Drawing.Point(15, 619);
            this.btnDeleteApps.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteApps.Name = "btnDeleteApps";
            this.btnDeleteApps.Size = new System.Drawing.Size(312, 116);
            this.btnDeleteApps.TabIndex = 33;
            this.btnDeleteApps.Text = "Delete Applicants";
            this.btnDeleteApps.UseVisualStyleBackColor = false;
            this.btnDeleteApps.Click += new System.EventHandler(this.btnDeleteApps_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Teal;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(20, 876);
            this.btnReports.Margin = new System.Windows.Forms.Padding(6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(312, 134);
            this.btnReports.TabIndex = 32;
            this.btnReports.Text = "Request Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(54, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 159);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(8, 1030);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(312, 116);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReloadDonors
            // 
            this.btnReloadDonors.BackColor = System.Drawing.Color.Teal;
            this.btnReloadDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadDonors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReloadDonors.Location = new System.Drawing.Point(20, 489);
            this.btnReloadDonors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReloadDonors.Name = "btnReloadDonors";
            this.btnReloadDonors.Size = new System.Drawing.Size(307, 110);
            this.btnReloadDonors.TabIndex = 7;
            this.btnReloadDonors.Text = "Reload Donor Table";
            this.btnReloadDonors.UseVisualStyleBackColor = false;
            this.btnReloadDonors.Click += new System.EventHandler(this.btnReloadDonors_Click);
            // 
            // btnDeleteDonors
            // 
            this.btnDeleteDonors.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDonors.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDonors.Location = new System.Drawing.Point(20, 357);
            this.btnDeleteDonors.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteDonors.Name = "btnDeleteDonors";
            this.btnDeleteDonors.Size = new System.Drawing.Size(312, 116);
            this.btnDeleteDonors.TabIndex = 1;
            this.btnDeleteDonors.Text = "Delete Donors";
            this.btnDeleteDonors.UseVisualStyleBackColor = false;
            this.btnDeleteDonors.Click += new System.EventHandler(this.btnDeleteDonors_Click);
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.BackColor = System.Drawing.Color.Teal;
            this.btnShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBooks.ForeColor = System.Drawing.Color.White;
            this.btnShowBooks.Location = new System.Drawing.Point(20, 225);
            this.btnShowBooks.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(312, 116);
            this.btnShowBooks.TabIndex = 0;
            this.btnShowBooks.Text = "Show Books";
            this.btnShowBooks.UseVisualStyleBackColor = false;
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // Applicants
            // 
            this.Applicants.Controls.Add(this.gbApplicants);
            this.Applicants.Location = new System.Drawing.Point(376, 489);
            this.Applicants.Margin = new System.Windows.Forms.Padding(6);
            this.Applicants.Name = "Applicants";
            this.Applicants.Size = new System.Drawing.Size(1743, 946);
            this.Applicants.TabIndex = 23;
            // 
            // gbApplicants
            // 
            this.gbApplicants.Controls.Add(this.dataGridView1);
            this.gbApplicants.Controls.Add(this.btnSearchApp);
            this.gbApplicants.Controls.Add(this.panel3);
            this.gbApplicants.Controls.Add(this.cbDeleteApp);
            this.gbApplicants.Controls.Add(this.lblApplicantID);
            this.gbApplicants.Controls.Add(this.btnDelReload);
            this.gbApplicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicants.ForeColor = System.Drawing.Color.Black;
            this.gbApplicants.Location = new System.Drawing.Point(0, 0);
            this.gbApplicants.Margin = new System.Windows.Forms.Padding(6);
            this.gbApplicants.Name = "gbApplicants";
            this.gbApplicants.Padding = new System.Windows.Forms.Padding(6);
            this.gbApplicants.Size = new System.Drawing.Size(1743, 946);
            this.gbApplicants.TabIndex = 0;
            this.gbApplicants.TabStop = false;
            this.gbApplicants.Text = "Delete Applicants";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1716, 673);
            this.dataGridView1.TabIndex = 34;
            // 
            // btnSearchApp
            // 
            this.btnSearchApp.BackColor = System.Drawing.Color.Teal;
            this.btnSearchApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchApp.Location = new System.Drawing.Point(1375, 65);
            this.btnSearchApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchApp.Name = "btnSearchApp";
            this.btnSearchApp.Size = new System.Drawing.Size(184, 73);
            this.btnSearchApp.TabIndex = 33;
            this.btnSearchApp.Text = "Search";
            this.btnSearchApp.UseVisualStyleBackColor = false;
            this.btnSearchApp.Click += new System.EventHandler(this.btnSearchApp_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtSearchApplicant);
            this.panel3.Location = new System.Drawing.Point(843, 65);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 73);
            this.panel3.TabIndex = 32;
            // 
            // txtSearchApplicant
            // 
            this.txtSearchApplicant.Location = new System.Drawing.Point(24, 15);
            this.txtSearchApplicant.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearchApplicant.Name = "txtSearchApplicant";
            this.txtSearchApplicant.Size = new System.Drawing.Size(372, 44);
            this.txtSearchApplicant.TabIndex = 27;
            // 
            // cbDeleteApp
            // 
            this.cbDeleteApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDeleteApp.FormattingEnabled = true;
            this.cbDeleteApp.Location = new System.Drawing.Point(320, 62);
            this.cbDeleteApp.Margin = new System.Windows.Forms.Padding(6);
            this.cbDeleteApp.Name = "cbDeleteApp";
            this.cbDeleteApp.Size = new System.Drawing.Size(462, 45);
            this.cbDeleteApp.TabIndex = 19;
            this.cbDeleteApp.Text = "3";
            // 
            // lblApplicantID
            // 
            this.lblApplicantID.AutoSize = true;
            this.lblApplicantID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApplicantID.Location = new System.Drawing.Point(12, 65);
            this.lblApplicantID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblApplicantID.Name = "lblApplicantID";
            this.lblApplicantID.Size = new System.Drawing.Size(296, 37);
            this.lblApplicantID.TabIndex = 6;
            this.lblApplicantID.Text = "Applicant/Donor ID:";
            // 
            // btnDelReload
            // 
            this.btnDelReload.BackColor = System.Drawing.Color.Teal;
            this.btnDelReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelReload.ForeColor = System.Drawing.Color.White;
            this.btnDelReload.Location = new System.Drawing.Point(687, 998);
            this.btnDelReload.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelReload.Name = "btnDelReload";
            this.btnDelReload.Size = new System.Drawing.Size(252, 67);
            this.btnDelReload.TabIndex = 5;
            this.btnDelReload.Text = "Reload Table";
            this.btnDelReload.UseVisualStyleBackColor = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2107, 1388);
            this.Controls.Add(this.Applicants);
            this.Controls.Add(this.ButtonGraphic);
            this.Controls.Add(this.TopGraphic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.TopGraphic.ResumeLayout(false);
            this.TopGraphic.PerformLayout();
            this.ButtonGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Applicants.ResumeLayout(false);
            this.gbApplicants.ResumeLayout(false);
            this.gbApplicants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopGraphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ButtonGraphic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteDonors;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnDeleteApps;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnReloadDonors;
        private System.Windows.Forms.Panel Applicants;
        private System.Windows.Forms.GroupBox gbApplicants;
        private System.Windows.Forms.ComboBox cbDeleteApp;
        private System.Windows.Forms.Label lblApplicantID;
        private System.Windows.Forms.Button btnDelReload;
        private System.Windows.Forms.Button btnSearchApp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchApplicant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReloadApplicants;
    }
}
