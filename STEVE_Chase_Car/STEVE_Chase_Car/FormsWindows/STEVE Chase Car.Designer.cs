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
            this.Speed = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCurrentSpeed = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMotorPower = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Battery = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbStateOfCharge = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbBatteryHealth = new System.Windows.Forms.Label();
            this.Weather = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAirPressure = new System.Windows.Forms.Label();
            this.lbWindLevels = new System.Windows.Forms.Label();
            this.lbCrossWind = new System.Windows.Forms.Label();
            this.lbHeadWind = new System.Windows.Forms.Label();
            this.lbWindDirection = new System.Windows.Forms.Label();
            this.lbWindspeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbCurrentTemp = new System.Windows.Forms.Label();
            this.lbWeather = new System.Windows.Forms.Label();
            this.lbRainFall = new System.Windows.Forms.Label();
            this.lbCloudiness = new System.Windows.Forms.Label();
            this.lbUvIntensity = new System.Windows.Forms.Label();
            this.solarLocation = new System.Windows.Forms.TabPage();
            this.panelSolarLocationTL = new System.Windows.Forms.Panel();
            this.lbSunDistance = new System.Windows.Forms.Label();
            this.lbSunrise = new System.Windows.Forms.Label();
            this.lbSunset = new System.Windows.Forms.Label();
            this.lbSunAltitude = new System.Windows.Forms.Label();
            this.lbSunDirection = new System.Windows.Forms.Label();
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSolarLocationBL = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSunrisePicture = new System.Windows.Forms.Label();
            this.lbMeridianPicture = new System.Windows.Forms.Label();
            this.lbSunsetPicture = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxSolarLocation = new System.Windows.Forms.PictureBox();
            this.panelSolarLocationR = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.timer_rec_can = new System.Windows.Forms.Timer(this.components);
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
            this.bmS_PDO1TableAdapter1 = new STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.Overview = new System.Windows.Forms.TabPage();
            this.lbBatteryVoltage = new System.Windows.Forms.Label();
            this.lbBatteryCurrent = new System.Windows.Forms.Label();
            this.lbCharge = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbCurrentPeak = new System.Windows.Forms.Label();
            this.lbCellBalance = new System.Windows.Forms.Label();
            this.timerUpdateLables = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateWeatherSun = new System.Windows.Forms.Timer(this.components);
            this.mainScreenTabControl.SuspendLayout();
            this.Speed.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Battery.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.Weather.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.solarLocation.SuspendLayout();
            this.panelSolarLocationTL.SuspendLayout();
            this.panelSolarLocationBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).BeginInit();
            this.panelSolarLocationR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Dev.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.mainScreenMenuStrip.SuspendLayout();
            this.Overview.SuspendLayout();
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
            this.mainScreenTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mainScreenTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainScreenTabControl.ItemSize = new System.Drawing.Size(185, 32);
            this.mainScreenTabControl.Location = new System.Drawing.Point(2, 27);
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.Padding = new System.Drawing.Point(50, 10);
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1093, 646);
            this.mainScreenTabControl.TabIndex = 16;
            // 
            // Speed
            // 
            this.Speed.Controls.Add(this.panel3);
            this.Speed.Controls.Add(this.panel4);
            this.Speed.Location = new System.Drawing.Point(4, 36);
            this.Speed.Name = "Speed";
            this.Speed.Padding = new System.Windows.Forms.Padding(3);
            this.Speed.Size = new System.Drawing.Size(1085, 606);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "SPEED";
            this.Speed.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lbCurrentSpeed);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Location = new System.Drawing.Point(-2, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 606);
            this.panel3.TabIndex = 3;
            // 
            // lbCurrentSpeed
            // 
            this.lbCurrentSpeed.AutoSize = true;
            this.lbCurrentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCurrentSpeed.Location = new System.Drawing.Point(170, 75);
            this.lbCurrentSpeed.Name = "lbCurrentSpeed";
            this.lbCurrentSpeed.Size = new System.Drawing.Size(126, 20);
            this.lbCurrentSpeed.TabIndex = 2;
            this.lbCurrentSpeed.Text = "Current Speed";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(154, 136);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(158, 159);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel4.Controls.Add(this.lbMotorPower);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Location = new System.Drawing.Point(531, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 604);
            this.panel4.TabIndex = 2;
            // 
            // lbMotorPower
            // 
            this.lbMotorPower.AutoSize = true;
            this.lbMotorPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbMotorPower.ForeColor = System.Drawing.Color.White;
            this.lbMotorPower.Location = new System.Drawing.Point(230, 75);
            this.lbMotorPower.Name = "lbMotorPower";
            this.lbMotorPower.Size = new System.Drawing.Size(109, 20);
            this.lbMotorPower.TabIndex = 1;
            this.lbMotorPower.Text = "Motor Power";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(193, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(178, 146);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // Battery
            // 
            this.Battery.Controls.Add(this.panel5);
            this.Battery.Controls.Add(this.panel6);
            this.Battery.Location = new System.Drawing.Point(4, 36);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(1085, 606);
            this.Battery.TabIndex = 2;
            this.Battery.Text = "BATTERY";
            this.Battery.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lbCharge);
            this.panel5.Controls.Add(this.lbBatteryCurrent);
            this.panel5.Controls.Add(this.lbBatteryVoltage);
            this.panel5.Controls.Add(this.pictureBox8);
            this.panel5.Controls.Add(this.lbStateOfCharge);
            this.panel5.Location = new System.Drawing.Point(-2, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(529, 606);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(147, 138);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(175, 148);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 3;
            this.pictureBox8.TabStop = false;
            // 
            // lbStateOfCharge
            // 
            this.lbStateOfCharge.AutoSize = true;
            this.lbStateOfCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbStateOfCharge.Location = new System.Drawing.Point(171, 75);
            this.lbStateOfCharge.Name = "lbStateOfCharge";
            this.lbStateOfCharge.Size = new System.Drawing.Size(137, 20);
            this.lbStateOfCharge.TabIndex = 0;
            this.lbStateOfCharge.Text = "State of Charge";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.lbCellBalance);
            this.panel6.Controls.Add(this.lbCurrentPeak);
            this.panel6.Controls.Add(this.lbTemp);
            this.panel6.Controls.Add(this.pictureBox7);
            this.panel6.Controls.Add(this.lbBatteryHealth);
            this.panel6.Location = new System.Drawing.Point(531, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 604);
            this.panel6.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(197, 138);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(172, 148);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            // 
            // lbBatteryHealth
            // 
            this.lbBatteryHealth.AutoSize = true;
            this.lbBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbBatteryHealth.ForeColor = System.Drawing.Color.White;
            this.lbBatteryHealth.Location = new System.Drawing.Point(223, 75);
            this.lbBatteryHealth.Name = "lbBatteryHealth";
            this.lbBatteryHealth.Size = new System.Drawing.Size(125, 20);
            this.lbBatteryHealth.TabIndex = 1;
            this.lbBatteryHealth.Text = "Battery Health";
            // 
            // Weather
            // 
            this.Weather.Controls.Add(this.panel1);
            this.Weather.Controls.Add(this.panel2);
            this.Weather.Location = new System.Drawing.Point(4, 36);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(1085, 606);
            this.Weather.TabIndex = 3;
            this.Weather.Text = "WEATHER";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbAirPressure);
            this.panel1.Controls.Add(this.lbWindLevels);
            this.panel1.Controls.Add(this.lbCrossWind);
            this.panel1.Controls.Add(this.lbHeadWind);
            this.panel1.Controls.Add(this.lbWindDirection);
            this.panel1.Controls.Add(this.lbWindspeed);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-44, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 605);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Powered by: openweathermap.org";
            // 
            // lbAirPressure
            // 
            this.lbAirPressure.AutoSize = true;
            this.lbAirPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbAirPressure.Location = new System.Drawing.Point(231, 482);
            this.lbAirPressure.Name = "lbAirPressure";
            this.lbAirPressure.Size = new System.Drawing.Size(95, 20);
            this.lbAirPressure.TabIndex = 7;
            this.lbAirPressure.Text = "Air Pressure";
            // 
            // lbWindLevels
            // 
            this.lbWindLevels.AutoSize = true;
            this.lbWindLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWindLevels.Location = new System.Drawing.Point(159, 452);
            this.lbWindLevels.Name = "lbWindLevels";
            this.lbWindLevels.Size = new System.Drawing.Size(167, 20);
            this.lbWindLevels.TabIndex = 6;
            this.lbWindLevels.Text = "Estimated levels today";
            // 
            // lbCrossWind
            // 
            this.lbCrossWind.AutoSize = true;
            this.lbCrossWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCrossWind.Location = new System.Drawing.Point(176, 421);
            this.lbCrossWind.Name = "lbCrossWind";
            this.lbCrossWind.Size = new System.Drawing.Size(150, 20);
            this.lbCrossWind.TabIndex = 5;
            this.lbCrossWind.Text = "Solar car cross wind";
            // 
            // lbHeadWind
            // 
            this.lbHeadWind.AutoSize = true;
            this.lbHeadWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHeadWind.Location = new System.Drawing.Point(178, 392);
            this.lbHeadWind.Name = "lbHeadWind";
            this.lbHeadWind.Size = new System.Drawing.Size(148, 20);
            this.lbHeadWind.TabIndex = 4;
            this.lbHeadWind.Text = "Solar car head wind";
            // 
            // lbWindDirection
            // 
            this.lbWindDirection.AutoSize = true;
            this.lbWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWindDirection.Location = new System.Drawing.Point(157, 361);
            this.lbWindDirection.Name = "lbWindDirection";
            this.lbWindDirection.Size = new System.Drawing.Size(169, 20);
            this.lbWindDirection.TabIndex = 3;
            this.lbWindDirection.Text = "Current Wind Direction";
            // 
            // lbWindspeed
            // 
            this.lbWindspeed.AutoSize = true;
            this.lbWindspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWindspeed.Location = new System.Drawing.Point(184, 332);
            this.lbWindspeed.Name = "lbWindspeed";
            this.lbWindspeed.Size = new System.Drawing.Size(142, 20);
            this.lbWindspeed.TabIndex = 2;
            this.lbWindspeed.Text = "Current windspeed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(246, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Wind";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(161, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbHumidity);
            this.panel2.Controls.Add(this.lbCurrentTemp);
            this.panel2.Controls.Add(this.lbWeather);
            this.panel2.Controls.Add(this.lbRainFall);
            this.panel2.Controls.Add(this.lbCloudiness);
            this.panel2.Controls.Add(this.lbUvIntensity);
            this.panel2.Location = new System.Drawing.Point(534, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 614);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(219, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 119);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(232, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Weather";
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHumidity.ForeColor = System.Drawing.Color.White;
            this.lbHumidity.Location = new System.Drawing.Point(215, 482);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(70, 20);
            this.lbHumidity.TabIndex = 13;
            this.lbHumidity.Text = "Humidity";
            // 
            // lbCurrentTemp
            // 
            this.lbCurrentTemp.AutoSize = true;
            this.lbCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCurrentTemp.ForeColor = System.Drawing.Color.White;
            this.lbCurrentTemp.Location = new System.Drawing.Point(185, 452);
            this.lbCurrentTemp.Name = "lbCurrentTemp";
            this.lbCurrentTemp.Size = new System.Drawing.Size(100, 20);
            this.lbCurrentTemp.TabIndex = 12;
            this.lbCurrentTemp.Text = "Temperature";
            // 
            // lbWeather
            // 
            this.lbWeather.AutoSize = true;
            this.lbWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWeather.ForeColor = System.Drawing.Color.White;
            this.lbWeather.Location = new System.Drawing.Point(215, 392);
            this.lbWeather.Name = "lbWeather";
            this.lbWeather.Size = new System.Drawing.Size(70, 20);
            this.lbWeather.TabIndex = 11;
            this.lbWeather.Text = "Weather";
            // 
            // lbRainFall
            // 
            this.lbRainFall.AutoSize = true;
            this.lbRainFall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbRainFall.ForeColor = System.Drawing.Color.White;
            this.lbRainFall.Location = new System.Drawing.Point(223, 421);
            this.lbRainFall.Name = "lbRainFall";
            this.lbRainFall.Size = new System.Drawing.Size(62, 20);
            this.lbRainFall.TabIndex = 10;
            this.lbRainFall.Text = "Rainfall";
            // 
            // lbCloudiness
            // 
            this.lbCloudiness.AutoSize = true;
            this.lbCloudiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCloudiness.ForeColor = System.Drawing.Color.White;
            this.lbCloudiness.Location = new System.Drawing.Point(198, 361);
            this.lbCloudiness.Name = "lbCloudiness";
            this.lbCloudiness.Size = new System.Drawing.Size(87, 20);
            this.lbCloudiness.TabIndex = 9;
            this.lbCloudiness.Text = "Cloudiness";
            // 
            // lbUvIntensity
            // 
            this.lbUvIntensity.AutoSize = true;
            this.lbUvIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbUvIntensity.ForeColor = System.Drawing.Color.White;
            this.lbUvIntensity.Location = new System.Drawing.Point(189, 332);
            this.lbUvIntensity.Name = "lbUvIntensity";
            this.lbUvIntensity.Size = new System.Drawing.Size(96, 20);
            this.lbUvIntensity.TabIndex = 8;
            this.lbUvIntensity.Text = "UV Intensity";
            // 
            // solarLocation
            // 
            this.solarLocation.Controls.Add(this.panelSolarLocationTL);
            this.solarLocation.Controls.Add(this.panelSolarLocationBL);
            this.solarLocation.Controls.Add(this.panelSolarLocationR);
            this.solarLocation.Location = new System.Drawing.Point(4, 36);
            this.solarLocation.Name = "solarLocation";
            this.solarLocation.Size = new System.Drawing.Size(1085, 606);
            this.solarLocation.TabIndex = 5;
            this.solarLocation.Text = "SUN";
            this.solarLocation.UseVisualStyleBackColor = true;
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
            this.panelSolarLocationTL.Location = new System.Drawing.Point(0, 2);
            this.panelSolarLocationTL.Margin = new System.Windows.Forms.Padding(2);
            this.panelSolarLocationTL.Name = "panelSolarLocationTL";
            this.panelSolarLocationTL.Size = new System.Drawing.Size(716, 237);
            this.panelSolarLocationTL.TabIndex = 4;
            // 
            // lbSunDistance
            // 
            this.lbSunDistance.AutoSize = true;
            this.lbSunDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunDistance.Location = new System.Drawing.Point(435, 81);
            this.lbSunDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunDistance.Name = "lbSunDistance";
            this.lbSunDistance.Size = new System.Drawing.Size(109, 20);
            this.lbSunDistance.TabIndex = 6;
            this.lbSunDistance.Text = "Sun Distance:";
            // 
            // lbSunrise
            // 
            this.lbSunrise.AutoSize = true;
            this.lbSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunrise.Location = new System.Drawing.Point(435, 129);
            this.lbSunrise.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunrise.Name = "lbSunrise";
            this.lbSunrise.Size = new System.Drawing.Size(67, 20);
            this.lbSunrise.TabIndex = 5;
            this.lbSunrise.Text = "Sunrise:";
            // 
            // lbSunset
            // 
            this.lbSunset.AutoSize = true;
            this.lbSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunset.Location = new System.Drawing.Point(435, 173);
            this.lbSunset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunset.Name = "lbSunset";
            this.lbSunset.Size = new System.Drawing.Size(64, 20);
            this.lbSunset.TabIndex = 4;
            this.lbSunset.Text = "Sunset:";
            // 
            // lbSunAltitude
            // 
            this.lbSunAltitude.AutoSize = true;
            this.lbSunAltitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunAltitude.Location = new System.Drawing.Point(77, 173);
            this.lbSunAltitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunAltitude.Name = "lbSunAltitude";
            this.lbSunAltitude.Size = new System.Drawing.Size(100, 20);
            this.lbSunAltitude.TabIndex = 3;
            this.lbSunAltitude.Text = "Sun Altitude:";
            // 
            // lbSunDirection
            // 
            this.lbSunDirection.AutoSize = true;
            this.lbSunDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunDirection.Location = new System.Drawing.Point(77, 129);
            this.lbSunDirection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSunDirection.Name = "lbSunDirection";
            this.lbSunDirection.Size = new System.Drawing.Size(109, 20);
            this.lbSunDirection.TabIndex = 2;
            this.lbSunDirection.Text = "Sun Direction:";
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCurrentTime.Location = new System.Drawing.Point(77, 81);
            this.lbCurrentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(104, 20);
            this.lbCurrentTime.TabIndex = 1;
            this.lbCurrentTime.Text = "Current Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(287, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sunlight Today";
            // 
            // panelSolarLocationBL
            // 
            this.panelSolarLocationBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSolarLocationBL.Controls.Add(this.label10);
            this.panelSolarLocationBL.Controls.Add(this.lbSunrisePicture);
            this.panelSolarLocationBL.Controls.Add(this.lbMeridianPicture);
            this.panelSolarLocationBL.Controls.Add(this.lbSunsetPicture);
            this.panelSolarLocationBL.Controls.Add(this.label6);
            this.panelSolarLocationBL.Controls.Add(this.label5);
            this.panelSolarLocationBL.Controls.Add(this.label4);
            this.panelSolarLocationBL.Controls.Add(this.pictureBoxSolarLocation);
            this.panelSolarLocationBL.Location = new System.Drawing.Point(-2, 245);
            this.panelSolarLocationBL.Margin = new System.Windows.Forms.Padding(2);
            this.panelSolarLocationBL.Name = "panelSolarLocationBL";
            this.panelSolarLocationBL.Size = new System.Drawing.Size(717, 365);
            this.panelSolarLocationBL.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Powered by: sunrise-sunset.org";
            // 
            // lbSunrisePicture
            // 
            this.lbSunrisePicture.AutoSize = true;
            this.lbSunrisePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunrisePicture.Location = new System.Drawing.Point(579, 307);
            this.lbSunrisePicture.Name = "lbSunrisePicture";
            this.lbSunrisePicture.Size = new System.Drawing.Size(49, 20);
            this.lbSunrisePicture.TabIndex = 12;
            this.lbSunrisePicture.Text = "00:00";
            // 
            // lbMeridianPicture
            // 
            this.lbMeridianPicture.AutoSize = true;
            this.lbMeridianPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbMeridianPicture.Location = new System.Drawing.Point(321, 307);
            this.lbMeridianPicture.Name = "lbMeridianPicture";
            this.lbMeridianPicture.Size = new System.Drawing.Size(49, 20);
            this.lbMeridianPicture.TabIndex = 11;
            this.lbMeridianPicture.Text = "00:00";
            // 
            // lbSunsetPicture
            // 
            this.lbSunsetPicture.AutoSize = true;
            this.lbSunsetPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbSunsetPicture.Location = new System.Drawing.Point(79, 307);
            this.lbSunsetPicture.Name = "lbSunsetPicture";
            this.lbSunsetPicture.Size = new System.Drawing.Size(49, 20);
            this.lbSunsetPicture.TabIndex = 10;
            this.lbSunsetPicture.Text = "00:00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(579, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sunrise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(321, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Meridian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(79, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sunset";
            // 
            // pictureBoxSolarLocation
            // 
            this.pictureBoxSolarLocation.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSolarLocation.Image")));
            this.pictureBoxSolarLocation.InitialImage = null;
            this.pictureBoxSolarLocation.Location = new System.Drawing.Point(100, 115);
            this.pictureBoxSolarLocation.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSolarLocation.Name = "pictureBoxSolarLocation";
            this.pictureBoxSolarLocation.Size = new System.Drawing.Size(513, 170);
            this.pictureBoxSolarLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSolarLocation.TabIndex = 0;
            this.pictureBoxSolarLocation.TabStop = false;
            // 
            // panelSolarLocationR
            // 
            this.panelSolarLocationR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSolarLocationR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelSolarLocationR.Controls.Add(this.pictureBox1);
            this.panelSolarLocationR.Location = new System.Drawing.Point(720, -2);
            this.panelSolarLocationR.Margin = new System.Windows.Forms.Padding(2);
            this.panelSolarLocationR.Name = "panelSolarLocationR";
            this.panelSolarLocationR.Size = new System.Drawing.Size(368, 614);
            this.panelSolarLocationR.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.Dev.Location = new System.Drawing.Point(4, 36);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(1085, 606);
            this.Dev.TabIndex = 4;
            this.Dev.Text = "DEV";
            this.Dev.UseVisualStyleBackColor = true;
            // 
            // btnWeatherTest
            // 
            this.btnWeatherTest.Location = new System.Drawing.Point(150, 552);
            this.btnWeatherTest.Name = "btnWeatherTest";
            this.btnWeatherTest.Size = new System.Drawing.Size(109, 44);
            this.btnWeatherTest.TabIndex = 34;
            this.btnWeatherTest.Text = "Weather test";
            this.btnWeatherTest.UseVisualStyleBackColor = true;
            this.btnWeatherTest.Click += new System.EventHandler(this.btnWeatherTest_Click);
            // 
            // btnSunInfo
            // 
            this.btnSunInfo.Location = new System.Drawing.Point(6, 552);
            this.btnSunInfo.Name = "btnSunInfo";
            this.btnSunInfo.Size = new System.Drawing.Size(105, 44);
            this.btnSunInfo.TabIndex = 33;
            this.btnSunInfo.Text = "Sun Test";
            this.btnSunInfo.UseVisualStyleBackColor = true;
            this.btnSunInfo.Click += new System.EventHandler(this.btnSunInfo_Click);
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.Location = new System.Drawing.Point(762, 281);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(110, 23);
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
            this.groupBox1.Location = new System.Drawing.Point(481, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 210);
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
            this.dev_CANalyst_Console.Location = new System.Drawing.Point(87, 19);
            this.dev_CANalyst_Console.Name = "dev_CANalyst_Console";
            this.dev_CANalyst_Console.Size = new System.Drawing.Size(160, 184);
            this.dev_CANalyst_Console.TabIndex = 3;
            this.dev_CANalyst_Console.Text = "";
            // 
            // dev_CANalyst_btnSend
            // 
            this.dev_CANalyst_btnSend.Location = new System.Drawing.Point(6, 77);
            this.dev_CANalyst_btnSend.Name = "dev_CANalyst_btnSend";
            this.dev_CANalyst_btnSend.Size = new System.Drawing.Size(75, 23);
            this.dev_CANalyst_btnSend.TabIndex = 2;
            this.dev_CANalyst_btnSend.Text = "Send";
            this.dev_CANalyst_btnSend.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnSend.Click += new System.EventHandler(this.dev_CANalyst_btnSend_Click);
            // 
            // dev_CANalyst_btnDisconnect
            // 
            this.dev_CANalyst_btnDisconnect.Location = new System.Drawing.Point(6, 48);
            this.dev_CANalyst_btnDisconnect.Name = "dev_CANalyst_btnDisconnect";
            this.dev_CANalyst_btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.dev_CANalyst_btnDisconnect.TabIndex = 1;
            this.dev_CANalyst_btnDisconnect.Text = "Disconnect";
            this.dev_CANalyst_btnDisconnect.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnDisconnect.Click += new System.EventHandler(this.dev_CANalyst_btnDisconnect_Click);
            // 
            // dev_CANalyst_btnConnect
            // 
            this.dev_CANalyst_btnConnect.Location = new System.Drawing.Point(6, 19);
            this.dev_CANalyst_btnConnect.Name = "dev_CANalyst_btnConnect";
            this.dev_CANalyst_btnConnect.Size = new System.Drawing.Size(75, 23);
            this.dev_CANalyst_btnConnect.TabIndex = 0;
            this.dev_CANalyst_btnConnect.Text = "Connect";
            this.dev_CANalyst_btnConnect.UseVisualStyleBackColor = true;
            this.dev_CANalyst_btnConnect.Click += new System.EventHandler(this.dev_CANalyst_btnConnect_Click);
            // 
            // loadDataBTN
            // 
            this.loadDataBTN.Location = new System.Drawing.Point(622, 281);
            this.loadDataBTN.Name = "loadDataBTN";
            this.loadDataBTN.Size = new System.Drawing.Size(119, 23);
            this.loadDataBTN.TabIndex = 29;
            this.loadDataBTN.Text = "Load data - do not remove";
            this.loadDataBTN.UseVisualStyleBackColor = true;
            this.loadDataBTN.Click += new System.EventHandler(this.loadDataBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server:";
            // 
            // statusRTXB
            // 
            this.statusRTXB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusRTXB.Location = new System.Drawing.Point(482, 72);
            this.statusRTXB.Name = "statusRTXB";
            this.statusRTXB.Size = new System.Drawing.Size(260, 204);
            this.statusRTXB.TabIndex = 24;
            this.statusRTXB.Text = "";
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(525, 20);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(156, 23);
            this.TBserver.TabIndex = 25;
            // 
            // TBdatabase
            // 
            this.TBdatabase.Location = new System.Drawing.Point(540, 46);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(141, 23);
            this.TBdatabase.TabIndex = 26;
            // 
            // testBTN
            // 
            this.testBTN.Location = new System.Drawing.Point(482, 281);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(121, 23);
            this.testBTN.TabIndex = 23;
            this.testBTN.Text = "Connect DB -  do not remove";
            this.testBTN.UseVisualStyleBackColor = true;
            this.testBTN.Click += new System.EventHandler(this.testBTN_Click);
            // 
            // timer_rec_can
            // 
            this.timer_rec_can.Interval = 500;
            this.timer_rec_can.Tick += new System.EventHandler(this.timer_rec_Tick);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.helloToolStripMenuItem.Text = "hello";
            // 
            // hiToolStripMenuItem
            // 
            this.hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            this.hiToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
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
            this.mainScreenMenuStrip.Size = new System.Drawing.Size(1095, 24);
            this.mainScreenMenuStrip.TabIndex = 17;
            this.mainScreenMenuStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cANToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // cANToolStripMenuItem
            // 
            this.cANToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem});
            this.cANToolStripMenuItem.Name = "cANToolStripMenuItem";
            this.cANToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cANToolStripMenuItem.Text = "CAN";
            // 
            // communicationToolStripMenuItem
            // 
            this.communicationToolStripMenuItem.Name = "communicationToolStripMenuItem";
            this.communicationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.communicationToolStripMenuItem.Text = "Communication";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawViewToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // rawViewToolStripMenuItem
            // 
            this.rawViewToolStripMenuItem.Name = "rawViewToolStripMenuItem";
            this.rawViewToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.rawViewToolStripMenuItem.Text = "Raw view";
            this.rawViewToolStripMenuItem.Click += new System.EventHandler(this.rawViewToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem1});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // databaseToolStripMenuItem1
            // 
            this.databaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.databaseToolStripMenuItem1.Name = "databaseToolStripMenuItem1";
            this.databaseToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.databaseToolStripMenuItem1.Text = "Database";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // bmS_PDO1TableAdapter1
            // 
            this.bmS_PDO1TableAdapter1.ClearBeforeFill = true;
            // 
            // graphPanel
            // 
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(3, 3);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(1079, 600);
            this.graphPanel.TabIndex = 0;
            // 
            // Overview
            // 
            this.Overview.Controls.Add(this.graphPanel);
            this.Overview.Location = new System.Drawing.Point(4, 36);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(3);
            this.Overview.Size = new System.Drawing.Size(1085, 606);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Graph";
            this.Overview.UseVisualStyleBackColor = true;
            // 
            // lbBatteryVoltage
            // 
            this.lbBatteryVoltage.AutoSize = true;
            this.lbBatteryVoltage.Location = new System.Drawing.Point(144, 331);
            this.lbBatteryVoltage.Name = "lbBatteryVoltage";
            this.lbBatteryVoltage.Size = new System.Drawing.Size(125, 17);
            this.lbBatteryVoltage.TabIndex = 4;
            this.lbBatteryVoltage.Text = "Battery Voltage:";
            // 
            // lbBatteryCurrent
            // 
            this.lbBatteryCurrent.AutoSize = true;
            this.lbBatteryCurrent.Location = new System.Drawing.Point(144, 375);
            this.lbBatteryCurrent.Name = "lbBatteryCurrent";
            this.lbBatteryCurrent.Size = new System.Drawing.Size(124, 17);
            this.lbBatteryCurrent.TabIndex = 5;
            this.lbBatteryCurrent.Text = "Battery Current:";
            // 
            // lbCharge
            // 
            this.lbCharge.AutoSize = true;
            this.lbCharge.Location = new System.Drawing.Point(144, 420);
            this.lbCharge.Name = "lbCharge";
            this.lbCharge.Size = new System.Drawing.Size(125, 17);
            this.lbCharge.TabIndex = 6;
            this.lbCharge.Text = "State of charge:";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.ForeColor = System.Drawing.Color.White;
            this.lbTemp.Location = new System.Drawing.Point(194, 331);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(106, 17);
            this.lbTemp.TabIndex = 7;
            this.lbTemp.Text = "Temperature:";
            // 
            // lbCurrentPeak
            // 
            this.lbCurrentPeak.AutoSize = true;
            this.lbCurrentPeak.ForeColor = System.Drawing.Color.White;
            this.lbCurrentPeak.Location = new System.Drawing.Point(136, 375);
            this.lbCurrentPeak.Name = "lbCurrentPeak";
            this.lbCurrentPeak.Size = new System.Drawing.Size(164, 17);
            this.lbCurrentPeak.TabIndex = 8;
            this.lbCurrentPeak.Text = "Current Peak Avrage:";
            // 
            // lbCellBalance
            // 
            this.lbCellBalance.AutoSize = true;
            this.lbCellBalance.ForeColor = System.Drawing.Color.White;
            this.lbCellBalance.Location = new System.Drawing.Point(197, 420);
            this.lbCellBalance.Name = "lbCellBalance";
            this.lbCellBalance.Size = new System.Drawing.Size(103, 17);
            this.lbCellBalance.TabIndex = 9;
            this.lbCellBalance.Text = "Cell Balance:";
            // 
            // timerUpdateLables
            // 
            this.timerUpdateLables.Interval = 1000;
            this.timerUpdateLables.Tick += new System.EventHandler(this.timerUpdateLables_Tick);
            // 
            // timerUpdateWeatherSun
            // 
            this.timerUpdateWeatherSun.Interval = 300000;
            this.timerUpdateWeatherSun.Tick += new System.EventHandler(this.updateWeatherSun_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1095, 671);
            this.Controls.Add(this.mainScreenMenuStrip);
            this.Controls.Add(this.mainScreenTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainScreenMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1111, 710);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JU SOLAR TEAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.mainScreenTabControl.ResumeLayout(false);
            this.Speed.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Battery.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.Weather.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.solarLocation.ResumeLayout(false);
            this.panelSolarLocationTL.ResumeLayout(false);
            this.panelSolarLocationTL.PerformLayout();
            this.panelSolarLocationBL.ResumeLayout(false);
            this.panelSolarLocationBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).EndInit();
            this.panelSolarLocationR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Dev.ResumeLayout(false);
            this.Dev.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainScreenMenuStrip.ResumeLayout(false);
            this.mainScreenMenuStrip.PerformLayout();
            this.Overview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainScreenTabControl;
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
        public System.Windows.Forms.Timer timer_rec_can;
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
        private System.Windows.Forms.Label lbSunrisePicture;
        private System.Windows.Forms.Label lbMeridianPicture;
        private System.Windows.Forms.Label lbSunsetPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbAirPressure;
        private System.Windows.Forms.Label lbWindLevels;
        private System.Windows.Forms.Label lbCrossWind;
        private System.Windows.Forms.Label lbHeadWind;
        private System.Windows.Forms.Label lbWindDirection;
        private System.Windows.Forms.Label lbWindspeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbCurrentTemp;
        private System.Windows.Forms.Label lbWeather;
        private System.Windows.Forms.Label lbRainFall;
        private System.Windows.Forms.Label lbCloudiness;
        private System.Windows.Forms.Label lbUvIntensity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbCurrentSpeed;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbMotorPower;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label lbStateOfCharge;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbBatteryHealth;
        private STEVE_DatabaseDataSetTableAdapters.BMS_PDO1TableAdapter bmS_PDO1TableAdapter1;
        private System.Windows.Forms.TabPage Overview;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label lbCharge;
        private System.Windows.Forms.Label lbBatteryCurrent;
        private System.Windows.Forms.Label lbBatteryVoltage;
        private System.Windows.Forms.Label lbCellBalance;
        private System.Windows.Forms.Label lbCurrentPeak;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Timer timerUpdateLables;
        private System.Windows.Forms.Timer timerUpdateWeatherSun;
    }
}

