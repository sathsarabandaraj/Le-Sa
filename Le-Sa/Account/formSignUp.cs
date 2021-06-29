﻿using Le_Sa.Models.RandomString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;
using Le_Sa.Models.Copy;
using System.IO;
using System.Data.SqlClient;

namespace Le_Sa.Account
{
    public partial class formSignUp : Form
    {
        private string otp;
        private int sec = 59;
        private int min = 04;
        private string source;
        private string ImageLoc;
        private Point lastPoint;
        System.Timers.Timer tmrOTP;
        private string destinationFile;
        private string destinationPath;

        public formSignUp()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void formSignUp_Load(object sender, EventArgs e)
        {
            tmrOTP = new System.Timers.Timer
            {
                Interval = 1000//1s
            };
            tmrOTP.Elapsed += OnTimeEvent;
        }
       
        private readonly string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sathsara\source\repos\sathsarabandaraj\Le-Sa\Le-Sa\Data\user.mdf;Integrated Security = True; Timeout=30";

        #region Rounded Corner
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        #endregion


        #region Timer Event
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                sec -= 1;
                if (min == 00 && sec == 00)
                {
                    tmrOTP.Stop();
                    otp = null;
                    MessageBox.Show("OTP that sent to you is expired. You can't use it anymore. You can get a new otp now.", "OTP expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOTPTimer.Text = "05:00";
                    crBtnSendOTP.Enabled = true;
                }
                if (sec == 00)
                {
                    sec = 59;
                    min -= 1;
                }
                //Update lable
                lblOTPTimer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }));
        }
        #endregion

        #region OTP
        private void crBtnSendOTP_Click(object sender, EventArgs e)
        {
            if (cTBEmail.Texts.Trim() == "")
            {
                MessageBox.Show("Please fill Email fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                otp = RandomStringGenerator.GenerateRandomString(6, true, false, true, false);
                try
                {
                    using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                    {
                        client.EnableSsl = true;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new NetworkCredential("lesafe.soft@gmail.com", "znvxqikozbjqhere");
                        MailMessage msgObj = new MailMessage();
                        msgObj.To.Add(cTBEmail.Texts.Trim());
                        msgObj.From = new MailAddress("lesafe.soft@gmail.com", "Le-Sa");
                        msgObj.Subject = "OTP";
                        msgObj.Body = "Use this One Time Password to verify your account 👉 " + otp + " 👈";
                        client.Send(msgObj);
                    }
                    crBtnSendOTP.Enabled = false;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                tmrOTP.Start();
            }
        }
        #endregion

        #region DP
        private void crBtnRemovwDP_Click(object sender, EventArgs e)
        {
            crPBDP.Image = Properties.Resources.user_90px;
            try
            {
                File.Delete(ImageLoc);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void crBtnDP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dp = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            if (dp.ShowDialog() == DialogResult.OK)
            {
                source = dp.FileName.ToString();
                destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\";
                destinationFile = "DP";
                crPBDP.SizeMode = PictureBoxSizeMode.StretchImage;

                Copy.CopyFile(null, source, destinationPath, destinationFile);
                ImageLoc = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\DP";
                crPBDP.Image = new Bitmap(ImageLoc);
            }
        }
        #endregion

        #region Password

        private void crBtnGeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPass = RandomStringGenerator.GenerateRandomString(12, true, true, true, true);
            cTBPassword.Texts = generatedPass;
            cTBConfPass.Texts = generatedPass;
        }

        private void crBtnPassVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            PasscharDisabled();
        }

        private void crBtnPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            PasscharEnabled();
        }

        private void crBtnConfPassVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            PasscharDisabled();
        }

        private void crBtnConfPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            PasscharEnabled();
        }

        private void PasscharDisabled()
        {
            cTBPassword.PasswordChar = false;
            cTBConfPass.PasswordChar = false;
            crBtnPassVisibility.Image = Properties.Resources.show_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.show_22px;
        }

        private void PasscharEnabled()
        {
            cTBPassword.PasswordChar = true;
            cTBConfPass.PasswordChar = true;
            crBtnPassVisibility.Image = Properties.Resources.hide_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.hide_22px;
        }

        #region Password Strength
        private void crBtnStrength_Click(object sender, EventArgs e)
        {
            if (cTBPassword.Texts.Trim() == "" || cTBConfPass.Texts.Trim() == "")
            {
                MessageBox.Show("Please fill password fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBPassword.Texts.Trim() != cTBConfPass.Texts.Trim())
            {
                MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int passwordScore = CheckString.StrengthScore(cTBPassword.Texts, true, true, true, true);
                (string strengthLevel, Color strengthColor) = (CheckString.StrengthNaming(passwordScore).Item1, CheckString.StrengthNaming(passwordScore).Item2);
                lblStrength.Text = strengthLevel;
                lblStrength.ForeColor = strengthColor;
                lblStrength.Visible = true;
            }
        }
        #endregion

        #endregion

        #region Clear
        private void cBtnClear_Click(object sender, EventArgs e)
        {
            cTBUsername.Texts = "";
            cTBPassword.Texts = "";
            cTBConfPass.Texts = "";
            cTBPhoneNumber.Texts = "";
            cTBEmail.Texts = "";
            cTBOTP.Texts = "";

            lblOTPTimer.Text = "00:00";
            crBtnSendOTP.Enabled = true;
            lblStrength.Visible = false;
        }
        #endregion

        #region Create account
        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (cTBUsername.Texts.Trim() == "" || cTBPassword.Texts.Trim() == "" || cTBConfPass.Texts.Trim() == "" || cTBEmail.Texts.Trim() == "" || cTBPhoneNumber.Texts.Trim() == "" || cTBOTP.Texts.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cTBUsername.Texts.Length <= 3)
                {
                    MessageBox.Show("Username must be a minimum of 4 characters", "Username is too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cTBPassword.Texts.Trim() != cTBConfPass.Texts.Trim())
                    {
                        MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cTBOTP.Texts.Trim() != otp)
                        {
                            MessageBox.Show("OTP didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            try
                            {
                                SqlConnection con = new SqlConnection(db);
                                con.Open();
                                SqlCommand insertUD = new SqlCommand("INSERT INTO tbl_user(email,username,password,phoneNumber)Values('" + cTBEmail.Texts + "','" + cTBUsername.Texts + "','" + cTBPassword.Texts + "','" + cTBPhoneNumber.Texts + "')", con); //insert user data into database
                                insertUD.ExecuteNonQuery();
                                con.Close();

                                string successMsg = "User accout created successfully." + Environment.NewLine + "Thanks for choosing Le-Sa";
                                MessageBox.Show(successMsg, "Account Created", MessageBoxButtons.OK);

                                formDesktop desktop = new formDesktop();
                                desktop.Show();
                                this.Hide();
                            }
                            catch(Exception insert)
                            {
                                MessageBox.Show(insert.Message, insert.StackTrace);
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Titlebar
        private void crBrnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Drag
        private void pnlBackground_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnlBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void crPnlPassword0_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void crPnlPassword0_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void crPnlPassword1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void crPnlPassword1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        #endregion

    }
}
