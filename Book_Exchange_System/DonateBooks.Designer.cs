
namespace Book_Exchange_System
{
    partial class DonateBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonateBooks));
            this.ButtonGraphics = new System.Windows.Forms.Panel();
            this.btnDonate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.TopGraphic = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.UpdateDonor = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtDonorID = new System.Windows.Forms.TextBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.dgvCurrentApp = new System.Windows.Forms.DataGridView();
            this.rdoPotch = new System.Windows.Forms.RadioButton();
            this.rdoMahikeng = new System.Windows.Forms.RadioButton();
            this.rdoVaal = new System.Windows.Forms.RadioButton();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtNewAName = new System.Windows.Forms.TextBox();
            this.txtNewSP_Number = new System.Windows.Forms.TextBox();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewSP_Number = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Donate = new System.Windows.Forms.Panel();
            this.gbDonate = new System.Windows.Forms.GroupBox();
            this.lblDonated = new System.Windows.Forms.Label();
            this.dgvDonate = new System.Windows.Forms.DataGridView();
            this.btnDonateBooks = new System.Windows.Forms.Button();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.txtASurname = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthorF = new System.Windows.Forms.Label();
            this.lblAuthorL = new System.Windows.Forms.Label();
            this.nudCondition = new System.Windows.Forms.NumericUpDown();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ButtonGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopGraphic.SuspendLayout();
            this.UpdateDonor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentApp)).BeginInit();
            this.Donate.SuspendLayout();
            this.gbDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCondition)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonGraphics
            // 
            this.ButtonGraphics.BackColor = System.Drawing.Color.Green;
            this.ButtonGraphics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGraphics.BackgroundImage")));
            this.ButtonGraphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonGraphics.Controls.Add(this.btnDonate);
            this.ButtonGraphics.Controls.Add(this.btnBack);
            this.ButtonGraphics.Controls.Add(this.groupBox1);
            this.ButtonGraphics.Controls.Add(this.pictureBox1);
            this.ButtonGraphics.Controls.Add(this.btnUpdateDonor);
            this.ButtonGraphics.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonGraphics.Location = new System.Drawing.Point(0, 0);
            this.ButtonGraphics.Name = "ButtonGraphics";
            this.ButtonGraphics.Size = new System.Drawing.Size(190, 807);
            this.ButtonGraphics.TabIndex = 32;
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.Teal;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.White;
            this.btnDonate.Location = new System.Drawing.Point(12, 358);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(156, 60);
            this.btnDonate.TabIndex = 6;
            this.btnDonate.Text = "Donate Books";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 495);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 60);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(188, 182);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(893, 630);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Applicants";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.BackColor = System.Drawing.Color.Teal;
            this.btnUpdateDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDonor.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDonor.Location = new System.Drawing.Point(12, 248);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(156, 60);
            this.btnUpdateDonor.TabIndex = 1;
            this.btnUpdateDonor.Text = "Update Information";
            this.btnUpdateDonor.UseVisualStyleBackColor = false;
            this.btnUpdateDonor.Click += new System.EventHandler(this.btnUpdateDonor_Click);
            // 
            // TopGraphic
            // 
            this.TopGraphic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopGraphic.BackgroundImage")));
            this.TopGraphic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopGraphic.Controls.Add(this.label2);
            this.TopGraphic.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopGraphic.Location = new System.Drawing.Point(190, 0);
            this.TopGraphic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopGraphic.Name = "TopGraphic";
            this.TopGraphic.Size = new System.Drawing.Size(1236, 177);
            this.TopGraphic.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.31305F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(574, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Donor";
            // 
            // UpdateDonor
            // 
            this.UpdateDonor.Controls.Add(this.groupBox2);
            this.UpdateDonor.Location = new System.Drawing.Point(190, 179);
            this.UpdateDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateDonor.Name = "UpdateDonor";
            this.UpdateDonor.Size = new System.Drawing.Size(1237, 628);
            this.UpdateDonor.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNewEmail);
            this.groupBox2.Controls.Add(this.lblNewEmail);
            this.groupBox2.Controls.Add(this.txtDonorID);
            this.groupBox2.Controls.Add(this.lblCampus);
            this.groupBox2.Controls.Add(this.dgvCurrentApp);
            this.groupBox2.Controls.Add(this.rdoPotch);
            this.groupBox2.Controls.Add(this.rdoMahikeng);
            this.groupBox2.Controls.Add(this.rdoVaal);
            this.groupBox2.Controls.Add(this.lblBookID);
            this.groupBox2.Controls.Add(this.txtNewAName);
            this.groupBox2.Controls.Add(this.txtNewSP_Number);
            this.groupBox2.Controls.Add(this.lblNewName);
            this.groupBox2.Controls.Add(this.lblNewSP_Number);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1237, 628);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Donors";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNewEmail.Location = new System.Drawing.Point(15, 327);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(227, 28);
            this.txtNewEmail.TabIndex = 48;
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.AutoSize = true;
            this.lblNewEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewEmail.Location = new System.Drawing.Point(14, 300);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(62, 24);
            this.lblNewEmail.TabIndex = 47;
            this.lblNewEmail.Text = "Email:";
            // 
            // txtDonorID
            // 
            this.txtDonorID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDonorID.Location = new System.Drawing.Point(15, 93);
            this.txtDonorID.Name = "txtDonorID";
            this.txtDonorID.ReadOnly = true;
            this.txtDonorID.Size = new System.Drawing.Size(93, 28);
            this.txtDonorID.TabIndex = 44;
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCampus.Location = new System.Drawing.Point(14, 401);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(225, 24);
            this.lblCampus.TabIndex = 22;
            this.lblCampus.Text = "Move to different campus:";
            // 
            // dgvCurrentApp
            // 
            this.dgvCurrentApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentApp.Location = new System.Drawing.Point(472, 143);
            this.dgvCurrentApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCurrentApp.Name = "dgvCurrentApp";
            this.dgvCurrentApp.RowHeadersWidth = 51;
            this.dgvCurrentApp.RowTemplate.Height = 24;
            this.dgvCurrentApp.Size = new System.Drawing.Size(765, 227);
            this.dgvCurrentApp.TabIndex = 43;
            // 
            // rdoPotch
            // 
            this.rdoPotch.AutoSize = true;
            this.rdoPotch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPotch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoPotch.Location = new System.Drawing.Point(17, 439);
            this.rdoPotch.Name = "rdoPotch";
            this.rdoPotch.Size = new System.Drawing.Size(188, 21);
            this.rdoPotch.TabIndex = 23;
            this.rdoPotch.TabStop = true;
            this.rdoPotch.Text = "1: Potchefstroom Campus";
            this.rdoPotch.UseVisualStyleBackColor = true;
            // 
            // rdoMahikeng
            // 
            this.rdoMahikeng.AutoSize = true;
            this.rdoMahikeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMahikeng.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoMahikeng.Location = new System.Drawing.Point(17, 465);
            this.rdoMahikeng.Name = "rdoMahikeng";
            this.rdoMahikeng.Size = new System.Drawing.Size(158, 21);
            this.rdoMahikeng.TabIndex = 25;
            this.rdoMahikeng.TabStop = true;
            this.rdoMahikeng.Text = "2: Mahikeng Campus";
            this.rdoMahikeng.UseVisualStyleBackColor = true;
            // 
            // rdoVaal
            // 
            this.rdoVaal.AutoSize = true;
            this.rdoVaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVaal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoVaal.Location = new System.Drawing.Point(17, 491);
            this.rdoVaal.Name = "rdoVaal";
            this.rdoVaal.Size = new System.Drawing.Size(125, 21);
            this.rdoVaal.TabIndex = 24;
            this.rdoVaal.TabStop = true;
            this.rdoVaal.Text = "3: Vaal Campus";
            this.rdoVaal.UseVisualStyleBackColor = true;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookID.Location = new System.Drawing.Point(14, 66);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(89, 24);
            this.lblBookID.TabIndex = 40;
            this.lblBookID.Text = "Donor ID:";
            // 
            // txtNewAName
            // 
            this.txtNewAName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNewAName.Location = new System.Drawing.Point(15, 176);
            this.txtNewAName.Name = "txtNewAName";
            this.txtNewAName.Size = new System.Drawing.Size(227, 28);
            this.txtNewAName.TabIndex = 38;
            // 
            // txtNewSP_Number
            // 
            this.txtNewSP_Number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNewSP_Number.Location = new System.Drawing.Point(15, 254);
            this.txtNewSP_Number.Name = "txtNewSP_Number";
            this.txtNewSP_Number.Size = new System.Drawing.Size(227, 28);
            this.txtNewSP_Number.TabIndex = 34;
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewName.Location = new System.Drawing.Point(14, 150);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(246, 24);
            this.lblNewName.TabIndex = 33;
            this.lblNewName.Text = "Student/Organization Name:";
            // 
            // lblNewSP_Number
            // 
            this.lblNewSP_Number.AutoSize = true;
            this.lblNewSP_Number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewSP_Number.Location = new System.Drawing.Point(14, 228);
            this.lblNewSP_Number.Name = "lblNewSP_Number";
            this.lblNewSP_Number.Size = new System.Drawing.Size(214, 24);
            this.lblNewSP_Number.TabIndex = 28;
            this.lblNewSP_Number.Text = "Student/Phone Number:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(201, 539);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Donate
            // 
            this.Donate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Donate.Controls.Add(this.gbDonate);
            this.Donate.Location = new System.Drawing.Point(190, 179);
            this.Donate.Name = "Donate";
            this.Donate.Size = new System.Drawing.Size(1237, 628);
            this.Donate.TabIndex = 35;
            // 
            // gbDonate
            // 
            this.gbDonate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbDonate.BackColor = System.Drawing.SystemColors.Control;
            this.gbDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDonate.Controls.Add(this.lblDonated);
            this.gbDonate.Controls.Add(this.dgvDonate);
            this.gbDonate.Controls.Add(this.btnDonateBooks);
            this.gbDonate.Controls.Add(this.txtAName);
            this.gbDonate.Controls.Add(this.txtASurname);
            this.gbDonate.Controls.Add(this.txtEdition);
            this.gbDonate.Controls.Add(this.txtYear);
            this.gbDonate.Controls.Add(this.txtTitle);
            this.gbDonate.Controls.Add(this.lblAuthorF);
            this.gbDonate.Controls.Add(this.lblAuthorL);
            this.gbDonate.Controls.Add(this.nudCondition);
            this.gbDonate.Controls.Add(this.lblEdition);
            this.gbDonate.Controls.Add(this.lblYear);
            this.gbDonate.Controls.Add(this.lblCondition);
            this.gbDonate.Controls.Add(this.lblTitle);
            this.gbDonate.Controls.Add(this.btnAdd);
            this.gbDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDonate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbDonate.Location = new System.Drawing.Point(0, 0);
            this.gbDonate.Name = "gbDonate";
            this.gbDonate.Size = new System.Drawing.Size(1237, 628);
            this.gbDonate.TabIndex = 0;
            this.gbDonate.TabStop = false;
            this.gbDonate.Text = "Donate Books";
            // 
            // lblDonated
            // 
            this.lblDonated.AutoSize = true;
            this.lblDonated.BackColor = System.Drawing.SystemColors.Control;
            this.lblDonated.ForeColor = System.Drawing.Color.Black;
            this.lblDonated.Location = new System.Drawing.Point(370, 26);
            this.lblDonated.Name = "lblDonated";
            this.lblDonated.Size = new System.Drawing.Size(124, 20);
            this.lblDonated.TabIndex = 22;
            this.lblDonated.Text = "Books Donated:";
            // 
            // dgvDonate
            // 
            this.dgvDonate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonate.Location = new System.Drawing.Point(374, 68);
            this.dgvDonate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDonate.Name = "dgvDonate";
            this.dgvDonate.RowHeadersWidth = 51;
            this.dgvDonate.RowTemplate.Height = 24;
            this.dgvDonate.Size = new System.Drawing.Size(750, 232);
            this.dgvDonate.TabIndex = 21;
            // 
            // btnDonateBooks
            // 
            this.btnDonateBooks.BackColor = System.Drawing.Color.Teal;
            this.btnDonateBooks.ForeColor = System.Drawing.Color.White;
            this.btnDonateBooks.Location = new System.Drawing.Point(536, 540);
            this.btnDonateBooks.Name = "btnDonateBooks";
            this.btnDonateBooks.Size = new System.Drawing.Size(235, 43);
            this.btnDonateBooks.TabIndex = 20;
            this.btnDonateBooks.Text = "Donate Books";
            this.btnDonateBooks.UseVisualStyleBackColor = false;
            this.btnDonateBooks.Click += new System.EventHandler(this.btnDonateBooks_Click);
            // 
            // txtAName
            // 
            this.txtAName.Location = new System.Drawing.Point(7, 164);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(227, 26);
            this.txtAName.TabIndex = 17;
            // 
            // txtASurname
            // 
            this.txtASurname.BackColor = System.Drawing.Color.White;
            this.txtASurname.Location = new System.Drawing.Point(6, 240);
            this.txtASurname.Name = "txtASurname";
            this.txtASurname.Size = new System.Drawing.Size(227, 26);
            this.txtASurname.TabIndex = 16;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(6, 314);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(100, 26);
            this.txtEdition.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(7, 405);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            this.txtYear.TabIndex = 14;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 81);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(227, 26);
            this.txtTitle.TabIndex = 12;
            // 
            // lblAuthorF
            // 
            this.lblAuthorF.AutoSize = true;
            this.lblAuthorF.BackColor = System.Drawing.SystemColors.Control;
            this.lblAuthorF.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorF.Location = new System.Drawing.Point(6, 127);
            this.lblAuthorF.Name = "lblAuthorF";
            this.lblAuthorF.Size = new System.Drawing.Size(107, 20);
            this.lblAuthorF.TabIndex = 11;
            this.lblAuthorF.Text = "Author Name:";
            // 
            // lblAuthorL
            // 
            this.lblAuthorL.AutoSize = true;
            this.lblAuthorL.BackColor = System.Drawing.SystemColors.Control;
            this.lblAuthorL.ForeColor = System.Drawing.Color.Black;
            this.lblAuthorL.Location = new System.Drawing.Point(5, 203);
            this.lblAuthorL.Name = "lblAuthorL";
            this.lblAuthorL.Size = new System.Drawing.Size(130, 20);
            this.lblAuthorL.TabIndex = 10;
            this.lblAuthorL.Text = "Author Surname:";
            // 
            // nudCondition
            // 
            this.nudCondition.Location = new System.Drawing.Point(8, 489);
            this.nudCondition.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCondition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCondition.Name = "nudCondition";
            this.nudCondition.Size = new System.Drawing.Size(71, 26);
            this.nudCondition.TabIndex = 19;
            this.nudCondition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEdition.Location = new System.Drawing.Point(5, 280);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(62, 20);
            this.lblEdition.TabIndex = 9;
            this.lblEdition.Text = "Edition:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.SystemColors.Control;
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(3, 373);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(120, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Published Year:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.SystemColors.Control;
            this.lblCondition.ForeColor = System.Drawing.Color.Black;
            this.lblCondition.Location = new System.Drawing.Point(4, 457);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(117, 20);
            this.lblCondition.TabIndex = 7;
            this.lblCondition.Text = "Book Condition";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(9, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(142, 542);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(235, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DonateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 807);
            this.Controls.Add(this.UpdateDonor);
            this.Controls.Add(this.Donate);
            this.Controls.Add(this.TopGraphic);
            this.Controls.Add(this.ButtonGraphics);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DonateBooks";
            this.Text = "DonateBooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ButtonGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopGraphic.ResumeLayout(false);
            this.TopGraphic.PerformLayout();
            this.UpdateDonor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentApp)).EndInit();
            this.Donate.ResumeLayout(false);
            this.gbDonate.ResumeLayout(false);
            this.gbDonate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCondition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ButtonGraphics;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Panel TopGraphic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel UpdateDonor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.RadioButton rdoPotch;
        private System.Windows.Forms.RadioButton rdoMahikeng;
        private System.Windows.Forms.RadioButton rdoVaal;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtNewAName;
        private System.Windows.Forms.TextBox txtNewSP_Number;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewSP_Number;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCurrentApp;
        private System.Windows.Forms.TextBox txtDonorID;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.Panel Donate;
        private System.Windows.Forms.GroupBox gbDonate;
        private System.Windows.Forms.Label lblDonated;
        private System.Windows.Forms.DataGridView dgvDonate;
        private System.Windows.Forms.Button btnDonateBooks;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.TextBox txtASurname;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthorF;
        private System.Windows.Forms.Label lblAuthorL;
        private System.Windows.Forms.NumericUpDown nudCondition;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
    }
}