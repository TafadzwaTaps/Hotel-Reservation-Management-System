namespace Hotel_Reservation_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            UserRoleComboBox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            PhysicalAddressTxtBox = new TextBox();
            label7 = new Label();
            PhoneNumberTxtBox = new TextBox();
            label6 = new Label();
            LastNameTxtBox = new TextBox();
            label5 = new Label();
            FirstNameTxtBox = new TextBox();
            label3 = new Label();
            PasswordTxtBox = new TextBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            UsernameTxtBox = new TextBox();
            RegisterBtn = new Button();
            EmailTxtBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 748);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 662);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(598, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(652, 748);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tan;
            panel3.Controls.Add(UserRoleComboBox);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(PhysicalAddressTxtBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(PhoneNumberTxtBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(LastNameTxtBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(FirstNameTxtBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(PasswordTxtBox);
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(UsernameTxtBox);
            panel3.Controls.Add(RegisterBtn);
            panel3.Controls.Add(EmailTxtBox);
            panel3.Location = new Point(31, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 722);
            panel3.TabIndex = 9;
            // 
            // UserRoleComboBox
            // 
            UserRoleComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserRoleComboBox.FormattingEnabled = true;
            UserRoleComboBox.Items.AddRange(new object[] { "Admin", "User" });
            UserRoleComboBox.Location = new Point(97, 583);
            UserRoleComboBox.Name = "UserRoleComboBox";
            UserRoleComboBox.Size = new Size(402, 39);
            UserRoleComboBox.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(97, 552);
            label9.Name = "label9";
            label9.Size = new Size(89, 28);
            label9.TabIndex = 20;
            label9.Text = "UserRole";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(97, 478);
            label8.Name = "label8";
            label8.Size = new Size(156, 28);
            label8.TabIndex = 18;
            label8.Text = "Physical Address";
            // 
            // PhysicalAddressTxtBox
            // 
            PhysicalAddressTxtBox.Font = new Font("Segoe UI", 12F);
            PhysicalAddressTxtBox.Location = new Point(97, 509);
            PhysicalAddressTxtBox.Multiline = true;
            PhysicalAddressTxtBox.Name = "PhysicalAddressTxtBox";
            PhysicalAddressTxtBox.PasswordChar = '*';
            PhysicalAddressTxtBox.Size = new Size(402, 40);
            PhysicalAddressTxtBox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(97, 399);
            label7.Name = "label7";
            label7.Size = new Size(139, 28);
            label7.TabIndex = 16;
            label7.Text = "PhoneNumber";
            // 
            // PhoneNumberTxtBox
            // 
            PhoneNumberTxtBox.Font = new Font("Segoe UI", 12F);
            PhoneNumberTxtBox.Location = new Point(97, 430);
            PhoneNumberTxtBox.Multiline = true;
            PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            PhoneNumberTxtBox.PasswordChar = '*';
            PhoneNumberTxtBox.Size = new Size(402, 40);
            PhoneNumberTxtBox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(97, 325);
            label6.Name = "label6";
            label6.Size = new Size(94, 28);
            label6.TabIndex = 14;
            label6.Text = "Lastname";
            // 
            // LastNameTxtBox
            // 
            LastNameTxtBox.Font = new Font("Segoe UI", 12F);
            LastNameTxtBox.Location = new Point(97, 356);
            LastNameTxtBox.Multiline = true;
            LastNameTxtBox.Name = "LastNameTxtBox";
            LastNameTxtBox.PasswordChar = '*';
            LastNameTxtBox.Size = new Size(402, 40);
            LastNameTxtBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(97, 246);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 12;
            label5.Text = "Firstname";
            // 
            // FirstNameTxtBox
            // 
            FirstNameTxtBox.Font = new Font("Segoe UI", 12F);
            FirstNameTxtBox.Location = new Point(97, 277);
            FirstNameTxtBox.Multiline = true;
            FirstNameTxtBox.Name = "FirstNameTxtBox";
            FirstNameTxtBox.PasswordChar = '*';
            FirstNameTxtBox.Size = new Size(402, 40);
            FirstNameTxtBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(97, 164);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(97, 195);
            PasswordTxtBox.Multiline = true;
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(402, 40);
            PasswordTxtBox.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(318, 699);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SignIn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 697);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 7;
            label4.Text = "Are you already a member?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(97, 86);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(97, 10);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // UsernameTxtBox
            // 
            UsernameTxtBox.Font = new Font("Segoe UI", 12F);
            UsernameTxtBox.Location = new Point(97, 41);
            UsernameTxtBox.Multiline = true;
            UsernameTxtBox.Name = "UsernameTxtBox";
            UsernameTxtBox.Size = new Size(402, 42);
            UsernameTxtBox.TabIndex = 0;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBtn.Location = new Point(97, 640);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(402, 56);
            RegisterBtn.TabIndex = 2;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Font = new Font("Segoe UI", 12F);
            EmailTxtBox.Location = new Point(97, 117);
            EmailTxtBox.Multiline = true;
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.PasswordChar = '*';
            EmailTxtBox.Size = new Size(402, 40);
            EmailTxtBox.TabIndex = 1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 748);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox UsernameTxtBox;
        private Button RegisterBtn;
        private TextBox EmailTxtBox;
        private PictureBox pictureBox1;
        private ComboBox UserRoleComboBox;
        private Label label9;
        private Label label8;
        private TextBox PhysicalAddressTxtBox;
        private Label label7;
        private TextBox PhoneNumberTxtBox;
        private Label label6;
        private TextBox LastNameTxtBox;
        private Label label5;
        private TextBox FirstNameTxtBox;
        private Label label3;
        private TextBox PasswordTxtBox;
    }
}