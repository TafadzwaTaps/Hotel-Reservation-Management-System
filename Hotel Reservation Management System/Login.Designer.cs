﻿namespace Hotel_Reservation_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UsernameTxtBox = new TextBox();
            LoginBtn = new Button();
            PasswordTxtBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 696);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(UsernameTxtBox);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(PasswordTxtBox);
            panel2.Location = new Point(765, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 456);
            panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(304, 239);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(286, 379);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SignUp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 379);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 7;
            label4.Text = "Are you not a member?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 240);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 6;
            label3.Text = "Forgot Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 141);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI", 12F);
            UsernameTxtBox.Location = new Point(34, 81);
            UsernameTxtBox.Multiline = true;
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(402, 42);
            UsernameTxtBox.TabIndex = 0;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(34, 298);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(402, 56);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(34, 185);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(402, 40);
            PasswordTxtBox.TabIndex = 1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1366, 720);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox UsernameTxtBox;
        private Button LoginBtn;
        private TextBox PasswordTxtBox;
        private CheckBox checkBox1;
    }
}