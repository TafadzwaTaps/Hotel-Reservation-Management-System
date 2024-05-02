﻿namespace Hotel_Reservation_Management_System
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 714);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(76, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 714);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.THEME_HOTEL_SIGN_FIVE_STARS_FACADE_BUILDING_GettyImages_1320779330_3;
            pictureBox1.Location = new Point(-1, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 13.8F);
            button7.Location = new Point(0, 645);
            button7.Name = "button7";
            button7.Size = new Size(218, 57);
            button7.TabIndex = 6;
            button7.Text = "Reservations";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 13.8F);
            button6.Location = new Point(0, 559);
            button6.Name = "button6";
            button6.Size = new Size(218, 55);
            button6.TabIndex = 5;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 13.8F);
            button5.Location = new Point(-1, 483);
            button5.Name = "button5";
            button5.Size = new Size(218, 53);
            button5.TabIndex = 4;
            button5.Text = "Users";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.Location = new Point(0, 406);
            button4.Name = "button4";
            button4.Size = new Size(218, 54);
            button4.TabIndex = 3;
            button4.Text = "RoomTypes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new Point(-1, 335);
            button3.Name = "button3";
            button3.Size = new Size(218, 53);
            button3.TabIndex = 2;
            button3.Text = "Rooms";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new Point(-3, 247);
            button2.Name = "button2";
            button2.Size = new Size(218, 56);
            button2.TabIndex = 1;
            button2.Text = "Customers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new Point(-1, 168);
            button1.Name = "button1";
            button1.Size = new Size(218, 53);
            button1.TabIndex = 0;
            button1.Text = "Bookings";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(294, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 67);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(294, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(1064, 647);
            panel4.TabIndex = 4;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 714);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
