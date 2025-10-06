
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
            this.btnDeleteApps = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteDonors = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.Donors = new System.Windows.Forms.Panel();
            this.gbDonors = new System.Windows.Forms.GroupBox();
            this.cbDeleteDonor = new System.Windows.Forms.ComboBox();
            this.lblDelAppID = new System.Windows.Forms.Label();
            this.btnDeleteDonor = new System.Windows.Forms.Button();
            this.btnReloadDonors = new System.Windows.Forms.Button();
            this.btnSearchDonor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchDonors = new System.Windows.Forms.TextBox();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.Books = new System.Windows.Forms.Panel();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.btnMaintainBooks = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Applicants = new System.Windows.Forms.Panel();
            this.gbApplicants = new System.Windows.Forms.GroupBox();
            this.cbDeleteApp = new System.Windows.Forms.ComboBox();
            this.lblApplicantID = new System.Windows.Forms.Label();
            this.btnDeleteApp = new System.Windows.Forms.Button();
            this.btnDelReload = new System.Windows.Forms.Button();
            this.btnReloadApplicants = new System.Windows.Forms.Button();
            this.btnSearchApp = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.txtSearchApplicant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopGraphic.SuspendLayout();
            this.ButtonGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Donors.SuspendLayout();
            this.gbDonors.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.Books.SuspendLayout();
            this.gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.Applicants.SuspendLayout();
            this.gbApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopGraphic
            // 
            this.TopGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopGraphic.BackgroundImage")));
            this.TopGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopGraphic.Controls.Add(this.label1);
            this.TopGraphic.Location = new System.Drawing.Point(251, 0);
            this.TopGraphic.Name = "TopGraphic";
            this.TopGraphic.Size = new System.Drawing.Size(1168, 218);
            this.TopGraphic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(488, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // ButtonGraphic
            // 
            this.ButtonGraphic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGraphic.BackgroundImage")));
            this.ButtonGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonGraphic.Controls.Add(this.btnDeleteApps);
            this.ButtonGraphic.Controls.Add(this.btnReports);
            this.ButtonGraphic.Controls.Add(this.pictureBox1);
            this.ButtonGraphic.Controls.Add(this.btnBack);
            this.ButtonGraphic.Controls.Add(this.btnDeleteDonors);
            this.ButtonGraphic.Controls.Add(this.btnShowBooks);
            this.ButtonGraphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonGraphic.Location = new System.Drawing.Point(0, 0);
            this.ButtonGraphic.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGraphic.Name = "ButtonGraphic";
            this.ButtonGraphic.Size = new System.Drawing.Size(253, 818);
            this.ButtonGraphic.TabIndex = 5;
            // 
            // btnDeleteApps
            // 
            this.btnDeleteApps.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteApps.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApps.Location = new System.Drawing.Point(13, 422);
            this.btnDeleteApps.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteApps.Name = "btnDeleteApps";
            this.btnDeleteApps.Size = new System.Drawing.Size(208, 74);
            this.btnDeleteApps.TabIndex = 33;
            this.btnDeleteApps.Text = "Delete Applicants";
            this.btnDeleteApps.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Teal;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(13, 572);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(208, 74);
            this.btnReports.TabIndex = 32;
            this.btnReports.Text = "Request Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(36, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 102);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(13, 684);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 74);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDonors
            // 
            this.btnDeleteDonors.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDonors.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDonors.Location = new System.Drawing.Point(13, 320);
            this.btnDeleteDonors.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDonors.Name = "btnDeleteDonors";
            this.btnDeleteDonors.Size = new System.Drawing.Size(208, 74);
            this.btnDeleteDonors.TabIndex = 1;
            this.btnDeleteDonors.Text = "Delete Donors";
            this.btnDeleteDonors.UseVisualStyleBackColor = false;
            // 
            // btnShowBooks
            // 
            this.btnShowBooks.BackColor = System.Drawing.Color.Teal;
            this.btnShowBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBooks.ForeColor = System.Drawing.Color.White;
            this.btnShowBooks.Location = new System.Drawing.Point(13, 218);
            this.btnShowBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowBooks.Name = "btnShowBooks";
            this.btnShowBooks.Size = new System.Drawing.Size(208, 74);
            this.btnShowBooks.TabIndex = 0;
            this.btnShowBooks.Text = "Show Books";
            this.btnShowBooks.UseVisualStyleBackColor = false;
            // 
            // Donors
            // 
            this.Donors.Controls.Add(this.gbDonors);
            this.Donors.Location = new System.Drawing.Point(251, 218);
            this.Donors.Name = "Donors";
            this.Donors.Size = new System.Drawing.Size(1162, 597);
            this.Donors.TabIndex = 8;
            // 
            // gbDonors
            // 
            this.gbDonors.Controls.Add(this.cbDeleteDonor);
            this.gbDonors.Controls.Add(this.lblDelAppID);
            this.gbDonors.Controls.Add(this.btnDeleteDonor);
            this.gbDonors.Controls.Add(this.btnReloadDonors);
            this.gbDonors.Controls.Add(this.btnSearchDonor);
            this.gbDonors.Controls.Add(this.panel4);
            this.gbDonors.Controls.Add(this.dgvDonors);
            this.gbDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDonors.Location = new System.Drawing.Point(13, 8);
            this.gbDonors.Name = "gbDonors";
            this.gbDonors.Size = new System.Drawing.Size(1137, 577);
            this.gbDonors.TabIndex = 0;
            this.gbDonors.TabStop = false;
            this.gbDonors.Text = "Delete Donors";
            // 
            // cbDeleteDonor
            // 
            this.cbDeleteDonor.FormattingEnabled = true;
            this.cbDeleteDonor.Location = new System.Drawing.Point(48, 111);
            this.cbDeleteDonor.Name = "cbDeleteDonor";
            this.cbDeleteDonor.Size = new System.Drawing.Size(317, 37);
            this.cbDeleteDonor.TabIndex = 27;
            // 
            // lblDelAppID
            // 
            this.lblDelAppID.AutoSize = true;
            this.lblDelAppID.ForeColor = System.Drawing.Color.Black;
            this.lblDelAppID.Location = new System.Drawing.Point(43, 67);
            this.lblDelAppID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelAppID.Name = "lblDelAppID";
            this.lblDelAppID.Size = new System.Drawing.Size(114, 29);
            this.lblDelAppID.TabIndex = 20;
            this.lblDelAppID.Text = "Donor ID:";
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteDonor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteDonor.Location = new System.Drawing.Point(48, 467);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(290, 50);
            this.btnDeleteDonor.TabIndex = 8;
            this.btnDeleteDonor.Text = "Delete";
            this.btnDeleteDonor.UseVisualStyleBackColor = false;
            // 
            // btnReloadDonors
            // 
            this.btnReloadDonors.BackColor = System.Drawing.Color.Teal;
            this.btnReloadDonors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReloadDonors.Location = new System.Drawing.Point(454, 531);
            this.btnReloadDonors.Name = "btnReloadDonors";
            this.btnReloadDonors.Size = new System.Drawing.Size(162, 39);
            this.btnReloadDonors.TabIndex = 7;
            this.btnReloadDonors.Text = "Reload table";
            this.btnReloadDonors.UseVisualStyleBackColor = false;
            // 
            // btnSearchDonor
            // 
            this.btnSearchDonor.BackColor = System.Drawing.Color.Teal;
            this.btnSearchDonor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchDonor.Location = new System.Drawing.Point(968, 62);
            this.btnSearchDonor.Name = "btnSearchDonor";
            this.btnSearchDonor.Size = new System.Drawing.Size(123, 47);
            this.btnSearchDonor.TabIndex = 6;
            this.btnSearchDonor.Text = "Search";
            this.btnSearchDonor.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txtSearchDonors);
            this.panel4.Location = new System.Drawing.Point(624, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 47);
            this.panel4.TabIndex = 5;
            // 
            // txtSearchDonors
            // 
            this.txtSearchDonors.Location = new System.Drawing.Point(11, 7);
            this.txtSearchDonors.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchDonors.Name = "txtSearchDonors";
            this.txtSearchDonors.Size = new System.Drawing.Size(249, 33);
            this.txtSearchDonors.TabIndex = 27;
            // 
            // dgvDonors
            // 
            this.dgvDonors.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(454, 115);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 49;
            this.dgvDonors.RowTemplate.Height = 24;
            this.dgvDonors.Size = new System.Drawing.Size(664, 398);
            this.dgvDonors.TabIndex = 4;
            // 
            // Books
            // 
            this.Books.Controls.Add(this.gbBooks);
            this.Books.Location = new System.Drawing.Point(251, 218);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(1162, 597);
            this.Books.TabIndex = 28;
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.btnMaintainBooks);
            this.gbBooks.Controls.Add(this.dgvBooks);
            this.gbBooks.Location = new System.Drawing.Point(0, 0);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Size = new System.Drawing.Size(1168, 597);
            this.gbBooks.TabIndex = 0;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Show Books";
            // 
            // btnMaintainBooks
            // 
            this.btnMaintainBooks.BackColor = System.Drawing.Color.Teal;
            this.btnMaintainBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainBooks.ForeColor = System.Drawing.Color.White;
            this.btnMaintainBooks.Location = new System.Drawing.Point(500, 504);
            this.btnMaintainBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintainBooks.Name = "btnMaintainBooks";
            this.btnMaintainBooks.Size = new System.Drawing.Size(208, 74);
            this.btnMaintainBooks.TabIndex = 34;
            this.btnMaintainBooks.Text = "Maintain Books";
            this.btnMaintainBooks.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(195, 70);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 49;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(780, 387);
            this.dgvBooks.TabIndex = 5;
            // 
            // Applicants
            // 
            this.Applicants.Controls.Add(this.gbApplicants);
            this.Applicants.Location = new System.Drawing.Point(251, 218);
            this.Applicants.Margin = new System.Windows.Forms.Padding(4);
            this.Applicants.Name = "Applicants";
            this.Applicants.Size = new System.Drawing.Size(1162, 700);
            this.Applicants.TabIndex = 23;
            // 
            // gbApplicants
            // 
            this.gbApplicants.Controls.Add(this.btnReloadApplicants);
            this.gbApplicants.Controls.Add(this.btnSearchApp);
            this.gbApplicants.Controls.Add(this.panel3);
            this.gbApplicants.Controls.Add(this.cbDeleteApp);
            this.gbApplicants.Controls.Add(this.lblApplicantID);
            this.gbApplicants.Controls.Add(this.btnDelReload);
            this.gbApplicants.Controls.Add(this.btnDeleteApp);
            this.gbApplicants.Controls.Add(this.dgvApplicants);
            this.gbApplicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicants.ForeColor = System.Drawing.Color.Black;
            this.gbApplicants.Location = new System.Drawing.Point(0, 0);
            this.gbApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.gbApplicants.Name = "gbApplicants";
            this.gbApplicants.Padding = new System.Windows.Forms.Padding(4);
            this.gbApplicants.Size = new System.Drawing.Size(1162, 700);
            this.gbApplicants.TabIndex = 0;
            this.gbApplicants.TabStop = false;
            this.gbApplicants.Text = "Delete Applicants";
            // 
            // cbDeleteApp
            // 
            this.cbDeleteApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDeleteApp.FormattingEnabled = true;
            this.cbDeleteApp.Location = new System.Drawing.Point(13, 136);
            this.cbDeleteApp.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeleteApp.Name = "cbDeleteApp";
            this.cbDeleteApp.Size = new System.Drawing.Size(213, 33);
            this.cbDeleteApp.TabIndex = 19;
            // 
            // lblApplicantID
            // 
            this.lblApplicantID.AutoSize = true;
            this.lblApplicantID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApplicantID.Location = new System.Drawing.Point(8, 95);
            this.lblApplicantID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicantID.Name = "lblApplicantID";
            this.lblApplicantID.Size = new System.Drawing.Size(123, 25);
            this.lblApplicantID.TabIndex = 6;
            this.lblApplicantID.Text = "Applicant ID:";
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteApp.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApp.Location = new System.Drawing.Point(13, 193);
            this.btnDeleteApp.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(173, 54);
            this.btnDeleteApp.TabIndex = 1;
            this.btnDeleteApp.Text = "Delete";
            this.btnDeleteApp.UseVisualStyleBackColor = false;
            // 
            // btnDelReload
            // 
            this.btnDelReload.BackColor = System.Drawing.Color.Teal;
            this.btnDelReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelReload.ForeColor = System.Drawing.Color.White;
            this.btnDelReload.Location = new System.Drawing.Point(458, 639);
            this.btnDelReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelReload.Name = "btnDelReload";
            this.btnDelReload.Size = new System.Drawing.Size(168, 43);
            this.btnDelReload.TabIndex = 5;
            this.btnDelReload.Text = "Reload Table";
            this.btnDelReload.UseVisualStyleBackColor = false;
            // 
            // btnReloadApplicants
            // 
            this.btnReloadApplicants.BackColor = System.Drawing.Color.Teal;
            this.btnReloadApplicants.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReloadApplicants.Location = new System.Drawing.Point(454, 527);
            this.btnReloadApplicants.Name = "btnReloadApplicants";
            this.btnReloadApplicants.Size = new System.Drawing.Size(162, 39);
            this.btnReloadApplicants.TabIndex = 34;
            this.btnReloadApplicants.Text = "Reload table";
            this.btnReloadApplicants.UseVisualStyleBackColor = false;
            // 
            // btnSearchApp
            // 
            this.btnSearchApp.BackColor = System.Drawing.Color.Teal;
            this.btnSearchApp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchApp.Location = new System.Drawing.Point(798, 57);
            this.btnSearchApp.Name = "btnSearchApp";
            this.btnSearchApp.Size = new System.Drawing.Size(123, 47);
            this.btnSearchApp.TabIndex = 33;
            this.btnSearchApp.Text = "Search";
            this.btnSearchApp.UseVisualStyleBackColor = false;
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Location = new System.Drawing.Point(454, 115);
            this.dgvApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.RowHeadersWidth = 51;
            this.dgvApplicants.Size = new System.Drawing.Size(664, 398);
            this.dgvApplicants.TabIndex = 0;
            // 
            // txtSearchApplicant
            // 
            this.txtSearchApplicant.Location = new System.Drawing.Point(11, 7);
            this.txtSearchApplicant.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchApplicant.Name = "txtSearchApplicant";
            this.txtSearchApplicant.Size = new System.Drawing.Size(249, 30);
            this.txtSearchApplicant.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtSearchApplicant);
            this.panel3.Location = new System.Drawing.Point(454, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 47);
            this.panel3.TabIndex = 32;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 818);
            this.Controls.Add(this.Donors);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Applicants);
            this.Controls.Add(this.ButtonGraphic);
            this.Controls.Add(this.TopGraphic);
            this.Name = "Admin";
            this.Text = "Admin";
            this.TopGraphic.ResumeLayout(false);
            this.TopGraphic.PerformLayout();
            this.ButtonGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Donors.ResumeLayout(false);
            this.gbDonors.ResumeLayout(false);
            this.gbDonors.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.Books.ResumeLayout(false);
            this.gbBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.Applicants.ResumeLayout(false);
            this.gbApplicants.ResumeLayout(false);
            this.gbApplicants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
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
        private System.Windows.Forms.Panel Donors;
        private System.Windows.Forms.GroupBox gbDonors;
        private System.Windows.Forms.ComboBox cbDeleteDonor;
        private System.Windows.Forms.Label lblDelAppID;
        private System.Windows.Forms.Button btnDeleteDonor;
        private System.Windows.Forms.Button btnReloadDonors;
        private System.Windows.Forms.Button btnSearchDonor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchDonors;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Panel Books;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.Button btnMaintainBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel Applicants;
        private System.Windows.Forms.GroupBox gbApplicants;
        private System.Windows.Forms.ComboBox cbDeleteApp;
        private System.Windows.Forms.Label lblApplicantID;
        private System.Windows.Forms.Button btnDeleteApp;
        private System.Windows.Forms.Button btnDelReload;
        private System.Windows.Forms.Button btnReloadApplicants;
        private System.Windows.Forms.Button btnSearchApp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearchApplicant;
        private System.Windows.Forms.DataGridView dgvApplicants;
    }
}