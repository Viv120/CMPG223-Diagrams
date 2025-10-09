
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
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminPass = new System.Windows.Forms.Label();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpDonor = new System.Windows.Forms.TabPage();
            this.btnRegisterDonor = new System.Windows.Forms.Button();
            this.txtDonorPass = new System.Windows.Forms.TextBox();
            this.txtDonorEmail = new System.Windows.Forms.TextBox();
            this.lblDonorPass = new System.Windows.Forms.Label();
            this.lblDonorEmail = new System.Windows.Forms.Label();
            this.btnLoginDonor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpApplicant = new System.Windows.Forms.TabPage();
            this.btnRegisterApp = new System.Windows.Forms.Button();
            this.txtAppPass = new System.Windows.Forms.TextBox();
            this.txtAppEmail = new System.Windows.Forms.TextBox();
            this.btnLoginApp = new System.Windows.Forms.Button();
            this.lblAppPass = new System.Windows.Forms.Label();
            this.lblAppEmail = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewPassApp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.tcLogin.Name = "tcLogin";
            this.tcLogin.SelectedIndex = 0;
            this.tcLogin.Size = new System.Drawing.Size(1556, 879);
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
            this.tbAdmin.Location = new System.Drawing.Point(4, 41);
            this.tbAdmin.Name = "tbAdmin";
            this.tbAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tbAdmin.Size = new System.Drawing.Size(1548, 834);
            this.tbAdmin.TabIndex = 0;
            this.tbAdmin.Text = "Admin Login";
            this.tbAdmin.UseVisualStyleBackColor = true;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(670, 787);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '*';
            this.txtAdminPass.Size = new System.Drawing.Size(258, 30);
            this.txtAdminPass.TabIndex = 13;
            // 
            // txtAdminEmail
            // 
            this.txtAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminEmail.Location = new System.Drawing.Point(670, 740);
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Size = new System.Drawing.Size(258, 30);
            this.txtAdminEmail.TabIndex = 14;
            // 
            // lblAdminPass
            // 
            this.lblAdminPass.AutoSize = true;
            this.lblAdminPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminPass.Location = new System.Drawing.Point(514, 790);
            this.lblAdminPass.Name = "lblAdminPass";
            this.lblAdminPass.Size = new System.Drawing.Size(120, 29);
            this.lblAdminPass.TabIndex = 12;
            this.lblAdminPass.Text = "Password";
            // 
            // lblAdminEmail
            // 
            this.lblAdminEmail.AutoSize = true;
            this.lblAdminEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminEmail.Location = new System.Drawing.Point(514, 740);
            this.lblAdminEmail.Name = "lblAdminEmail";
            this.lblAdminEmail.Size = new System.Drawing.Size(74, 29);
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
            this.btnLoginAdmin.Location = new System.Drawing.Point(1117, 758);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(130, 39);
            this.btnLoginAdmin.TabIndex = 9;
            this.btnLoginAdmin.Text = "Login";
            this.btnLoginAdmin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1554, 832);
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
            this.tpDonor.Location = new System.Drawing.Point(4, 41);
            this.tpDonor.Name = "tpDonor";
            this.tpDonor.Padding = new System.Windows.Forms.Padding(3);
            this.tpDonor.Size = new System.Drawing.Size(1548, 834);
            this.tpDonor.TabIndex = 1;
            this.tpDonor.Text = "Donor Login";
            this.tpDonor.UseVisualStyleBackColor = true;
            // 
            // btnRegisterDonor
            // 
            this.btnRegisterDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterDonor.Location = new System.Drawing.Point(1104, 780);
            this.btnRegisterDonor.Name = "btnRegisterDonor";
            this.btnRegisterDonor.Size = new System.Drawing.Size(130, 39);
            this.btnRegisterDonor.TabIndex = 16;
            this.btnRegisterDonor.Text = "Register";
            this.btnRegisterDonor.UseVisualStyleBackColor = true;
            // 
            // txtDonorPass
            // 
            this.txtDonorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorPass.Location = new System.Drawing.Point(670, 787);
            this.txtDonorPass.Name = "txtDonorPass";
            this.txtDonorPass.PasswordChar = '*';
            this.txtDonorPass.Size = new System.Drawing.Size(258, 30);
            this.txtDonorPass.TabIndex = 14;
            // 
            // txtDonorEmail
            // 
            this.txtDonorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonorEmail.Location = new System.Drawing.Point(670, 740);
            this.txtDonorEmail.Name = "txtDonorEmail";
            this.txtDonorEmail.Size = new System.Drawing.Size(258, 30);
            this.txtDonorEmail.TabIndex = 15;
            // 
            // lblDonorPass
            // 
            this.lblDonorPass.AutoSize = true;
            this.lblDonorPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDonorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonorPass.Location = new System.Drawing.Point(514, 790);
            this.lblDonorPass.Name = "lblDonorPass";
            this.lblDonorPass.Size = new System.Drawing.Size(120, 29);
            this.lblDonorPass.TabIndex = 13;
            this.lblDonorPass.Text = "Password";
            // 
            // lblDonorEmail
            // 
            this.lblDonorEmail.AutoSize = true;
            this.lblDonorEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDonorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonorEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDonorEmail.Location = new System.Drawing.Point(514, 740);
            this.lblDonorEmail.Name = "lblDonorEmail";
            this.lblDonorEmail.Size = new System.Drawing.Size(74, 29);
            this.lblDonorEmail.TabIndex = 12;
            this.lblDonorEmail.Text = "Email";
            // 
            // btnLoginDonor
            // 
            this.btnLoginDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDonor.Location = new System.Drawing.Point(1104, 733);
            this.btnLoginDonor.Name = "btnLoginDonor";
            this.btnLoginDonor.Size = new System.Drawing.Size(130, 39);
            this.btnLoginDonor.TabIndex = 10;
            this.btnLoginDonor.Text = "Login";
            this.btnLoginDonor.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1554, 832);
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
            this.tpApplicant.Location = new System.Drawing.Point(4, 41);
            this.tpApplicant.Name = "tpApplicant";
            this.tpApplicant.Size = new System.Drawing.Size(1548, 834);
            this.tpApplicant.TabIndex = 2;
            this.tpApplicant.Text = "Applicant Login";
            this.tpApplicant.UseVisualStyleBackColor = true;
            // 
            // btnRegisterApp
            // 
            this.btnRegisterApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterApp.Location = new System.Drawing.Point(1104, 780);
            this.btnRegisterApp.Name = "btnRegisterApp";
            this.btnRegisterApp.Size = new System.Drawing.Size(130, 39);
            this.btnRegisterApp.TabIndex = 17;
            this.btnRegisterApp.Text = "Register";
            this.btnRegisterApp.UseVisualStyleBackColor = true;
            // 
            // txtAppPass
            // 
            this.txtAppPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppPass.Location = new System.Drawing.Point(670, 786);
            this.txtAppPass.Name = "txtAppPass";
            this.txtAppPass.PasswordChar = '*';
            this.txtAppPass.Size = new System.Drawing.Size(258, 30);
            this.txtAppPass.TabIndex = 6;
            // 
            // txtAppEmail
            // 
            this.txtAppEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppEmail.Location = new System.Drawing.Point(670, 739);
            this.txtAppEmail.Name = "txtAppEmail";
            this.txtAppEmail.Size = new System.Drawing.Size(258, 30);
            this.txtAppEmail.TabIndex = 7;
            // 
            // btnLoginApp
            // 
            this.btnLoginApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginApp.Location = new System.Drawing.Point(1104, 733);
            this.btnLoginApp.Name = "btnLoginApp";
            this.btnLoginApp.Size = new System.Drawing.Size(130, 39);
            this.btnLoginApp.TabIndex = 9;
            this.btnLoginApp.Text = "Login";
            this.btnLoginApp.UseVisualStyleBackColor = true;
            // 
            // lblAppPass
            // 
            this.lblAppPass.AutoSize = true;
            this.lblAppPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppPass.Location = new System.Drawing.Point(514, 789);
            this.lblAppPass.Name = "lblAppPass";
            this.lblAppPass.Size = new System.Drawing.Size(120, 29);
            this.lblAppPass.TabIndex = 5;
            this.lblAppPass.Text = "Password";
            // 
            // lblAppEmail
            // 
            this.lblAppEmail.AutoSize = true;
            this.lblAppEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppEmail.Location = new System.Drawing.Point(514, 740);
            this.lblAppEmail.Name = "lblAppEmail";
            this.lblAppEmail.Size = new System.Drawing.Size(74, 29);
            this.lblAppEmail.TabIndex = 4;
            this.lblAppEmail.Text = "Email";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(24, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1548, 832);
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
            // btnNewPassApp
            // 
            this.btnNewPassApp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewPassApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassApp.Location = new System.Drawing.Point(1297, 733);
            this.btnNewPassApp.Name = "btnNewPassApp";
            this.btnNewPassApp.Size = new System.Drawing.Size(130, 86);
            this.btnNewPassApp.TabIndex = 18;
            this.btnNewPassApp.Text = "Reset Password";
            this.btnNewPassApp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1297, 733);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 86);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset Password";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1297, 733);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 86);
            this.button4.TabIndex = 19;
            this.button4.Text = "Reset Password";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 881);
            this.Controls.Add(this.tcLogin);
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