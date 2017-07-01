namespace example2
{
    partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.tbWebUsername = new System.Windows.Forms.TextBox();
			this.tbWebPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.series = new System.Windows.Forms.TextBox();
			this.trdr = new System.Windows.Forms.TextBox();
			this.item = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label21 = new System.Windows.Forms.Label();
			this.tbUserID = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tbRefID = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.tbModule = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tbBranch = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.tbCompany = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tbAppID = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnCheckIfWSWorks = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbSerialNumberOrRegisteredName = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(868, 147);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login and Authenticate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbWebUsername
			// 
			this.tbWebUsername.Location = new System.Drawing.Point(100, 53);
			this.tbWebUsername.Margin = new System.Windows.Forms.Padding(4);
			this.tbWebUsername.Name = "tbWebUsername";
			this.tbWebUsername.Size = new System.Drawing.Size(132, 22);
			this.tbWebUsername.TabIndex = 1;
			this.tbWebUsername.Text = "demo";
			// 
			// tbWebPassword
			// 
			this.tbWebPassword.Location = new System.Drawing.Point(100, 87);
			this.tbWebPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbWebPassword.Name = "tbWebPassword";
			this.tbWebPassword.Size = new System.Drawing.Size(132, 22);
			this.tbWebPassword.TabIndex = 2;
			this.tbWebPassword.Text = "demo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.Location = new System.Drawing.Point(18, 56);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label2.Location = new System.Drawing.Point(18, 90);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(33, 272);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(592, 67);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "select top 5 code, name from trdr where sodtype=13";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(33, 374);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(592, 128);
			this.textBox4.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(648, 475);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 7;
			this.button2.Text = "Execute";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 252);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "SQL";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 355);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "SQL Results";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 516);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Series Code";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 561);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Customer ID";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(58, 601);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Item ID";
			// 
			// series
			// 
			this.series.Location = new System.Drawing.Point(161, 512);
			this.series.Margin = new System.Windows.Forms.Padding(4);
			this.series.Name = "series";
			this.series.Size = new System.Drawing.Size(132, 22);
			this.series.TabIndex = 13;
			this.series.Text = "7021";
			// 
			// trdr
			// 
			this.trdr.Location = new System.Drawing.Point(161, 558);
			this.trdr.Margin = new System.Windows.Forms.Padding(4);
			this.trdr.Name = "trdr";
			this.trdr.Size = new System.Drawing.Size(132, 22);
			this.trdr.TabIndex = 14;
			this.trdr.Text = "40";
			// 
			// item
			// 
			this.item.Location = new System.Drawing.Point(161, 597);
			this.item.Margin = new System.Windows.Forms.Padding(4);
			this.item.Name = "item";
			this.item.Size = new System.Drawing.Size(132, 22);
			this.item.TabIndex = 15;
			this.item.Text = "1191";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(365, 597);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(193, 28);
			this.button3.TabIndex = 16;
			this.button3.Text = "Post a Sales Document";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label8.Location = new System.Drawing.Point(239, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(181, 17);
			this.label8.TabIndex = 17;
			this.label8.Text = "Username of Web Account ";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label21);
			this.groupBox1.Controls.Add(this.tbUserID);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.tbRefID);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.tbModule);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.tbBranch);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.tbCompany);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.tbAppID);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.tbWebUsername);
			this.groupBox1.Controls.Add(this.tbWebPassword);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(12, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1071, 182);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Web User";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label21.Location = new System.Drawing.Point(757, 56);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(181, 17);
			this.label21.TabIndex = 38;
			this.label21.Text = "Username of Web Account ";
			// 
			// tbUserID
			// 
			this.tbUserID.Location = new System.Drawing.Point(690, 117);
			this.tbUserID.Margin = new System.Windows.Forms.Padding(4);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.Size = new System.Drawing.Size(60, 22);
			this.tbUserID.TabIndex = 36;
			this.tbUserID.Text = "1";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label20.Location = new System.Drawing.Point(608, 120);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(57, 17);
			this.label20.TabIndex = 37;
			this.label20.Text = "UserID";
			// 
			// tbRefID
			// 
			this.tbRefID.Location = new System.Drawing.Point(690, 87);
			this.tbRefID.Margin = new System.Windows.Forms.Padding(4);
			this.tbRefID.Name = "tbRefID";
			this.tbRefID.Size = new System.Drawing.Size(60, 22);
			this.tbRefID.TabIndex = 34;
			this.tbRefID.Text = "1";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label19.Location = new System.Drawing.Point(608, 90);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 17);
			this.label19.TabIndex = 35;
			this.label19.Text = "RefID";
			// 
			// tbModule
			// 
			this.tbModule.Location = new System.Drawing.Point(690, 53);
			this.tbModule.Margin = new System.Windows.Forms.Padding(4);
			this.tbModule.Name = "tbModule";
			this.tbModule.Size = new System.Drawing.Size(60, 22);
			this.tbModule.TabIndex = 32;
			this.tbModule.Text = "0";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label18.Location = new System.Drawing.Point(608, 56);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(60, 17);
			this.label18.TabIndex = 33;
			this.label18.Text = "Module";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label16.Location = new System.Drawing.Point(440, 27);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(142, 17);
			this.label16.TabIndex = 31;
			this.label16.Text = "AUTHENTICATION";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label14.Location = new System.Drawing.Point(18, 27);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 17);
			this.label14.TabIndex = 30;
			this.label14.Text = "LOGIN";
			// 
			// tbBranch
			// 
			this.tbBranch.Location = new System.Drawing.Point(522, 87);
			this.tbBranch.Margin = new System.Windows.Forms.Padding(4);
			this.tbBranch.Name = "tbBranch";
			this.tbBranch.Size = new System.Drawing.Size(60, 22);
			this.tbBranch.TabIndex = 28;
			this.tbBranch.Text = "1000";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label17.Location = new System.Drawing.Point(440, 90);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 17);
			this.label17.TabIndex = 29;
			this.label17.Text = "Branch";
			// 
			// tbCompany
			// 
			this.tbCompany.Location = new System.Drawing.Point(522, 53);
			this.tbCompany.Margin = new System.Windows.Forms.Padding(4);
			this.tbCompany.Name = "tbCompany";
			this.tbCompany.Size = new System.Drawing.Size(60, 22);
			this.tbCompany.TabIndex = 25;
			this.tbCompany.Text = "1000";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label15.Location = new System.Drawing.Point(440, 56);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 17);
			this.label15.TabIndex = 26;
			this.label15.Text = "Company";
			// 
			// tbAppID
			// 
			this.tbAppID.Location = new System.Drawing.Point(100, 117);
			this.tbAppID.Margin = new System.Windows.Forms.Padding(4);
			this.tbAppID.Name = "tbAppID";
			this.tbAppID.Size = new System.Drawing.Size(132, 22);
			this.tbAppID.TabIndex = 22;
			this.tbAppID.Text = "157";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label13.Location = new System.Drawing.Point(18, 120);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(51, 17);
			this.label13.TabIndex = 23;
			this.label13.Text = "AppID";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label12.Location = new System.Drawing.Point(239, 120);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(176, 17);
			this.label12.TabIndex = 24;
			this.label12.Text = "Account for a Web Service";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label11.Location = new System.Drawing.Point(239, 90);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(177, 17);
			this.label11.TabIndex = 21;
			this.label11.Text = "Password of Web Account ";
			// 
			// btnCheckIfWSWorks
			// 
			this.btnCheckIfWSWorks.Location = new System.Drawing.Point(455, 26);
			this.btnCheckIfWSWorks.Name = "btnCheckIfWSWorks";
			this.btnCheckIfWSWorks.Size = new System.Drawing.Size(123, 23);
			this.btnCheckIfWSWorks.TabIndex = 26;
			this.btnCheckIfWSWorks.Text = "Check If Works";
			this.btnCheckIfWSWorks.UseVisualStyleBackColor = true;
			this.btnCheckIfWSWorks.Click += new System.EventHandler(this.button4_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label10.Location = new System.Drawing.Point(248, 28);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(172, 17);
			this.label10.TabIndex = 25;
			this.label10.Text = ".oncloud.gr/s1services";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label9.Location = new System.Drawing.Point(48, 29);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 17);
			this.label9.TabIndex = 24;
			this.label9.Text = "http://";
			// 
			// tbSerialNumberOrRegisteredName
			// 
			this.tbSerialNumberOrRegisteredName.Location = new System.Drawing.Point(112, 26);
			this.tbSerialNumberOrRegisteredName.Name = "tbSerialNumberOrRegisteredName";
			this.tbSerialNumberOrRegisteredName.Size = new System.Drawing.Size(132, 22);
			this.tbSerialNumberOrRegisteredName.TabIndex = 23;
			this.tbSerialNumberOrRegisteredName.Text = "demo";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1095, 644);
			this.Controls.Add(this.btnCheckIfWSWorks);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbSerialNumberOrRegisteredName);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.item);
			this.Controls.Add(this.trdr);
			this.Controls.Add(this.series);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Soft1 New Saldoc ";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWebUsername;
        private System.Windows.Forms.TextBox tbWebPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox series;
        private System.Windows.Forms.TextBox trdr;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnCheckIfWSWorks;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbSerialNumberOrRegisteredName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbAppID;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbBranch;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbCompany;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbModule;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox tbRefID;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
	}
}

