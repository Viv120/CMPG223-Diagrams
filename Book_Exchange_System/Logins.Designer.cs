
namespace Book_Exchange_System
{
    partial class Logins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logins));
            this.tcLogin = new System.Windows.Forms.TabControl();
            this.tbAdmin = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpDonor = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegisterDonor = new System.Windows.Forms.Button();
            this.txtDonorPass = new System.Windows.Forms.TextBox();
            this.txtDonorEmail = new System.Windows.Forms.TextBox();
            this.lblDonorPass = new System.Windows.Forms.Label();
            this.lblDonorEmail = new System.Windows.Forms.Label();
            this.btnLoginDonor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpApplicant = new System.Windows.Forms.TabPage();
            this.btnNewPassApp = new System.Windows.Forms.Button();
            this.btnRegisterApp = new System.Windows.Forms.Button();
            this.txtAppPass = new System.Windows.Forms.TextBox();
            this.txtAppEmail = new System.Windows.Forms.TextBox();
            this.btnLoginApp = new System.Windows.Forms.Button();
            this.lblAppPass = new System.Windows.Forms.Label();
            this.lblAppEmail = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tcLogin.SuspendLayout();
            this.tbAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpDonor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tpApplicant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tcLogin
            // 
            this.tcLogin.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcLogin.Controls.Add(this.tbAdmin);
            this.tcLogin.Controls.Add(this.tpDonor);
            this.tcLogin.Controls.Add(this.tpApplicant);
            this.tcLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcLogin.Location = new System.Drawing.Point(1, 2);
            this.tcLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(1167, 714);
            this.tcLogin.TabIndex = 0;
            // 
            // tbAdmin
            // 
            this.tbAdmin.Controls.Add(this.button4);
            this.tbAdmin.Controls.Add(this.txtAdminPass);
            this.tbAdmin.Controls.Add(this.txtAdminEmail);
            this.tbAdmin.Controls.Add(this.lblAdminPass);
            this.tbAdmin.Controls.Add(this.lblAdminEmail);
            this.tbAdmin.Controls.Add(this.btnLoginAdmin);
            this.tbAdmin.Controls.Add(this.pictureBox1);
            this.tbAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.tbAdmin.Location = new System.Drawing.Point(4, 37);
            this.tbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbAdmin.Size = new System.Drawing.Size(1159, 673);
            this.tbAdmin.TabIndex = 0;
            this.tbAdmin.Text = "Admin Login";
            this.tbAdmin.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(973, 596);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 70);
            this.button4.TabIndex = 19;
            this.button4.Text = "Reset Password";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(502, 639);
            this.txtAdminPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.Size = new System.Drawing.Size(194, 25);
            this.txtAdminPass.TabIndex = 13;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminEmail.Location = new System.Drawing.Point(502, 601);
            this.txtAdminEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(194, 25);
            this.txtAdminEmail.TabIndex = 14;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminPass.Location = new System.Drawing.Point(386, 642);
            this.lblAdminPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(92, 24);
            this.lblAdminPass.TabIndex = 12;
            this.lblAdminPass.Text = "Password";
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminEmail.Location = new System.Drawing.Point(386, 601);
            this.lblAdminEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(57, 24);
            this.lblAdminEmail.TabIndex = 11;
            this.lblAdminEmail.Text = "Email";
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnLoginAdmin.Location = new System.Drawing.Point(838, 616);
            this.btnLoginAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(98, 32);
            this.btnLoginAdmin.TabIndex = 9;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1166, 676);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tpDonor
            // 
            this.tpDonor.Controls.Add(this.button2);
            this.tpDonor.Controls.Add(this.btnRegisterDonor);
            this.tpDonor.Controls.Add(this.txtDonorPass);
            this.tpDonor.Controls.Add(this.txtDonorEmail);
            this.tpDonor.Controls.Add(this.lblDonorPass);
            this.tpDonor.Controls.Add(this.lblDonorEmail);
            this.tpDonor.Controls.Add(this.btnLoginDonor);
            this.tpDonor.Controls.Add(this.pictureBox2);
            this.tpDonor.Location = new System.Drawing.Point(4, 37);
            this.tpDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDonor.Name = "tpDonor";
            this.tpDonor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDonor.Size = new System.Drawing.Size(1159, 673);
            this.tpDonor.TabIndex = 1;
            this.tpDonor.Text = "Donor Login";
            this.tpDonor.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(973, 596);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 70);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegisterDonor
            // 
            this.btnRegisterDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterDonor.Location = new System.Drawing.Point(828, 634);
            this.btnRegisterDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegisterDonor.Name = "btnRegisterDonor";
            this.btnRegisterDonor.Size = new System.Drawing.Size(98, 32);
            this.btnRegisterDonor.TabIndex = 16;
            this.btnRegisterDonor.Text = "Register";
            this.btnRegisterDonor.UseVisualStyleBackColor = true;
            this.btnRegisterDonor.Click += new System.EventHandler(this.btnRegisterDonor_Click);
            // 
            // txtDonorPass
            // 
            this.txtDonorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorPass.Location = new System.Drawing.Point(502, 639);
            this.txtDonorPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonorPass.Name = "txtDonorPass";
            this.txtDonorPass.PasswordChar = '*';
            this.txtDonorPass.Size = new System.Drawing.Size(194, 25);
            this.txtDonorPass.TabIndex = 14;
            // 
            // txtDonorEmail
            // 
            this.txtDonorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorEmail.Location = new System.Drawing.Point(502, 601);
            this.txtDonorEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonorEmail.Name = "txtDonorEmail";
            this.txtDonorEmail.Size = new System.Drawing.Size(194, 25);
            this.txtDonorEmail.TabIndex = 15;
            // 
            // lblDonorPass
            // 
            this.lblDonorPass.AutoSize = true;
            this.lblDonorPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDonorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonorPass.Location = new System.Drawing.Point(386, 642);
            this.lblDonorPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonorPass.Name = "lblDonorPass";
            this.lblDonorPass.Size = new System.Drawing.Size(92, 24);
            this.lblDonorPass.TabIndex = 13;
            this.lblDonorPass.Text = "Password";
            // 
            // lblDonorEmail
            // 
            this.lblDonorEmail.AutoSize = true;
            this.lblDonorEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDonorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonorEmail.Location = new System.Drawing.Point(386, 601);
            this.lblDonorEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonorEmail.Name = "lblDonorEmail";
            this.lblDonorEmail.Size = new System.Drawing.Size(57, 24);
            this.lblDonorEmail.TabIndex = 12;
            this.lblDonorEmail.Text = "Email";
            // 
            // btnLoginDonor
            // 
            this.btnLoginDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDonor.Location = new System.Drawing.Point(828, 596);
            this.btnLoginDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginDonor.Name = "btnLoginDonor";
            this.btnLoginDonor.Size = new System.Drawing.Size(98, 32);
            this.btnLoginDonor.TabIndex = 10;
            this.btnLoginDonor.Text = "Login";
            this.btnLoginDonor.UseVisualStyleBackColor = true;
            this.btnLoginDonor.Click += new System.EventHandler(this.btnLoginDonor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1166, 676);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tpApplicant
            // 
            this.tpApplicant.Controls.Add(this.btnNewPassApp);
            this.tpApplicant.Controls.Add(this.btnRegisterApp);
            this.tpApplicant.Controls.Add(this.txtAppPass);
            this.tpApplicant.Controls.Add(this.txtAppEmail);
            this.tpApplicant.Controls.Add(this.btnLoginApp);
            this.tpApplicant.Controls.Add(this.lblAppPass);
            this.tpApplicant.Controls.Add(this.lblAppEmail);
            this.tpApplicant.Controls.Add(this.pictureBox3);
            this.tpApplicant.Location = new System.Drawing.Point(4, 37);
            this.tpApplicant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpApplicant.Name = "tpApplicant";
            this.tpApplicant.Size = new System.Drawing.Size(1159, 673);
            this.tpApplicant.TabIndex = 2;
            this.tpApplicant.Text = "Applicant Login";
            this.tpApplicant.UseVisualStyleBackColor = true;
            // 
            // btnNewPassApp
            // 
            this.btnNewPassApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPassApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassApp.Location = new System.Drawing.Point(973, 596);
            this.btnNewPassApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewPassApp.Name = "btnNewPassApp";
            this.btnNewPassApp.Size = new System.Drawing.Size(98, 70);
            this.btnNewPassApp.TabIndex = 18;
            this.btnNewPassApp.Text = "Reset Password";
            this.btnNewPassApp.UseVisualStyleBackColor = true;
            this.btnNewPassApp.Click += new System.EventHandler(this.btnNewPassApp_Click);
            // 
            // btnRegisterApp
            // 
            this.btnRegisterApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterApp.Location = new System.Drawing.Point(828, 634);
            this.btnRegisterApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegisterApp.Name = "btnRegisterApp";
            this.btnRegisterApp.Size = new System.Drawing.Size(98, 32);
            this.btnRegisterApp.TabIndex = 17;
            this.btnRegisterApp.Text = "Register";
            this.btnRegisterApp.UseVisualStyleBackColor = true;
            this.btnRegisterApp.Click += new System.EventHandler(this.btnRegisterApp_Click);
            // 
            // txtAppPass
            // 
            this.txtAppPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPass.Location = new System.Drawing.Point(502, 639);
            this.txtAppPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAppPass.Name = "txtAppPass";
            this.txtAppPass.PasswordChar = '*';
            this.txtAppPass.Size = new System.Drawing.Size(194, 25);
            this.txtAppPass.TabIndex = 6;
            // 
            // txtAppEmail
            // 
            this.txtAppEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppEmail.Location = new System.Drawing.Point(502, 600);
            this.txtAppEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAppEmail.Name = "txtAppEmail";
            this.txtAppEmail.Size = new System.Drawing.Size(194, 25);
            this.txtAppEmail.TabIndex = 7;
            // 
            // btnLoginApp
            // 
            this.btnLoginApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginApp.Location = new System.Drawing.Point(828, 596);
            this.btnLoginApp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoginApp.Name = "btnLoginApp";
            this.btnLoginApp.Size = new System.Drawing.Size(98, 32);
            this.btnLoginApp.TabIndex = 9;
            this.btnLoginApp.Text = "Login";
            this.btnLoginApp.UseVisualStyleBackColor = true;
            this.btnLoginApp.Click += new System.EventHandler(this.btnLoginApp_Click);
            // 
            // lblAppPass
            // 
            this.lblAppPass.AutoSize = true;
            this.lblAppPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppPass.Location = new System.Drawing.Point(386, 641);
            this.lblAppPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppPass.Name = "lblAppPass";
            this.lblAppPass.Size = new System.Drawing.Size(92, 24);
            this.lblAppPass.TabIndex = 5;
            this.lblAppPass.Text = "Password";
            // 
            // lblAppEmail
            // 
            this.lblAppEmail.AutoSize = true;
            this.lblAppEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppEmail.Location = new System.Drawing.Point(386, 601);
            this.lblAppEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppEmail.Name = "lblAppEmail";
            this.lblAppEmail.Size = new System.Drawing.Size(57, 24);
            this.lblAppEmail.TabIndex = 4;
            this.lblAppEmail.Text = "Email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(18, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1161, 676);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1117, 740);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1305, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 716);
            this.Controls.Add(this.tcLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Logins";
            this.Text = "Logins";
            this.tcLogin.ResumeLayout(false);
            this.tbAdmin.ResumeLayout(false);
            this.tbAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpDonor.ResumeLayout(false);
            this.tpDonor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tpApplicant.ResumeLayout(false);
            this.tpApplicant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLogin;
        private System.Windows.Forms.TabPage tbAdmin;
        private System.Windows.Forms.TabPage tpDonor;
        private System.Windows.Forms.TabPage tpApplicant;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnLoginDonor;
        private System.Windows.Forms.Button btnLoginApp;
        private System.Windows.Forms.TextBox txtAppPass;
        private System.Windows.Forms.TextBox txtAppEmail;
        private System.Windows.Forms.Label lblAppPass;
        private System.Windows.Forms.Label lblAppEmail;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label lblAdminPass;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.TextBox txtDonorPass;
        private System.Windows.Forms.TextBox txtDonorEmail;
        private System.Windows.Forms.Label lblDonorPass;
        private System.Windows.Forms.Label lblDonorEmail;
        private System.Windows.Forms.Button btnRegisterDonor;
        private System.Windows.Forms.Button btnRegisterApp;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewPassApp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}