namespace STEVE_Chase_Car
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
            this.mainScreenTabControl = new System.Windows.Forms.TabControl();
            this.Overview = new System.Windows.Forms.TabPage();
            this.Speed = new System.Windows.Forms.TabPage();
            this.Battery = new System.Windows.Forms.TabPage();
            this.Weather = new System.Windows.Forms.TabPage();
            this.solarLocation = new System.Windows.Forms.TabPage();
            this.Dev = new System.Windows.Forms.TabPage();
            this.btnWeatherTest = new System.Windows.Forms.Button();
            this.btnSunInfo = new System.Windows.Forms.Button();
            this.btnCreateTables = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dev_CANalyst_Console = new System.Windows.Forms.RichTextBox();
            this.dev_CANalyst_btnSend = new System.Windows.Forms.Button();
            this.dev_CANalyst_btnDisconnect = new System.Windows.Forms.Button();
            this.dev_CANalyst_btnConnect = new System.Windows.Forms.Button();
            this.loadDataBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusRTXB = new System.Windows.Forms.RichTextBox();
            this.TBserver = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.testBTN = new System.Windows.Forms.Button();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.stevE_DatabaseDataSet1 = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelOverviewRight = new System.Windows.Forms.Panel();
            this.panelOverviewLeft = new System.Windows.Forms.Panel();
            this.panelSolarLocationBL = new System.Windows.Forms.Panel();
            this.panelSolarLocationR = new System.Windows.Forms.Panel();
            this.pictureBoxSolarLocation = new System.Windows.Forms.PictureBox();
            this.panelSolarLocationTL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.lbSunDirection = new System.Windows.Forms.Label();
            this.lbSunAltitude = new System.Windows.Forms.Label();
            this.lbSunset = new System.Windows.Forms.Label();
            this.lbSunrise = new System.Windows.Forms.Label();
            this.lbSunDistance = new System.Windows.Forms.Label();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview.SuspendLayout();
            this.solarLocation.SuspendLayout();
            this.Dev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.mainScreenMenuStrip.SuspendLayout();
            this.panelSolarLocationBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).BeginInit();
            this.panelSolarLocationTL.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainScreenTabControl
            // 
            this.mainScreenTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainScreenTabControl.Controls.Add(this.Overview);
            this.mainScreenTabControl.Controls.Add(this.Speed);
            this.mainScreenTabControl.Controls.Add(this.Battery);
            this.mainScreenTabControl.Controls.Add(this.Weather);
            this.mainScreenTabControl.Controls.Add(this.solarLocation);
            this.mainScreenTabControl.Controls.Add(this.Dev);
            this.mainScreenTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainScreenTabControl.Location = new System.Drawing.Point(3, 32);
            this.mainScreenTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainScreenTabControl.Multiline = true;
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.Padding = new System.Drawing.Point(70, 10);
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1457, 795);
            this.mainScreenTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainScreenTabControl.TabIndex = 16;
            // 
            // Overview
            // 
            this.Overview.Controls.Add(this.panelOverviewLeft);
            this.Overview.Controls.Add(this.panelOverviewRight);
            this.Overview.Location = new System.Drawing.Point(4, 39);
            this.Overview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Overview.Size = new System.Drawing.Size(1449, 752);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Overview";
            this.Overview.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(4, 39);
            this.Speed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Speed.Name = "Speed";
            this.Speed.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Speed.Size = new System.Drawing.Size(1449, 752);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "Speed";
            this.Speed.UseVisualStyleBackColor = true;
            // 
            // Battery
            // 
            this.Battery.Location = new System.Drawing.Point(4, 39);
            this.Battery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(1449, 752);
            this.Battery.TabIndex = 2;
            this.Battery.Text = "Battery";
            this.Battery.UseVisualStyleBackColor = true;
            // 
            // Weather
            // 
            this.Weather.Location = new System.Drawing.Point(4, 39);
            this.Weather.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(1449, 752);
            this.Weather.TabIndex = 3;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // solarLocation
            // 
            this.solarLocation.Controls.Add(this.panelSolarLocationTL);
            this.solarLocation.Controls.Add(this.panelSolarLocationBL);
            this.solarLocation.Controls.Add(this.panelSolarLocationR);
            this.solarLocation.Location = new System.Drawing.Point(4, 39);
            this.solarLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.solarLocation.Name = "solarLocation";
            this.solarLocation.Size = new System.Drawing.Size(1449, 752);
            this.solarLocation.TabIndex = 5;
            this.solarLocation.Text = "Solar Location";
            this.solarLocation.UseVisualStyleBackColor = true;
            // 
            // Dev
            // 
            this.Dev.Controls.Add(this.btnWeatherTest);
            this.Dev.Controls.Add(this.btnSunInfo);
            this.Dev.Controls.Add(this.btnCreateTables);
            this.Dev.Controls.Add(this.groupBox1);
            this.Dev.Controls.Add(this.loadDataBTN);
            this.Dev.Controls.Add(this.label2);
            this.Dev.Controls.Add(this.label1);
            this.Dev.Controls.Add(this.statusRTXB);
            this.Dev.Controls.Add(this.TBserver);
            this.Dev.Controls.Add(this.TBdatabase);
            this.Dev.Controls.Add(this.testBTN);
            this.Dev.Location = new System.Drawing.Point(4, 39);
            this.Dev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(1449, 752);
            this.Dev.TabIndex = 4;
            this.Dev.Text = "Dev";
            this.Dev.UseVisualStyleBackColor = true;
            // 
            // btnWeatherTest
            // 
            this.btnWeatherTest.Location = new System.Drawing.Point(200, 679);
            this.btnWeatherTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWeatherTest.Name = "btnWeatherTest";
            this.btnWeatherTest.Size = new System.Drawing.Size(145, 54);
            this.btnWeatherTest.TabIndex = 34;
            this.btnWeatherTest.Text = "Weather test";
            this.btnWeatherTest.UseVisualStyleBackColor = true;
            this.btnWeatherTest.Click += new System.EventHandler(this.btnWeatherTest_Click);
            // 
            // btnSunInfo
            // 
            this.btnSunInfo.Location = new System.Drawing.Point(8, 679);
            this.btnSunInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSunInfo.Name = "btnSunInfo";
            this.btnSunInfo.Size = new System.Drawing.Size(140, 54);
            this.btnSunInfo.TabIndex = 33;
            this.btnSunInfo.Text = "Sun Test";
            this.btnSunInfo.UseVisualStyleBackColor = true;
            this.btnSunInfo.Click += new System.EventHandler(this.btnSunInfo_Click);
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.Location = new System.Drawing.Point(1016, 346);
            this.btnCreateTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(147, 28);
            this.btnCreateTables.TabIndex = 32;
            this.btnCreateTables.Text = "Create Tables";
            this.btnCreateTables.UseVisualStyleBackColor = true;
            this.btnCreateTables.Click += new System.EventHandler(this.btnCreateTables_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dev_CANalyst_Console);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnSend);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnDisconnect);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(641, 463);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(596, 258);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "dev_CANalyst";
            // 
            // dev_CANalyst_Console
            // 
            this.dev_CANalyst_Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dev_CANalyst_Console.BackColor = System.Drawing.Color.SlateGray;
            this.dev_CANalyst_Console.ForeColor = System.Drawing.Color.Gold;
            this.dev_CANalyst_Console.Location = new System.Drawing.Point(116, 23);
            this.dev_CANalyst_Console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dev_CANalyst_Console.Name = "dev_CANalyst_Console";
            this.dev_CANalyst_Console.Size = new System.Drawing.Size(212, 226);
            this.dev_CANalyst_Console.TabIndex = 3;
            this.dev_CANalyst_Console.Text = "";
            // 
            // dev_CANalyst_btnSend
            // 
            this.dev_CANalyst_btnSend.Location = new System.Drawing.Point(8, 95);
            this.dev_CANalyst_btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dev_CANalyst_btnSend.Name = "dev_CANalyst_btnSend";
            this.dev_CANalyst_btnSend.Size = new System.Drawing.Size(100, 28);
            this.dev_CANalyst_btnSend.TabIndex = 2;
            this.dev_CANalyst_btnSend.Text = "Send";
            this.dev_CANalyst_btnSend.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnSend.Click += new System.EventHandler(this.dev_CANalyst_btnSend_Click);
            // 
            // dev_CANalyst_btnDisconnect
            // 
            this.dev_CANalyst_btnDisconnect.Location = new System.Drawing.Point(8, 59);
            this.dev_CANalyst_btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dev_CANalyst_btnDisconnect.Name = "dev_CANalyst_btnDisconnect";
            this.dev_CANalyst_btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.dev_CANalyst_btnDisconnect.TabIndex = 1;
            this.dev_CANalyst_btnDisconnect.Text = "Disconnect";
            this.dev_CANalyst_btnDisconnect.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnDisconnect.Click += new System.EventHandler(this.dev_CANalyst_btnDisconnect_Click);
            // 
            // dev_CANalyst_btnConnect
            // 
            this.dev_CANalyst_btnConnect.Location = new System.Drawing.Point(8, 23);
            this.dev_CANalyst_btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dev_CANalyst_btnConnect.Name = "dev_CANalyst_btnConnect";
            this.dev_CANalyst_btnConnect.Size = new System.Drawing.Size(100, 28);
            this.dev_CANalyst_btnConnect.TabIndex = 0;
            this.dev_CANalyst_btnConnect.Text = "Connect";
            this.dev_CANalyst_btnConnect.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnConnect.Click += new System.EventHandler(this.dev_CANalyst_btnConnect_Click);
            // 
            // loadDataBTN
            // 
            this.loadDataBTN.Location = new System.Drawing.Point(829, 346);
            this.loadDataBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadDataBTN.Name = "loadDataBTN";
            this.loadDataBTN.Size = new System.Drawing.Size(159, 28);
            this.loadDataBTN.TabIndex = 29;
            this.loadDataBTN.Text = "Load data - do not remove";
            this.loadDataBTN.UseVisualStyleBackColor = true;
            this.loadDataBTN.Click += new System.EventHandler(this.loadDataBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server:";
            // 
            // statusRTXB
            // 
            this.statusRTXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusRTXB.Location = new System.Drawing.Point(643, 89);
            this.statusRTXB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusRTXB.Name = "statusRTXB";
            this.statusRTXB.Size = new System.Drawing.Size(345, 250);
            this.statusRTXB.TabIndex = 24;
            this.statusRTXB.Text = "";
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(700, 25);
            this.TBserver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(207, 22);
            this.TBserver.TabIndex = 25;
            // 
            // TBdatabase
            // 
            this.TBdatabase.Location = new System.Drawing.Point(720, 57);
            this.TBdatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(187, 22);
            this.TBdatabase.TabIndex = 26;
            // 
            // testBTN
            // 
            this.testBTN.Location = new System.Drawing.Point(643, 346);
            this.testBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(161, 28);
            this.testBTN.TabIndex = 23;
            this.testBTN.Text = "Connect DB -  do not remove";
            this.testBTN.UseVisualStyleBackColor = true;
            this.testBTN.Click += new System.EventHandler(this.testBTN_Click);
            // 
            // timer_rec
            // 
            this.timer_rec.Interval = 500;
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // stevE_DatabaseDataSet1
            // 
            this.stevE_DatabaseDataSet1.DataSetName = "STEVE_DatabaseDataSet";
            this.stevE_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.hiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 52);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.helloToolStripMenuItem.Text = "hello";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.hiToolStripMenuItem.Text = "hi";
            // 
            // mainScreenMenuStrip
            // 
            this.mainScreenMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.mainScreenMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mainScreenMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainScreenMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.mainScreenMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainScreenMenuStrip.Name = "mainScreenMenuStrip";
            this.mainScreenMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainScreenMenuStrip.Size = new System.Drawing.Size(1460, 28);
            this.mainScreenMenuStrip.TabIndex = 17;
            this.mainScreenMenuStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cANToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // cANToolStripMenuItem
            // 
            this.cANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem});
            this.cANToolStripMenuItem.Name = "cANToolStripMenuItem";
            this.cANToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.cANToolStripMenuItem.Text = "CAN";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.communicationToolStripMenuItem.Text = "Communication";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawViewToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // rawViewToolStripMenuItem
            // 
            this.rawViewToolStripMenuItem.Name = "rawViewToolStripMenuItem";
            this.rawViewToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.rawViewToolStripMenuItem.Text = "Raw view";
            this.rawViewToolStripMenuItem.Click += new System.EventHandler(this.rawViewToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem1});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // databaseToolStripMenuItem1
            // 
            this.databaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.databaseToolStripMenuItem1.Name = "databaseToolStripMenuItem1";
            this.databaseToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.databaseToolStripMenuItem1.Text = "Database";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // panelOverviewRight
            // 
            this.panelOverviewRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOverviewRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelOverviewRight.Location = new System.Drawing.Point(923, 0);
            this.panelOverviewRight.Name = "panelOverviewRight";
            this.panelOverviewRight.Size = new System.Drawing.Size(526, 756);
            this.panelOverviewRight.TabIndex = 0;
            // 
            // panelOverviewLeft
            // 
            this.panelOverviewLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOverviewLeft.Location = new System.Drawing.Point(-4, 0);
            this.panelOverviewLeft.Name = "panelOverviewLeft";
            this.panelOverviewLeft.Size = new System.Drawing.Size(921, 752);
            this.panelOverviewLeft.TabIndex = 1;
            // 
            // panelSolarLocationBL
            // 
            this.panelSolarLocationBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSolarLocationBL.Controls.Add(this.pictureBoxSolarLocation);
            this.panelSolarLocationBL.Location = new System.Drawing.Point(-2, 301);
            this.panelSolarLocationBL.Name = "panelSolarLocationBL";
            this.panelSolarLocationBL.Size = new System.Drawing.Size(956, 449);
            this.panelSolarLocationBL.TabIndex = 3;
            // 
            // panelSolarLocationR
            // 
            this.panelSolarLocationR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSolarLocationR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelSolarLocationR.Location = new System.Drawing.Point(960, -2);
            this.panelSolarLocationR.Name = "panelSolarLocationR";
            this.panelSolarLocationR.Size = new System.Drawing.Size(491, 756);
            this.panelSolarLocationR.TabIndex = 2;
            // 
            // pictureBoxSolarLocation
            // 
            this.pictureBoxSolarLocation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSolarLocation.Image")));
            this.pictureBoxSolarLocation.InitialImage = null;
            this.pictureBoxSolarLocation.Location = new System.Drawing.Point(134, 142);
            this.pictureBoxSolarLocation.Name = "pictureBoxSolarLocation";
            this.pictureBoxSolarLocation.Size = new System.Drawing.Size(684, 209);
            this.pictureBoxSolarLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSolarLocation.TabIndex = 0;
            this.pictureBoxSolarLocation.TabStop = false;
            // 
            // panelSolarLocationTL
            // 
            this.panelSolarLocationTL.Controls.Add(this.lbSunDistance);
            this.panelSolarLocationTL.Controls.Add(this.lbSunrise);
            this.panelSolarLocationTL.Controls.Add(this.lbSunset);
            this.panelSolarLocationTL.Controls.Add(this.lbSunAltitude);
            this.panelSolarLocationTL.Controls.Add(this.lbSunDirection);
            this.panelSolarLocationTL.Controls.Add(this.lbCurrentTime);
            this.panelSolarLocationTL.Controls.Add(this.label3);
            this.panelSolarLocationTL.Location = new System.Drawing.Point(0, 3);
            this.panelSolarLocationTL.Name = "panelSolarLocationTL";
            this.panelSolarLocationTL.Size = new System.Drawing.Size(954, 292);
            this.panelSolarLocationTL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Location = new System.Drawing.Point(103, 105);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(46, 17);
            this.lbCurrentTime.TabIndex = 1;
            this.lbCurrentTime.Text = "label4";
            // 
            // lbSunDirection
            // 
            this.lbSunDirection.AutoSize = true;
            this.lbSunDirection.Location = new System.Drawing.Point(103, 136);
            this.lbSunDirection.Name = "lbSunDirection";
            this.lbSunDirection.Size = new System.Drawing.Size(46, 17);
            this.lbSunDirection.TabIndex = 2;
            this.lbSunDirection.Text = "label5";
            // 
            // lbSunAltitude
            // 
            this.lbSunAltitude.AutoSize = true;
            this.lbSunAltitude.Location = new System.Drawing.Point(103, 185);
            this.lbSunAltitude.Name = "lbSunAltitude";
            this.lbSunAltitude.Size = new System.Drawing.Size(46, 17);
            this.lbSunAltitude.TabIndex = 3;
            this.lbSunAltitude.Text = "label6";
            // 
            // lbSunset
            // 
            this.lbSunset.AutoSize = true;
            this.lbSunset.Location = new System.Drawing.Point(600, 160);
            this.lbSunset.Name = "lbSunset";
            this.lbSunset.Size = new System.Drawing.Size(46, 17);
            this.lbSunset.TabIndex = 4;
            this.lbSunset.Text = "label7";
            // 
            // lbSunrise
            // 
            this.lbSunrise.AutoSize = true;
            this.lbSunrise.Location = new System.Drawing.Point(600, 124);
            this.lbSunrise.Name = "lbSunrise";
            this.lbSunrise.Size = new System.Drawing.Size(46, 17);
            this.lbSunrise.TabIndex = 5;
            this.lbSunrise.Text = "label8";
            // 
            // lbSunDistance
            // 
            this.lbSunDistance.AutoSize = true;
            this.lbSunDistance.Location = new System.Drawing.Point(600, 93);
            this.lbSunDistance.Name = "lbSunDistance";
            this.lbSunDistance.Size = new System.Drawing.Size(46, 17);
            this.lbSunDistance.TabIndex = 6;
            this.lbSunDistance.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1460, 826);
            this.Controls.Add(this.mainScreenMenuStrip);
            this.Controls.Add(this.mainScreenTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainScreenMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1475, 863);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEVE Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview.ResumeLayout(false);
            this.solarLocation.ResumeLayout(false);
            this.Dev.ResumeLayout(false);
            this.Dev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainScreenMenuStrip.ResumeLayout(false);
            this.mainScreenMenuStrip.PerformLayout();
            this.panelSolarLocationBL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).EndInit();
            this.panelSolarLocationTL.ResumeLayout(false);
            this.panelSolarLocationTL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainScreenTabControl;
        private System.Windows.Forms.TabPage Overview;
        private System.Windows.Forms.TabPage Speed;
        private System.Windows.Forms.TabPage Battery;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Dev;
        private System.Windows.Forms.Button testBTN;
        private System.Windows.Forms.TextBox TBdatabase;
        private System.Windows.Forms.TextBox TBserver;
        private System.Windows.Forms.RichTextBox statusRTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadDataBTN;
        private System.Windows.Forms.TabPage solarLocation;
        public System.Windows.Forms.Timer timer_rec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dev_CANalyst_btnConnect;
        private System.Windows.Forms.Button dev_CANalyst_btnDisconnect;
        private System.Windows.Forms.Button dev_CANalyst_btnSend;
        private System.Windows.Forms.RichTextBox dev_CANalyst_Console;
        private STEVE_DatabaseDataSet stevE_DatabaseDataSet1;
        private System.Windows.Forms.Button btnCreateTables;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainScreenMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.Button btnSunInfo;
        private System.Windows.Forms.Button btnWeatherTest;
        private System.Windows.Forms.Panel panelOverviewLeft;
        private System.Windows.Forms.Panel panelOverviewRight;
        private System.Windows.Forms.PictureBox pictureBoxSolarLocation;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panelSolarLocationTL;
        public System.Windows.Forms.Panel panelSolarLocationBL;
        public System.Windows.Forms.Panel panelSolarLocationR;
        private System.Windows.Forms.Label lbSunDistance;
        private System.Windows.Forms.Label lbSunrise;
        private System.Windows.Forms.Label lbSunset;
        private System.Windows.Forms.Label lbSunAltitude;
        private System.Windows.Forms.Label lbSunDirection;
        private System.Windows.Forms.Label lbCurrentTime;
    }
}

