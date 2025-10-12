namespace Book_Exchange_System
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssuedReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ButtonGraphic = new System.Windows.Forms.Panel();
            this.btnDonatedReport = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIssue = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIssued = new System.Windows.Forms.Button();
            this.lblTotalIssued = new System.Windows.Forms.Label();
            this.lblIssuedDateRange = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.Issued = new System.Windows.Forms.Panel();
            this.Donated = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDonated = new System.Windows.Forms.Button();
            this.lblTotalDonated = new System.Windows.Forms.Label();
            this.lblDonatedDateRange = new System.Windows.Forms.Label();
            this.dtpDonatedEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDonatedStart = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvDonate = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.ButtonGraphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Issued.SuspendLayout();
            this.Donated.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(244, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1659, 218);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(644, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // btnIssuedReport
            // 
            this.btnIssuedReport.BackColor = System.Drawing.Color.Teal;
            this.btnIssuedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssuedReport.ForeColor = System.Drawing.Color.White;
            this.btnIssuedReport.Location = new System.Drawing.Point(13, 306);
            this.btnIssuedReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssuedReport.Name = "btnIssuedReport";
            this.btnIssuedReport.Size = new System.Drawing.Size(208, 96);
            this.btnIssuedReport.TabIndex = 1;
            this.btnIssuedReport.Text = "Books Issued per Time Period";
            this.btnIssuedReport.UseVisualStyleBackColor = false;
            this.btnIssuedReport.Click += new System.EventHandler(this.btnIssuedReport_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(16, 690);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 74);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ButtonGraphic
            // 
            this.ButtonGraphic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGraphic.BackgroundImage")));
            this.ButtonGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonGraphic.Controls.Add(this.btnDonatedReport);
            this.ButtonGraphic.Controls.Add(this.pictureBox1);
            this.ButtonGraphic.Controls.Add(this.panel2);
            this.ButtonGraphic.Controls.Add(this.btnBack);
            this.ButtonGraphic.Controls.Add(this.btnIssuedReport);
            this.ButtonGraphic.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonGraphic.Location = new System.Drawing.Point(0, 0);
            this.ButtonGraphic.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGraphic.Name = "ButtonGraphic";
            this.ButtonGraphic.Size = new System.Drawing.Size(246, 993);
            this.ButtonGraphic.TabIndex = 3;
            // 
            // btnDonatedReport
            // 
            this.btnDonatedReport.BackColor = System.Drawing.Color.Teal;
            this.btnDonatedReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonatedReport.ForeColor = System.Drawing.Color.White;
            this.btnDonatedReport.Location = new System.Drawing.Point(13, 461);
            this.btnDonatedReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonatedReport.Name = "btnDonatedReport";
            this.btnDonatedReport.Size = new System.Drawing.Size(208, 96);
            this.btnDonatedReport.TabIndex = 10;
            this.btnDonatedReport.Text = "Books Donated per Time Period";
            this.btnDonatedReport.UseVisualStyleBackColor = false;
            this.btnDonatedReport.Click += new System.EventHandler(this.btnDonatedReport_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 120);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(260, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1153, 571);
            this.panel2.TabIndex = 8;
            // 
            // dgvIssue
            // 
            this.dgvIssue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIssue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssue.Location = new System.Drawing.Point(777, 114);
            this.dgvIssue.Name = "dgvIssue";
            this.dgvIssue.RowHeadersWidth = 49;
            this.dgvIssue.RowTemplate.Height = 24;
            this.dgvIssue.Size = new System.Drawing.Size(698, 450);
            this.dgvIssue.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(743, 708);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reload Table";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1212, 247);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(743, 247);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 53);
            this.panel3.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 33);
            this.textBox1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btnIssued);
            this.groupBox1.Controls.Add(this.lblTotalIssued);
            this.groupBox1.Controls.Add(this.lblIssuedDateRange);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpStartDate);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.dgvIssue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1649, 765);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Issued";
            // 
            // btnIssued
            // 
            this.btnIssued.BackColor = System.Drawing.Color.Teal;
            this.btnIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssued.ForeColor = System.Drawing.Color.White;
            this.btnIssued.Location = new System.Drawing.Point(112, 370);
            this.btnIssued.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssued.Name = "btnIssued";
            this.btnIssued.Size = new System.Drawing.Size(434, 53);
            this.btnIssued.TabIndex = 15;
            this.btnIssued.Text = "Total Books Issued per Time Period";
            this.btnIssued.UseVisualStyleBackColor = false;
            this.btnIssued.Click += new System.EventHandler(this.btnIssued_Click);
            // 
            // lblTotalIssued
            // 
            this.lblTotalIssued.AutoSize = true;
            this.lblTotalIssued.BackColor = System.Drawing.Color.White;
            this.lblTotalIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIssued.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalIssued.Location = new System.Drawing.Point(94, 583);
            this.lblTotalIssued.Name = "lblTotalIssued";
            this.lblTotalIssued.Size = new System.Drawing.Size(70, 26);
            this.lblTotalIssued.TabIndex = 8;
            this.lblTotalIssued.Text = "label5";
            this.lblTotalIssued.Visible = false;
            // 
            // lblIssuedDateRange
            // 
            this.lblIssuedDateRange.AutoSize = true;
            this.lblIssuedDateRange.BackColor = System.Drawing.Color.White;
            this.lblIssuedDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedDateRange.ForeColor = System.Drawing.Color.Purple;
            this.lblIssuedDateRange.Location = new System.Drawing.Point(94, 525);
            this.lblIssuedDateRange.Name = "lblIssuedDateRange";
            this.lblIssuedDateRange.Size = new System.Drawing.Size(288, 26);
            this.lblIssuedDateRange.TabIndex = 7;
            this.lblIssuedDateRange.Text = "uselabels to show summary ";
            this.lblIssuedDateRange.Visible = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Location = new System.Drawing.Point(122, 260);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(419, 33);
            this.dtpEndDate.TabIndex = 6;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Location = new System.Drawing.Point(122, 121);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(419, 33);
            this.dtpStartDate.TabIndex = 5;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(122, 221);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(109, 26);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "End Date:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(117, 79);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(124, 29);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Start Date:";
            // 
            // Issued
            // 
            this.Issued.Controls.Add(this.groupBox1);
            this.Issued.Location = new System.Drawing.Point(254, 228);
            this.Issued.Name = "Issued";
            this.Issued.Size = new System.Drawing.Size(1649, 765);
            this.Issued.TabIndex = 12;
            // 
            // Donated
            // 
            this.Donated.Controls.Add(this.groupBox2);
            this.Donated.Location = new System.Drawing.Point(254, 228);
            this.Donated.Name = "Donated";
            this.Donated.Size = new System.Drawing.Size(1649, 765);
            this.Donated.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnDonated);
            this.groupBox2.Controls.Add(this.lblTotalDonated);
            this.groupBox2.Controls.Add(this.lblDonatedDateRange);
            this.groupBox2.Controls.Add(this.dtpDonatedEnd);
            this.groupBox2.Controls.Add(this.dtpDonatedStart);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dgvDonate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1649, 765);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books Donated";
            // 
            // btnDonated
            // 
            this.btnDonated.BackColor = System.Drawing.Color.Teal;
            this.btnDonated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonated.ForeColor = System.Drawing.Color.White;
            this.btnDonated.Location = new System.Drawing.Point(112, 370);
            this.btnDonated.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonated.Name = "btnDonated";
            this.btnDonated.Size = new System.Drawing.Size(434, 53);
            this.btnDonated.TabIndex = 12;
            this.btnDonated.Text = "Total Books Donated per Time Period";
            this.btnDonated.UseVisualStyleBackColor = false;
            this.btnDonated.Click += new System.EventHandler(this.btnDonated_Click);
            // 
            // lblTotalDonated
            // 
            this.lblTotalDonated.AutoSize = true;
            this.lblTotalDonated.BackColor = System.Drawing.Color.White;
            this.lblTotalDonated.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDonated.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalDonated.Location = new System.Drawing.Point(94, 583);
            this.lblTotalDonated.Name = "lblTotalDonated";
            this.lblTotalDonated.Size = new System.Drawing.Size(70, 26);
            this.lblTotalDonated.TabIndex = 9;
            this.lblTotalDonated.Text = "label9";
            this.lblTotalDonated.Visible = false;
            // 
            // lblDonatedDateRange
            // 
            this.lblDonatedDateRange.AutoSize = true;
            this.lblDonatedDateRange.BackColor = System.Drawing.Color.White;
            this.lblDonatedDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonatedDateRange.ForeColor = System.Drawing.Color.Purple;
            this.lblDonatedDateRange.Location = new System.Drawing.Point(94, 525);
            this.lblDonatedDateRange.Name = "lblDonatedDateRange";
            this.lblDonatedDateRange.Size = new System.Drawing.Size(288, 26);
            this.lblDonatedDateRange.TabIndex = 7;
            this.lblDonatedDateRange.Text = "uselabels to show summary ";
            this.lblDonatedDateRange.Visible = false;
            // 
            // dtpDonatedEnd
            // 
            this.dtpDonatedEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDonatedEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDonatedEnd.Location = new System.Drawing.Point(127, 260);
            this.dtpDonatedEnd.Name = "dtpDonatedEnd";
            this.dtpDonatedEnd.Size = new System.Drawing.Size(419, 33);
            this.dtpDonatedEnd.TabIndex = 6;
            // 
            // dtpDonatedStart
            // 
            this.dtpDonatedStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDonatedStart.Location = new System.Drawing.Point(122, 121);
            this.dtpDonatedStart.Name = "dtpDonatedStart";
            this.dtpDonatedStart.Size = new System.Drawing.Size(419, 33);
            this.dtpDonatedStart.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(122, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 29);
            this.label12.TabIndex = 1;
            this.label12.Text = "End Date:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(117, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Start Date:";
            // 
            // dgvDonate
            // 
            this.dgvDonate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonate.Location = new System.Drawing.Point(777, 114);
            this.dgvDonate.Name = "dgvDonate";
            this.dgvDonate.RowHeadersWidth = 49;
            this.dgvDonate.RowTemplate.Height = 24;
            this.dgvDonate.Size = new System.Drawing.Size(698, 450);
            this.dgvDonate.TabIndex = 4;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 993);
            this.Controls.Add(this.Donated);
            this.Controls.Add(this.Issued);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonGraphic);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ButtonGraphic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Issued.ResumeLayout(false);
            this.Donated.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIssuedReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel ButtonGraphic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDonatedReport;
        private System.Windows.Forms.DataGridView dgvIssue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIssuedDateRange;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTotalIssued;
        private System.Windows.Forms.Panel Issued;
        private System.Windows.Forms.Panel Donated;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalDonated;
        private System.Windows.Forms.Label lblDonatedDateRange;
        private System.Windows.Forms.DateTimePicker dtpDonatedEnd;
        private System.Windows.Forms.DateTimePicker dtpDonatedStart;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvDonate;
        private System.Windows.Forms.Button btnDonated;
        private System.Windows.Forms.Button btnIssued;
    }
}