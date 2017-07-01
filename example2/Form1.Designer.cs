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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.tbWebUsername = new System.Windows.Forms.TextBox();
			this.tbWebPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbSQLScriptName = new System.Windows.Forms.TextBox();
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAuthenticate = new System.Windows.Forms.Button();
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
			this.btnCheckIfWSWorks = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbSerialNumberOrRegisteredName = new System.Windows.Forms.TextBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(100, 147);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(123, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbWebUsername
			// 
			this.tbWebUsername.Location = new System.Drawing.Point(100, 53);
			this.tbWebUsername.Margin = new System.Windows.Forms.Padding(4);
			this.tbWebUsername.Name = "tbWebUsername";
			this.tbWebUsername.Size = new System.Drawing.Size(123, 22);
			this.tbWebUsername.TabIndex = 1;
			this.tbWebUsername.Text = "demo";
			this.toolTip1.SetToolTip(this.tbWebUsername, "User name (Code) defined in SoftOne Web Accounts");
			// 
			// tbWebPassword
			// 
			this.tbWebPassword.Location = new System.Drawing.Point(100, 87);
			this.tbWebPassword.Margin = new System.Windows.Forms.Padding(4);
			this.tbWebPassword.Name = "tbWebPassword";
			this.tbWebPassword.Size = new System.Drawing.Size(123, 22);
			this.tbWebPassword.TabIndex = 2;
			this.tbWebPassword.Text = "demo";
			this.toolTip1.SetToolTip(this.tbWebPassword, "Password defined in SoftOne Web Accounts");
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
			// tbSQLScriptName
			// 
			this.tbSQLScriptName.Location = new System.Drawing.Point(21, 56);
			this.tbSQLScriptName.Margin = new System.Windows.Forms.Padding(4);
			this.tbSQLScriptName.Multiline = true;
			this.tbSQLScriptName.Name = "tbSQLScriptName";
			this.tbSQLScriptName.Size = new System.Drawing.Size(132, 24);
			this.tbSQLScriptName.TabIndex = 5;
			this.tbSQLScriptName.Text = "getProducts";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(197, 57);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(757, 142);
			this.textBox4.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(53, 88);
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
			this.label3.Location = new System.Drawing.Point(25, 36);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "SQL Script";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(194, 36);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "SQL Results";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 35);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Series Code";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(23, 80);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Customer ID";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 120);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Item ID";
			// 
			// series
			// 
			this.series.Location = new System.Drawing.Point(157, 31);
			this.series.Margin = new System.Windows.Forms.Padding(4);
			this.series.Name = "series";
			this.series.Size = new System.Drawing.Size(132, 22);
			this.series.TabIndex = 13;
			this.series.Text = "7021";
			this.toolTip1.SetToolTip(this.series, "The series ");
			// 
			// trdr
			// 
			this.trdr.Location = new System.Drawing.Point(157, 77);
			this.trdr.Margin = new System.Windows.Forms.Padding(4);
			this.trdr.Name = "trdr";
			this.trdr.Size = new System.Drawing.Size(132, 22);
			this.trdr.TabIndex = 14;
			this.trdr.Text = "29";
			this.toolTip1.SetToolTip(this.trdr, "The customer TRDR ID");
			// 
			// item
			// 
			this.item.Location = new System.Drawing.Point(157, 116);
			this.item.Margin = new System.Windows.Forms.Padding(4);
			this.item.Name = "item";
			this.item.Size = new System.Drawing.Size(132, 22);
			this.item.TabIndex = 15;
			this.item.Text = "1770";
			this.toolTip1.SetToolTip(this.item, "The Item MTRL ID");
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(346, 109);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(193, 28);
			this.button3.TabIndex = 16;
			this.button3.Text = "Post a Sales Document";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.btnAuthenticate);
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
			this.groupBox1.Location = new System.Drawing.Point(12, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(977, 182);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Web User";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(584, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 17);
			this.label8.TabIndex = 42;
			this.label8.Text = "Optional";
			// 
			// btnAuthenticate
			// 
			this.btnAuthenticate.Location = new System.Drawing.Point(516, 147);
			this.btnAuthenticate.Margin = new System.Windows.Forms.Padding(4);
			this.btnAuthenticate.Name = "btnAuthenticate";
			this.btnAuthenticate.Size = new System.Drawing.Size(123, 28);
			this.btnAuthenticate.TabIndex = 41;
			this.btnAuthenticate.Text = "Authenticate";
			this.btnAuthenticate.UseVisualStyleBackColor = true;
			this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
			// 
			// tbUserID
			// 
			this.tbUserID.Location = new System.Drawing.Point(516, 117);
			this.tbUserID.Margin = new System.Windows.Forms.Padding(4);
			this.tbUserID.Name = "tbUserID";
			this.tbUserID.Size = new System.Drawing.Size(60, 22);
			this.tbUserID.TabIndex = 36;
			this.toolTip1.SetToolTip(this.tbUserID, "SoftOne User ID");
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label20.Location = new System.Drawing.Point(434, 120);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(57, 17);
			this.label20.TabIndex = 37;
			this.label20.Text = "UserID";
			// 
			// tbRefID
			// 
			this.tbRefID.Location = new System.Drawing.Point(516, 87);
			this.tbRefID.Margin = new System.Windows.Forms.Padding(4);
			this.tbRefID.Name = "tbRefID";
			this.tbRefID.ReadOnly = true;
			this.tbRefID.Size = new System.Drawing.Size(60, 22);
			this.tbRefID.TabIndex = 34;
			this.toolTip1.SetToolTip(this.tbRefID, "Reference ID as obtained from login");
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label19.Location = new System.Drawing.Point(434, 90);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(48, 17);
			this.label19.TabIndex = 35;
			this.label19.Text = "RefID";
			// 
			// tbModule
			// 
			this.tbModule.Location = new System.Drawing.Point(516, 53);
			this.tbModule.Margin = new System.Windows.Forms.Padding(4);
			this.tbModule.Name = "tbModule";
			this.tbModule.ReadOnly = true;
			this.tbModule.Size = new System.Drawing.Size(60, 22);
			this.tbModule.TabIndex = 32;
			this.toolTip1.SetToolTip(this.tbModule, "Module ID as obtaned from login (Usually 0 is for user)\r\nIt represents the SoftOn" +
        "e Entity (12=Suppliers, 13=Customers, etc.)");
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label18.Location = new System.Drawing.Point(434, 56);
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
			this.label16.Location = new System.Drawing.Point(266, 27);
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
			this.tbBranch.Location = new System.Drawing.Point(348, 87);
			this.tbBranch.Margin = new System.Windows.Forms.Padding(4);
			this.tbBranch.Name = "tbBranch";
			this.tbBranch.ReadOnly = true;
			this.tbBranch.Size = new System.Drawing.Size(60, 22);
			this.tbBranch.TabIndex = 28;
			this.toolTip1.SetToolTip(this.tbBranch, "Branch obtained through the Login method");
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label17.Location = new System.Drawing.Point(266, 90);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(59, 17);
			this.label17.TabIndex = 29;
			this.label17.Text = "Branch";
			// 
			// tbCompany
			// 
			this.tbCompany.Location = new System.Drawing.Point(348, 53);
			this.tbCompany.Margin = new System.Windows.Forms.Padding(4);
			this.tbCompany.Name = "tbCompany";
			this.tbCompany.ReadOnly = true;
			this.tbCompany.Size = new System.Drawing.Size(60, 22);
			this.tbCompany.TabIndex = 25;
			this.toolTip1.SetToolTip(this.tbCompany, "Company obtained through the Login method");
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label15.Location = new System.Drawing.Point(266, 56);
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
			this.tbAppID.Size = new System.Drawing.Size(123, 22);
			this.tbAppID.TabIndex = 22;
			this.tbAppID.Text = "157";
			this.toolTip1.SetToolTip(this.tbAppID, "ID of the Service defined in Web Services\r\n");
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
			// btnCheckIfWSWorks
			// 
			this.btnCheckIfWSWorks.Location = new System.Drawing.Point(455, 26);
			this.btnCheckIfWSWorks.Name = "btnCheckIfWSWorks";
			this.btnCheckIfWSWorks.Size = new System.Drawing.Size(123, 23);
			this.btnCheckIfWSWorks.TabIndex = 26;
			this.btnCheckIfWSWorks.Text = "Ping";
			this.toolTip1.SetToolTip(this.btnCheckIfWSWorks, "Pings the SoftOne API. It is the simplest method that you can use to see that the" +
        " API is functioning.");
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
			this.toolTip1.SetToolTip(this.tbSerialNumberOrRegisteredName, "Registered name or Serial Number");
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(623, 26);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(123, 23);
			this.btnRefresh.TabIndex = 27;
			this.btnRefresh.Text = "Refresh";
			this.toolTip1.SetToolTip(this.btnRefresh, resources.GetString("btnRefresh.ToolTip"));
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 50000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.tbSQLScriptName);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 256);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(977, 224);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SQL Query";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.series);
			this.groupBox3.Controls.Add(this.trdr);
			this.groupBox3.Controls.Add(this.item);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Location = new System.Drawing.Point(12, 487);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(977, 158);
			this.groupBox3.TabIndex = 29;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "New Sales Document";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1001, 661);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnCheckIfWSWorks);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbSerialNumberOrRegisteredName);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Soft1 New Saldoc ";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWebUsername;
        private System.Windows.Forms.TextBox tbWebPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSQLScriptName;
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCheckIfWSWorks;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbSerialNumberOrRegisteredName;
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
		private System.Windows.Forms.TextBox tbRefID;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnAuthenticate;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox tbUserID;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
	}
}

