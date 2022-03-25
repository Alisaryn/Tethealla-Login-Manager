
namespace Tethealla_Login_Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nmMaxClients = new System.Windows.Forms.NumericUpDown();
            this.nmPort = new System.Windows.Forms.NumericUpDown();
            this.nmMaxShips = new System.Windows.Forms.NumericUpDown();
            this.txtPublicIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.txtPrivateIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmKond = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.nmEclair = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nmRappies = new System.Windows.Forms.NumericUpDown();
            this.nmLillies = new System.Windows.Forms.NumericUpDown();
            this.nmMerissa = new System.Windows.Forms.NumericUpDown();
            this.nmSlimes = new System.Windows.Forms.NumericUpDown();
            this.nmHild = new System.Windows.Forms.NumericUpDown();
            this.nmPazuzu = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveLogin = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtGlobalGMName = new System.Windows.Forms.TextBox();
            this.txtNormalName = new System.Windows.Forms.TextBox();
            this.txtLocalGMName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lnkLoginRunning = new System.Windows.Forms.LinkLabel();
            this.lnkLoginDown = new System.Windows.Forms.LinkLabel();
            this.chkLoginRestart = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lnkPatchRunning = new System.Windows.Forms.LinkLabel();
            this.lnkPatchDown = new System.Windows.Forms.LinkLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkUnlimited = new System.Windows.Forms.CheckBox();
            this.nmPatchUpload = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.btnPatchSave = new System.Windows.Forms.Button();
            this.chkPatchRestart = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtPatchWelcome = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxShips)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEclair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRappies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLillies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMerissa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSlimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPazuzu)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPatchUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // nmMaxClients
            // 
            this.nmMaxClients.Location = new System.Drawing.Point(133, 126);
            this.nmMaxClients.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmMaxClients.Name = "nmMaxClients";
            this.nmMaxClients.Size = new System.Drawing.Size(120, 20);
            this.nmMaxClients.TabIndex = 5;
            this.nmMaxClients.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nmPort
            // 
            this.nmPort.Location = new System.Drawing.Point(133, 100);
            this.nmPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPort.Name = "nmPort";
            this.nmPort.Size = new System.Drawing.Size(120, 20);
            this.nmPort.TabIndex = 4;
            this.nmPort.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            // 
            // nmMaxShips
            // 
            this.nmMaxShips.Location = new System.Drawing.Point(133, 152);
            this.nmMaxShips.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmMaxShips.Name = "nmMaxShips";
            this.nmMaxShips.Size = new System.Drawing.Size(120, 20);
            this.nmMaxShips.TabIndex = 6;
            this.nmMaxShips.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // txtPublicIP
            // 
            this.txtPublicIP.Location = new System.Drawing.Point(133, 74);
            this.txtPublicIP.Name = "txtPublicIP";
            this.txtPublicIP.Size = new System.Drawing.Size(120, 20);
            this.txtPublicIP.TabIndex = 3;
            this.txtPublicIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max allowed clients:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max allowed ships:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Override IP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWelcome);
            this.groupBox1.Controls.Add(this.txtPrivateIP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nmMaxClients);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nmMaxShips);
            this.groupBox1.Controls.Add(this.txtPublicIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 270);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Configuration";
            // 
            // txtWelcome
            // 
            this.txtWelcome.Location = new System.Drawing.Point(132, 22);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(120, 20);
            this.txtWelcome.TabIndex = 1;
            this.txtWelcome.Text = "Your welcome message here...";
            // 
            // txtPrivateIP
            // 
            this.txtPrivateIP.Location = new System.Drawing.Point(133, 49);
            this.txtPrivateIP.Name = "txtPrivateIP";
            this.txtPrivateIP.Size = new System.Drawing.Size(120, 20);
            this.txtPrivateIP.TabIndex = 2;
            this.txtPrivateIP.Text = "127.0.0.1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Banner message:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Private IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmKond);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.nmEclair);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nmRappies);
            this.groupBox2.Controls.Add(this.nmLillies);
            this.groupBox2.Controls.Add(this.nmMerissa);
            this.groupBox2.Controls.Add(this.nmSlimes);
            this.groupBox2.Controls.Add(this.nmHild);
            this.groupBox2.Controls.Add(this.nmPazuzu);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(287, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 230);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rare Appearance (%)";
            // 
            // nmKond
            // 
            this.nmKond.DecimalPlaces = 3;
            this.nmKond.Location = new System.Drawing.Point(108, 199);
            this.nmKond.Name = "nmKond";
            this.nmKond.Size = new System.Drawing.Size(120, 20);
            this.nmKond.TabIndex = 21;
            this.nmKond.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Dorphon Eclair:";
            // 
            // nmEclair
            // 
            this.nmEclair.DecimalPlaces = 3;
            this.nmEclair.Location = new System.Drawing.Point(108, 173);
            this.nmEclair.Name = "nmEclair";
            this.nmEclair.Size = new System.Drawing.Size(120, 20);
            this.nmEclair.TabIndex = 20;
            this.nmEclair.Value = new decimal(new int[] {
            7,
            0,
            0,
            196608});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Kondrieu:";
            // 
            // nmRappies
            // 
            this.nmRappies.DecimalPlaces = 3;
            this.nmRappies.Location = new System.Drawing.Point(108, 47);
            this.nmRappies.Name = "nmRappies";
            this.nmRappies.Size = new System.Drawing.Size(120, 20);
            this.nmRappies.TabIndex = 1;
            this.nmRappies.Value = new decimal(new int[] {
            8,
            0,
            0,
            196608});
            // 
            // nmLillies
            // 
            this.nmLillies.DecimalPlaces = 3;
            this.nmLillies.Location = new System.Drawing.Point(108, 74);
            this.nmLillies.Name = "nmLillies";
            this.nmLillies.Size = new System.Drawing.Size(120, 20);
            this.nmLillies.TabIndex = 2;
            this.nmLillies.Value = new decimal(new int[] {
            8,
            0,
            0,
            196608});
            // 
            // nmMerissa
            // 
            this.nmMerissa.DecimalPlaces = 3;
            this.nmMerissa.Location = new System.Drawing.Point(108, 123);
            this.nmMerissa.Name = "nmMerissa";
            this.nmMerissa.Size = new System.Drawing.Size(120, 20);
            this.nmMerissa.TabIndex = 4;
            this.nmMerissa.Value = new decimal(new int[] {
            7,
            0,
            0,
            196608});
            // 
            // nmSlimes
            // 
            this.nmSlimes.DecimalPlaces = 3;
            this.nmSlimes.Location = new System.Drawing.Point(108, 99);
            this.nmSlimes.Name = "nmSlimes";
            this.nmSlimes.Size = new System.Drawing.Size(120, 20);
            this.nmSlimes.TabIndex = 3;
            this.nmSlimes.Value = new decimal(new int[] {
            7,
            0,
            0,
            196608});
            // 
            // nmHild
            // 
            this.nmHild.DecimalPlaces = 3;
            this.nmHild.Location = new System.Drawing.Point(108, 22);
            this.nmHild.Name = "nmHild";
            this.nmHild.Size = new System.Drawing.Size(120, 20);
            this.nmHild.TabIndex = 0;
            this.nmHild.Value = new decimal(new int[] {
            7,
            0,
            0,
            196608});
            // 
            // nmPazuzu
            // 
            this.nmPazuzu.DecimalPlaces = 3;
            this.nmPazuzu.Location = new System.Drawing.Point(108, 147);
            this.nmPazuzu.Name = "nmPazuzu";
            this.nmPazuzu.Size = new System.Drawing.Size(120, 20);
            this.nmPazuzu.TabIndex = 19;
            this.nmPazuzu.Value = new decimal(new int[] {
            7,
            0,
            0,
            196608});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Pazuzu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Slimes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Lillies:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Merissa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Rappies:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hildebear:";
            // 
            // btnSaveLogin
            // 
            this.btnSaveLogin.Location = new System.Drawing.Point(299, 267);
            this.btnSaveLogin.Name = "btnSaveLogin";
            this.btnSaveLogin.Size = new System.Drawing.Size(216, 23);
            this.btnSaveLogin.TabIndex = 22;
            this.btnSaveLogin.TabStop = false;
            this.btnSaveLogin.Text = "Save";
            this.btnSaveLogin.UseVisualStyleBackColor = true;
            this.btnSaveLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(543, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtGlobalGMName);
            this.tabPage1.Controls.Add(this.txtNormalName);
            this.tabPage1.Controls.Add(this.btnSaveLogin);
            this.tabPage1.Controls.Add(this.txtLocalGMName);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.lnkLoginRunning);
            this.tabPage1.Controls.Add(this.lnkLoginDown);
            this.tabPage1.Controls.Add(this.chkLoginRestart);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login Settings";
            // 
            // txtGlobalGMName
            // 
            this.txtGlobalGMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(148)))), ((int)(((byte)(247)))));
            this.txtGlobalGMName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGlobalGMName.Location = new System.Drawing.Point(139, 267);
            this.txtGlobalGMName.Name = "txtGlobalGMName";
            this.txtGlobalGMName.ReadOnly = true;
            this.txtGlobalGMName.Size = new System.Drawing.Size(120, 20);
            this.txtGlobalGMName.TabIndex = 28;
            this.txtGlobalGMName.Click += new System.EventHandler(this.txtGlobalGMName_Click);
            // 
            // txtNormalName
            // 
            this.txtNormalName.BackColor = System.Drawing.Color.White;
            this.txtNormalName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNormalName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNormalName.Location = new System.Drawing.Point(139, 215);
            this.txtNormalName.Name = "txtNormalName";
            this.txtNormalName.ReadOnly = true;
            this.txtNormalName.Size = new System.Drawing.Size(120, 20);
            this.txtNormalName.TabIndex = 27;
            this.txtNormalName.Click += new System.EventHandler(this.txtNormalName_Click);
            // 
            // txtLocalGMName
            // 
            this.txtLocalGMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(206)))), ((int)(((byte)(222)))));
            this.txtLocalGMName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLocalGMName.Location = new System.Drawing.Point(139, 241);
            this.txtLocalGMName.Name = "txtLocalGMName";
            this.txtLocalGMName.ReadOnly = true;
            this.txtLocalGMName.Size = new System.Drawing.Size(120, 20);
            this.txtLocalGMName.TabIndex = 26;
            this.txtLocalGMName.Click += new System.EventHandler(this.txtLocalGMName_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Name color (normal):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Name color (local GM):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Name color (global GM):";
            // 
            // lnkLoginRunning
            // 
            this.lnkLoginRunning.ActiveLinkColor = System.Drawing.Color.Red;
            this.lnkLoginRunning.AutoSize = true;
            this.lnkLoginRunning.LinkColor = System.Drawing.Color.Navy;
            this.lnkLoginRunning.Location = new System.Drawing.Point(82, 3);
            this.lnkLoginRunning.Name = "lnkLoginRunning";
            this.lnkLoginRunning.Size = new System.Drawing.Size(43, 13);
            this.lnkLoginRunning.TabIndex = 22;
            this.lnkLoginRunning.TabStop = true;
            this.lnkLoginRunning.Text = "Starting";
            this.lnkLoginRunning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStarted_LinkClicked);
            // 
            // lnkLoginDown
            // 
            this.lnkLoginDown.AutoSize = true;
            this.lnkLoginDown.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkLoginDown.Location = new System.Drawing.Point(82, 3);
            this.lnkLoginDown.Name = "lnkLoginDown";
            this.lnkLoginDown.Size = new System.Drawing.Size(35, 13);
            this.lnkLoginDown.TabIndex = 21;
            this.lnkLoginDown.TabStop = true;
            this.lnkLoginDown.Text = "Down";
            this.lnkLoginDown.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkLoginDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkLoginRestart
            // 
            this.chkLoginRestart.AutoSize = true;
            this.chkLoginRestart.Location = new System.Drawing.Point(137, 3);
            this.chkLoginRestart.Name = "chkLoginRestart";
            this.chkLoginRestart.Size = new System.Drawing.Size(125, 17);
            this.chkLoginRestart.TabIndex = 20;
            this.chkLoginRestart.Text = "Restart Automatically";
            this.chkLoginRestart.UseVisualStyleBackColor = true;
            this.chkLoginRestart.CheckedChanged += new System.EventHandler(this.chkRestart_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Login Status:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.lnkPatchRunning);
            this.tabPage2.Controls.Add(this.lnkPatchDown);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.chkUnlimited);
            this.tabPage2.Controls.Add(this.nmPatchUpload);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.btnPatchSave);
            this.tabPage2.Controls.Add(this.chkPatchRestart);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patch Settings";
            // 
            // lnkPatchRunning
            // 
            this.lnkPatchRunning.AutoSize = true;
            this.lnkPatchRunning.LinkColor = System.Drawing.Color.Navy;
            this.lnkPatchRunning.Location = new System.Drawing.Point(82, 3);
            this.lnkPatchRunning.Name = "lnkPatchRunning";
            this.lnkPatchRunning.Size = new System.Drawing.Size(43, 13);
            this.lnkPatchRunning.TabIndex = 33;
            this.lnkPatchRunning.TabStop = true;
            this.lnkPatchRunning.Text = "Starting";
            this.lnkPatchRunning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPatchRunning_LinkClicked_1);
            // 
            // lnkPatchDown
            // 
            this.lnkPatchDown.AutoSize = true;
            this.lnkPatchDown.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkPatchDown.Location = new System.Drawing.Point(82, 3);
            this.lnkPatchDown.Name = "lnkPatchDown";
            this.lnkPatchDown.Size = new System.Drawing.Size(35, 13);
            this.lnkPatchDown.TabIndex = 27;
            this.lnkPatchDown.TabStop = true;
            this.lnkPatchDown.Text = "Down";
            this.lnkPatchDown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPatchDown_LinkClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPatchWelcome);
            this.groupBox5.Location = new System.Drawing.Point(12, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(516, 238);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Patch Server Message";
            // 
            // chkUnlimited
            // 
            this.chkUnlimited.AutoSize = true;
            this.chkUnlimited.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUnlimited.Location = new System.Drawing.Point(211, 273);
            this.chkUnlimited.Name = "chkUnlimited";
            this.chkUnlimited.Size = new System.Drawing.Size(69, 17);
            this.chkUnlimited.TabIndex = 28;
            this.chkUnlimited.Text = "Unlimited";
            this.chkUnlimited.UseVisualStyleBackColor = true;
            this.chkUnlimited.CheckedChanged += new System.EventHandler(this.chkUnlimited_CheckedChanged);
            // 
            // nmPatchUpload
            // 
            this.nmPatchUpload.Location = new System.Drawing.Point(118, 270);
            this.nmPatchUpload.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmPatchUpload.Name = "nmPatchUpload";
            this.nmPatchUpload.Size = new System.Drawing.Size(87, 20);
            this.nmPatchUpload.TabIndex = 29;
            this.nmPatchUpload.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Patch speed (KB/s):";
            // 
            // btnPatchSave
            // 
            this.btnPatchSave.Location = new System.Drawing.Point(286, 268);
            this.btnPatchSave.Name = "btnPatchSave";
            this.btnPatchSave.Size = new System.Drawing.Size(243, 23);
            this.btnPatchSave.TabIndex = 27;
            this.btnPatchSave.TabStop = false;
            this.btnPatchSave.Text = "Save";
            this.btnPatchSave.UseVisualStyleBackColor = true;
            this.btnPatchSave.Click += new System.EventHandler(this.btnPatchSave_Click);
            // 
            // chkPatchRestart
            // 
            this.chkPatchRestart.AutoSize = true;
            this.chkPatchRestart.Location = new System.Drawing.Point(137, 3);
            this.chkPatchRestart.Name = "chkPatchRestart";
            this.chkPatchRestart.Size = new System.Drawing.Size(125, 17);
            this.chkPatchRestart.TabIndex = 24;
            this.chkPatchRestart.Text = "Restart Automatically";
            this.chkPatchRestart.UseVisualStyleBackColor = true;
            this.chkPatchRestart.CheckedChanged += new System.EventHandler(this.chkPatchRestart_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Patch Status:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tethealla Login Manager - Double click to show/hide ";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // txtPatchWelcome
            // 
            this.txtPatchWelcome.AcceptsTab = true;
            this.txtPatchWelcome.Location = new System.Drawing.Point(10, 19);
            this.txtPatchWelcome.Name = "txtPatchWelcome";
            this.txtPatchWelcome.Size = new System.Drawing.Size(493, 211);
            this.txtPatchWelcome.TabIndex = 27;
            this.txtPatchWelcome.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 327);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tethealla Login Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxShips)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmEclair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRappies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmLillies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMerissa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSlimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPazuzu)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmPatchUpload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nmMaxClients;
        private System.Windows.Forms.NumericUpDown nmPort;
        private System.Windows.Forms.NumericUpDown nmMaxShips;
        private System.Windows.Forms.TextBox txtPublicIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrivateIP;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmRappies;
        private System.Windows.Forms.NumericUpDown nmMerissa;
        private System.Windows.Forms.NumericUpDown nmSlimes;
        private System.Windows.Forms.NumericUpDown nmHild;
        private System.Windows.Forms.NumericUpDown nmPazuzu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveLogin;
        private System.Windows.Forms.NumericUpDown nmLillies;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkLoginRestart;
        private System.Windows.Forms.LinkLabel lnkLoginDown;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.LinkLabel lnkLoginRunning;
        private System.Windows.Forms.NumericUpDown nmKond;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nmEclair;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtGlobalGMName;
        private System.Windows.Forms.TextBox txtNormalName;
        private System.Windows.Forms.TextBox txtLocalGMName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkPatchRestart;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chkUnlimited;
        private System.Windows.Forms.NumericUpDown nmPatchUpload;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnPatchSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel lnkPatchDown;
        private System.Windows.Forms.LinkLabel lnkPatchRunning;
        private System.Windows.Forms.RichTextBox txtPatchWelcome;
    }
}

