
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
            this.btnShowApps = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShowDonors = new System.Windows.Forms.Button();
            this.btnShowBooks = new System.Windows.Forms.Button();
            this.Donors = new System.Windows.Forms.Panel();
            this.gbDonors = new System.Windows.Forms.GroupBox();
            this.btnDonor = new System.Windows.Forms.Button();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.Books = new System.Windows.Forms.Panel();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.btnBooks = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Applicants = new System.Windows.Forms.Panel();
            this.gbApplicants = new System.Windows.Forms.GroupBox();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.TopGraphic.SuspendLayout();
            this.ButtonGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Donors.SuspendLayout();
            this.gbDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            this.Books.SuspendLayout();
            this.gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.Applicants.SuspendLayout();
            this.gbApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // TopGraphic
            // 
            this.TopGraphic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopGraphic.BackgroundImage")));
            this.TopGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopGraphic.Controls.Add(this.label1);
            this.TopGraphic.Location = new System.Drawing.Point(251, 0);
            this.TopGraphic.Name = "TopGraphic";
            this.TopGraphic.Size = new System.Drawing.Size(1658, 218);
            this.TopGraphic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(755, 84);
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
            this.ButtonGraphic.Controls.Add(this.btnShowApps);
            this.ButtonGraphic.Controls.Add(this.btnReports);
            this.ButtonGraphic.Controls.Add(this.pictureBox1);
            this.ButtonGraphic.Controls.Add(this.btnBack);
            this.ButtonGraphic.Controls.Add(this.btnShowDonors);
            this.ButtonGraphic.Controls.Add(this.btnShowBooks);
            this.ButtonGraphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonGraphic.Location = new System.Drawing.Point(0, 0);
            this.ButtonGraphic.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGraphic.Name = "ButtonGraphic";
            this.ButtonGraphic.Size = new System.Drawing.Size(253, 993);
            this.ButtonGraphic.TabIndex = 5;
            // 
            // btnShowApps
            // 
            this.btnShowApps.BackColor = System.Drawing.Color.Teal;
            this.btnShowApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowApps.ForeColor = System.Drawing.Color.White;
            this.btnShowApps.Location = new System.Drawing.Point(13, 422);
            this.btnShowApps.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowApps.Name = "btnShowApps";
            this.btnShowApps.Size = new System.Drawing.Size(208, 74);
            this.btnShowApps.TabIndex = 33;
            this.btnShowApps.Text = "Show Applicants";
            this.btnShowApps.UseVisualStyleBackColor = false;
            this.btnShowApps.Click += new System.EventHandler(this.btnDeleteApps_Click);
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
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShowDonors
            // 
            this.btnShowDonors.BackColor = System.Drawing.Color.Teal;
            this.btnShowDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDonors.ForeColor = System.Drawing.Color.White;
            this.btnShowDonors.Location = new System.Drawing.Point(13, 320);
            this.btnShowDonors.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDonors.Name = "btnShowDonors";
            this.btnShowDonors.Size = new System.Drawing.Size(208, 74);
            this.btnShowDonors.TabIndex = 1;
            this.btnShowDonors.Text = "Show Donors";
            this.btnShowDonors.UseVisualStyleBackColor = false;
            this.btnShowDonors.Click += new System.EventHandler(this.btnDeleteDonors_Click);
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
            this.btnShowBooks.Click += new System.EventHandler(this.btnShowBooks_Click);
            // 
            // Donors
            // 
            this.Donors.Controls.Add(this.gbDonors);
            this.Donors.Location = new System.Drawing.Point(251, 218);
            this.Donors.Margin = new System.Windows.Forms.Padding(4);
            this.Donors.Name = "Donors";
            this.Donors.Size = new System.Drawing.Size(1655, 780);
            this.Donors.TabIndex = 8;
            // 
            // gbDonors
            // 
            this.gbDonors.Controls.Add(this.btnDonor);
            this.gbDonors.Controls.Add(this.dgvDonors);
            this.gbDonors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDonors.Location = new System.Drawing.Point(0, 0);
            this.gbDonors.Margin = new System.Windows.Forms.Padding(4);
            this.gbDonors.Name = "gbDonors";
            this.gbDonors.Padding = new System.Windows.Forms.Padding(4);
            this.gbDonors.Size = new System.Drawing.Size(1655, 780);
            this.gbDonors.TabIndex = 0;
            this.gbDonors.TabStop = false;
            this.gbDonors.Text = "Donors";
            // 
            // btnDonor
            // 
            this.btnDonor.BackColor = System.Drawing.Color.Teal;
            this.btnDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDonor.Location = new System.Drawing.Point(713, 579);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(208, 74);
            this.btnDonor.TabIndex = 8;
            this.btnDonor.Text = "Maintain Donors";
            this.btnDonor.UseVisualStyleBackColor = false;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // dgvDonors
            // 
            this.dgvDonors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(100, 82);
            this.dgvDonors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowHeadersWidth = 49;
            this.dgvDonors.RowTemplate.Height = 24;
            this.dgvDonors.Size = new System.Drawing.Size(1449, 387);
            this.dgvDonors.TabIndex = 4;
            // 
            // Books
            // 
            this.Books.Controls.Add(this.gbBooks);
            this.Books.Location = new System.Drawing.Point(251, 218);
            this.Books.Margin = new System.Windows.Forms.Padding(4);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(1655, 780);
            this.Books.TabIndex = 28;
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.btnBooks);
            this.gbBooks.Controls.Add(this.dgvBooks);
            this.gbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBooks.Location = new System.Drawing.Point(0, 0);
            this.gbBooks.Margin = new System.Windows.Forms.Padding(4);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Padding = new System.Windows.Forms.Padding(4);
            this.gbBooks.Size = new System.Drawing.Size(1655, 780);
            this.gbBooks.TabIndex = 0;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Show Books";
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Teal;
            this.btnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(713, 579);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(208, 74);
            this.btnBooks.TabIndex = 34;
            this.btnBooks.Text = "Maintain Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnMaintainBooks_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(100, 82);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 49;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(1449, 387);
            this.dgvBooks.TabIndex = 5;
            // 
            // Applicants
            // 
            this.Applicants.Controls.Add(this.gbApplicants);
            this.Applicants.Location = new System.Drawing.Point(251, 218);
            this.Applicants.Margin = new System.Windows.Forms.Padding(4);
            this.Applicants.Name = "Applicants";
            this.Applicants.Size = new System.Drawing.Size(1655, 780);
            this.Applicants.TabIndex = 23;
            // 
            // gbApplicants
            // 
            this.gbApplicants.Controls.Add(this.btnApplicants);
            this.gbApplicants.Controls.Add(this.dgvApplicants);
            this.gbApplicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbApplicants.ForeColor = System.Drawing.Color.Black;
            this.gbApplicants.Location = new System.Drawing.Point(0, 0);
            this.gbApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.gbApplicants.Name = "gbApplicants";
            this.gbApplicants.Padding = new System.Windows.Forms.Padding(4);
            this.gbApplicants.Size = new System.Drawing.Size(1655, 780);
            this.gbApplicants.TabIndex = 0;
            this.gbApplicants.TabStop = false;
            this.gbApplicants.Text = "Applicants";
            // 
            // btnApplicants
            // 
            this.btnApplicants.BackColor = System.Drawing.Color.Teal;
            this.btnApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicants.ForeColor = System.Drawing.Color.White;
            this.btnApplicants.Location = new System.Drawing.Point(713, 579);
            this.btnApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(208, 74);
            this.btnApplicants.TabIndex = 5;
            this.btnApplicants.Text = "Maintain Applicants";
            this.btnApplicants.UseVisualStyleBackColor = false;
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplicants.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Location = new System.Drawing.Point(100, 82);
            this.dgvApplicants.Margin = new System.Windows.Forms.Padding(4);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.RowHeadersWidth = 51;
            this.dgvApplicants.Size = new System.Drawing.Size(1449, 387);
            this.dgvApplicants.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.Applicants);
            this.Controls.Add(this.Donors);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.ButtonGraphic);
            this.Controls.Add(this.TopGraphic);
            this.Name = "Admin";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.TopGraphic.ResumeLayout(false);
            this.TopGraphic.PerformLayout();
            this.ButtonGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Donors.ResumeLayout(false);
            this.gbDonors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            this.Books.ResumeLayout(false);
            this.gbBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.Applicants.ResumeLayout(false);
            this.gbApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopGraphic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ButtonGraphic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnShowDonors;
        private System.Windows.Forms.Button btnShowBooks;
        private System.Windows.Forms.Button btnShowApps;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel Donors;
        private System.Windows.Forms.GroupBox gbDonors;
        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Panel Books;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel Applicants;
        private System.Windows.Forms.GroupBox gbApplicants;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.DataGridView dgvApplicants;
    }
}