﻿namespace Le_Sa
{
    partial class formLoadingScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlLoadingBack = new System.Windows.Forms.Panel();
            this.pnlLoadingFront = new System.Windows.Forms.Panel();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.custRoundedPanel1 = new Le_Sa.CustRoundedPanel();
            this.crBtnVisibility = new Le_Sa.CustRoundedButton();
            this.cTBUsername = new Le_Sa.CustomControls.CustomTextBox();
            this.cTBPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.crPBDP = new Le_Sa.CustRoundedPictureBox();
            this.crBtnContinue = new Le_Sa.CustRoundedButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.pnlLoadingBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.custRoundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crPBDP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.White;
            this.lblCreator.Location = new System.Drawing.Point(350, 468);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(218, 14);
            this.lblCreator.TabIndex = 14;
            this.lblCreator.Text = "SATHSARA BANDARA JAYASUNDARA 2021";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(154, 116);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(111, 16);
            this.lblSlogan.TabIndex = 13;
            this.lblSlogan.Text = "Focus on learning";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductName.Location = new System.Drawing.Point(135, 19);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(273, 98);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.Text = "Le-Sa";
            // 
            // pnlLoadingBack
            // 
            this.pnlLoadingBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.pnlLoadingBack.Controls.Add(this.pnlLoadingFront);
            this.pnlLoadingBack.Location = new System.Drawing.Point(12, 449);
            this.pnlLoadingBack.Name = "pnlLoadingBack";
            this.pnlLoadingBack.Size = new System.Drawing.Size(895, 7);
            this.pnlLoadingBack.TabIndex = 11;
            // 
            // pnlLoadingFront
            // 
            this.pnlLoadingFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(173)))), ((int)(((byte)(15)))));
            this.pnlLoadingFront.Location = new System.Drawing.Point(0, 0);
            this.pnlLoadingFront.Name = "pnlLoadingFront";
            this.pnlLoadingFront.Size = new System.Drawing.Size(1, 10);
            this.pnlLoadingFront.TabIndex = 2;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 10;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "L    E    A    R    N     -     S    A    F    E";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // custRoundedPanel1
            // 
            this.custRoundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custRoundedPanel1.BorderRadius = 20;
            this.custRoundedPanel1.BorderSize = 0;
            this.custRoundedPanel1.Controls.Add(this.crBtnVisibility);
            this.custRoundedPanel1.Controls.Add(this.cTBUsername);
            this.custRoundedPanel1.Controls.Add(this.cTBPassword);
            this.custRoundedPanel1.Controls.Add(this.crPBDP);
            this.custRoundedPanel1.Controls.Add(this.crBtnContinue);
            this.custRoundedPanel1.Controls.Add(this.lblUsername);
            this.custRoundedPanel1.Controls.Add(this.lblLogin);
            this.custRoundedPanel1.Controls.Add(this.lblPassword);
            this.custRoundedPanel1.Controls.Add(this.llblForgotPassword);
            this.custRoundedPanel1.ForeColor = System.Drawing.Color.White;
            this.custRoundedPanel1.Location = new System.Drawing.Point(627, 12);
            this.custRoundedPanel1.Name = "custRoundedPanel1";
            this.custRoundedPanel1.Size = new System.Drawing.Size(280, 420);
            this.custRoundedPanel1.TabIndex = 17;
            this.custRoundedPanel1.TextColor = System.Drawing.Color.White;
            // 
            // crBtnVisibility
            // 
            this.crBtnVisibility.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crBtnVisibility.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BorderRadius = 20;
            this.crBtnVisibility.BorderSize = 2;
            this.crBtnVisibility.FlatAppearance.BorderSize = 0;
            this.crBtnVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnVisibility.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.Image = global::Le_Sa.Properties.Resources.hide_22px;
            this.crBtnVisibility.Location = new System.Drawing.Point(235, 276);
            this.crBtnVisibility.Name = "crBtnVisibility";
            this.crBtnVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnVisibility.TabIndex = 58;
            this.crBtnVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.UseVisualStyleBackColor = false;
            this.crBtnVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnVisibility_MouseDown);
            this.crBtnVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnVisibility_MouseUp);
            // 
            // cTBUsername
            // 
            this.cTBUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBUsername.BorderRadius = 20;
            this.cTBUsername.BorderSize = 0;
            this.cTBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBUsername.Location = new System.Drawing.Point(16, 204);
            this.cTBUsername.Margin = new System.Windows.Forms.Padding(1);
            this.cTBUsername.Multiline = false;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cTBUsername.PasswordChar = false;
            this.cTBUsername.Size = new System.Drawing.Size(248, 27);
            this.cTBUsername.TabIndex = 57;
            this.cTBUsername.Texts = "";
            this.cTBUsername.UnderlinedStyle = false;
            // 
            // cTBPassword
            // 
            this.cTBPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBPassword.BorderRadius = 20;
            this.cTBPassword.BorderSize = 0;
            this.cTBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBPassword.Location = new System.Drawing.Point(16, 276);
            this.cTBPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBPassword.Multiline = false;
            this.cTBPassword.Name = "cTBPassword";
            this.cTBPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBPassword.PasswordChar = true;
            this.cTBPassword.Size = new System.Drawing.Size(246, 27);
            this.cTBPassword.TabIndex = 59;
            this.cTBPassword.Texts = "";
            this.cTBPassword.UnderlinedStyle = false;
            // 
            // crPBDP
            // 
            this.crPBDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.crPBDP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.crPBDP.BorderColor = System.Drawing.Color.Gray;
            this.crPBDP.BorderRadius = 101;
            this.crPBDP.BorderSize = 2;
            this.crPBDP.Location = new System.Drawing.Point(88, 49);
            this.crPBDP.Name = "crPBDP";
            this.crPBDP.Size = new System.Drawing.Size(105, 101);
            this.crPBDP.TabIndex = 62;
            this.crPBDP.TabStop = false;
            // 
            // crBtnContinue
            // 
            this.crBtnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnContinue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnContinue.BorderRadius = 20;
            this.crBtnContinue.BorderSize = 0;
            this.crBtnContinue.FlatAppearance.BorderSize = 0;
            this.crBtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnContinue.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.Location = new System.Drawing.Point(13, 376);
            this.crBtnContinue.Name = "crBtnContinue";
            this.crBtnContinue.Size = new System.Drawing.Size(249, 31);
            this.crBtnContinue.TabIndex = 60;
            this.crBtnContinue.Text = "Continue";
            this.crBtnContinue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.UseVisualStyleBackColor = false;
            this.crBtnContinue.Click += new System.EventHandler(this.crBtnContinue_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(9, 175);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 55;
            this.lblUsername.Text = "Username";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(6, 6);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(80, 31);
            this.lblLogin.TabIndex = 54;
            this.lblLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(9, 247);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 25);
            this.lblPassword.TabIndex = 56;
            this.lblPassword.Text = "Password";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.LinkColor = System.Drawing.Color.LightGray;
            this.llblForgotPassword.Location = new System.Drawing.Point(12, 307);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(128, 20);
            this.llblForgotPassword.TabIndex = 63;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot password?";
            this.llblForgotPassword.VisitedLinkColor = System.Drawing.Color.LightGray;
            // 
            // formLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(919, 490);
            this.Controls.Add(this.custRoundedPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlLoadingBack);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le-Sa";
            this.pnlLoadingBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.custRoundedPanel1.ResumeLayout(false);
            this.custRoundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crPBDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlLoadingBack;
        private System.Windows.Forms.Panel pnlLoadingFront;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private CustRoundedPanel custRoundedPanel1;
        private CustRoundedButton crBtnVisibility;
        private CustomControls.CustomTextBox cTBUsername;
        private CustomControls.CustomTextBox cTBPassword;
        private CustRoundedPictureBox crPBDP;
        private CustRoundedButton crBtnContinue;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
    }
}