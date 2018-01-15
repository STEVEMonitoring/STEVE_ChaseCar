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
            this.graphPanel = new System.Windows.Forms.Panel();
            this.Speed = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbCurrentSpeed = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbMotorPower = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Battery = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbCharge = new System.Windows.Forms.Label();
            this.lbBatteryCurrent = new System.Windows.Forms.Label();
            this.lbBatteryVoltage = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.lbStateOfCharge = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbCellBalance = new System.Windows.Forms.Label();
            this.lbCurrentPeak = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbBatteryHealth = new System.Windows.Forms.Label();
            this.Weather = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAirPressure = new System.Windows.Forms.Label();
            this.lbCrossWind = new System.Windows.Forms.Label();
            this.lbHeadWind = new System.Windows.Forms.Label();
            this.lbWindDirection = new System.Windows.Forms.Label();
            this.lbWindspeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxWeather = new System.Windows.Forms.PictureBox();
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
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.grbPosition = new System.Windows.Forms.GroupBox();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            this.numlong = new System.Windows.Forms.NumericUpDown();
            this.numLat = new System.Windows.Forms.NumericUpDown();
            this.lbLong = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.Label();
            this.timer_rec_can = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainScreenMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cANToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rawViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdateLables = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateWeatherSun = new System.Windows.Forms.Timer(this.components);
            this.stevE_DatabaseDataSet1 = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.bmS_PDO1TableAdapter1 = new STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeather)).BeginInit();
            this.solarLocation.SuspendLayout();
            this.panelSolarLocationTL.SuspendLayout();
            this.panelSolarLocationBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).BeginInit();
            this.panelSolarLocationR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.grbPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numlong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.mainScreenMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).BeginInit();
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
            this.mainScreenTabControl.Controls.Add(this.tabSettings);
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
            // graphPanel
            // 
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(3, 3);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(1079, 600);
            this.graphPanel.TabIndex = 0;
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
            // lbCharge
            // 
            this.lbCharge.AutoSize = true;
            this.lbCharge.Location = new System.Drawing.Point(144, 420);
            this.lbCharge.Name = "lbCharge";
            this.lbCharge.Size = new System.Drawing.Size(125, 17);
            this.lbCharge.TabIndex = 6;
            this.lbCharge.Text = "State of charge:";
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
            // lbBatteryVoltage
            // 
            this.lbBatteryVoltage.AutoSize = true;
            this.lbBatteryVoltage.Location = new System.Drawing.Point(144, 331);
            this.lbBatteryVoltage.Name = "lbBatteryVoltage";
            this.lbBatteryVoltage.Size = new System.Drawing.Size(125, 17);
            this.lbBatteryVoltage.TabIndex = 4;
            this.lbBatteryVoltage.Text = "Battery Voltage:";
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
            // lbCurrentPeak
            // 
            this.lbCurrentPeak.AutoSize = true;
            this.lbCurrentPeak.ForeColor = System.Drawing.Color.White;
            this.lbCurrentPeak.Location = new System.Drawing.Point(136, 375);
            this.lbCurrentPeak.Name = "lbCurrentPeak";
            this.lbCurrentPeak.Size = new System.Drawing.Size(173, 17);
            this.lbCurrentPeak.TabIndex = 8;
            this.lbCurrentPeak.Text = "Current Peak Average:";
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
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbAirPressure);
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
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbLocation.Location = new System.Drawing.Point(248, 332);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(74, 20);
            this.lbLocation.TabIndex = 16;
            this.lbLocation.Text = "Location:";
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
            this.lbAirPressure.Location = new System.Drawing.Point(227, 481);
            this.lbAirPressure.Name = "lbAirPressure";
            this.lbAirPressure.Size = new System.Drawing.Size(95, 20);
            this.lbAirPressure.TabIndex = 7;
            this.lbAirPressure.Text = "Air Pressure";
            // 
            // lbCrossWind
            // 
            this.lbCrossWind.AutoSize = true;
            this.lbCrossWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCrossWind.Location = new System.Drawing.Point(174, 450);
            this.lbCrossWind.Name = "lbCrossWind";
            this.lbCrossWind.Size = new System.Drawing.Size(150, 20);
            this.lbCrossWind.TabIndex = 5;
            this.lbCrossWind.Text = "Solar car cross wind";
            // 
            // lbHeadWind
            // 
            this.lbHeadWind.AutoSize = true;
            this.lbHeadWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbHeadWind.Location = new System.Drawing.Point(176, 421);
            this.lbHeadWind.Name = "lbHeadWind";
            this.lbHeadWind.Size = new System.Drawing.Size(148, 20);
            this.lbHeadWind.TabIndex = 4;
            this.lbHeadWind.Text = "Solar car head wind";
            // 
            // lbWindDirection
            // 
            this.lbWindDirection.AutoSize = true;
            this.lbWindDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWindDirection.Location = new System.Drawing.Point(155, 390);
            this.lbWindDirection.Name = "lbWindDirection";
            this.lbWindDirection.Size = new System.Drawing.Size(169, 20);
            this.lbWindDirection.TabIndex = 3;
            this.lbWindDirection.Text = "Current Wind Direction";
            // 
            // lbWindspeed
            // 
            this.lbWindspeed.AutoSize = true;
            this.lbWindspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbWindspeed.Location = new System.Drawing.Point(178, 361);
            this.lbWindspeed.Name = "lbWindspeed";
            this.lbWindspeed.Size = new System.Drawing.Size(146, 20);
            this.lbWindspeed.TabIndex = 2;
            this.lbWindspeed.Text = "Current wind speed";
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
            this.panel2.Controls.Add(this.picBoxWeather);
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
            // picBoxWeather
            // 
            this.picBoxWeather.Location = new System.Drawing.Point(219, 107);
            this.picBoxWeather.Name = "picBoxWeather";
            this.picBoxWeather.Size = new System.Drawing.Size(126, 119);
            this.picBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWeather.TabIndex = 8;
            this.picBoxWeather.TabStop = false;
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.grbPosition);
            this.tabSettings.Location = new System.Drawing.Point(4, 36);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(1085, 606);
            this.tabSettings.TabIndex = 4;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // grbPosition
            // 
            this.grbPosition.Controls.Add(this.btnUpdateLocation);
            this.grbPosition.Controls.Add(this.numlong);
            this.grbPosition.Controls.Add(this.numLat);
            this.grbPosition.Controls.Add(this.lbLong);
            this.grbPosition.Controls.Add(this.lbLat);
            this.grbPosition.Location = new System.Drawing.Point(6, 3);
            this.grbPosition.Name = "grbPosition";
            this.grbPosition.Size = new System.Drawing.Size(238, 133);
            this.grbPosition.TabIndex = 0;
            this.grbPosition.TabStop = false;
            this.grbPosition.Text = "Position";
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Location = new System.Drawing.Point(152, 93);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(80, 34);
            this.btnUpdateLocation.TabIndex = 4;
            this.btnUpdateLocation.Text = "Update";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // numlong
            // 
            this.numlong.DecimalPlaces = 5;
            this.numlong.Location = new System.Drawing.Point(112, 64);
            this.numlong.Name = "numlong";
            this.numlong.Size = new System.Drawing.Size(120, 23);
            this.numlong.TabIndex = 3;
            this.numlong.Value = new decimal(new int[] {
            14163330,
            0,
            0,
            393216});
            // 
            // numLat
            // 
            this.numLat.DecimalPlaces = 5;
            this.numLat.Location = new System.Drawing.Point(112, 27);
            this.numLat.Name = "numLat";
            this.numLat.Size = new System.Drawing.Size(120, 23);
            this.numLat.TabIndex = 1;
            this.numLat.Value = new decimal(new int[] {
            57778353,
            0,
            0,
            393216});
            // 
            // lbLong
            // 
            this.lbLong.AutoSize = true;
            this.lbLong.Location = new System.Drawing.Point(6, 66);
            this.lbLong.Name = "lbLong";
            this.lbLong.Size = new System.Drawing.Size(80, 17);
            this.lbLong.TabIndex = 2;
            this.lbLong.Text = "Longitude";
            // 
            // lbLat
            // 
            this.lbLat.AutoSize = true;
            this.lbLat.Location = new System.Drawing.Point(6, 29);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(67, 17);
            this.lbLat.TabIndex = 0;
            this.lbLat.Text = "Latitude";
            // 
            // timer_rec_can
            // 
            this.timer_rec_can.Interval = 500;
            this.timer_rec_can.Tick += new System.EventHandler(this.timer_rec_Tick);
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
            this.toolsToolStripMenuItem1});
            this.mainScreenMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainScreenMenuStrip.Name = "mainScreenMenuStrip";
            this.mainScreenMenuStrip.Size = new System.Drawing.Size(1095, 24);
            this.mainScreenMenuStrip.TabIndex = 17;
            this.mainScreenMenuStrip.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem1
            // 
            this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cANToolStripMenuItem1,
            this.databaseToolStripMenuItem2});
            this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
            this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem1.Text = "Tools";
            // 
            // cANToolStripMenuItem1
            // 
            this.cANToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.communicationToolStripMenuItem1});
            this.cANToolStripMenuItem1.Name = "cANToolStripMenuItem1";
            this.cANToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cANToolStripMenuItem1.Text = "CAN";
            // 
            // communicationToolStripMenuItem1
            // 
            this.communicationToolStripMenuItem1.Name = "communicationToolStripMenuItem1";
            this.communicationToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.communicationToolStripMenuItem1.Text = "Communication";
            this.communicationToolStripMenuItem1.Click += new System.EventHandler(this.communicationToolStripMenuItem1_Click);
            // 
            // databaseToolStripMenuItem2
            // 
            this.databaseToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem1,
            this.rawViewToolStripMenuItem1});
            this.databaseToolStripMenuItem2.Name = "databaseToolStripMenuItem2";
            this.databaseToolStripMenuItem2.Size = new System.Drawing.Size(125, 22);
            this.databaseToolStripMenuItem2.Text = "Database";
            // 
            // chartToolStripMenuItem1
            // 
            this.chartToolStripMenuItem1.Name = "chartToolStripMenuItem1";
            this.chartToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.chartToolStripMenuItem1.Text = "Chart";
            this.chartToolStripMenuItem1.Click += new System.EventHandler(this.chartToolStripMenuItem1_Click);
            // 
            // rawViewToolStripMenuItem1
            // 
            this.rawViewToolStripMenuItem1.Name = "rawViewToolStripMenuItem1";
            this.rawViewToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.rawViewToolStripMenuItem1.Text = "Raw View";
            this.rawViewToolStripMenuItem1.Click += new System.EventHandler(this.rawViewToolStripMenuItem1_Click);
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
            this.cANToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
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
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // rawViewToolStripMenuItem
            // 
            this.rawViewToolStripMenuItem.Name = "rawViewToolStripMenuItem";
            this.rawViewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rawViewToolStripMenuItem.Text = "Raw view";
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
            this.databaseToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.databaseToolStripMenuItem1.Text = "Database";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.chartToolStripMenuItem.Text = "Chart";
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
            // stevE_DatabaseDataSet1
            // 
            this.stevE_DatabaseDataSet1.DataSetName = "STEVE_DatabaseDataSet";
            this.stevE_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bmS_PDO1TableAdapter1
            // 
            this.bmS_PDO1TableAdapter1.ClearBeforeFill = true;
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
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWeather)).EndInit();
            this.solarLocation.ResumeLayout(false);
            this.panelSolarLocationTL.ResumeLayout(false);
            this.panelSolarLocationTL.PerformLayout();
            this.panelSolarLocationBL.ResumeLayout(false);
            this.panelSolarLocationBL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSolarLocation)).EndInit();
            this.panelSolarLocationR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.grbPosition.ResumeLayout(false);
            this.grbPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numlong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLat)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.mainScreenMenuStrip.ResumeLayout(false);
            this.mainScreenMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stevE_DatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl mainScreenTabControl;
        private System.Windows.Forms.TabPage Speed;
        private System.Windows.Forms.TabPage Battery;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage solarLocation;
        public System.Windows.Forms.Timer timer_rec_can;
        private STEVE_DatabaseDataSet stevE_DatabaseDataSet1;
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
        private System.Windows.Forms.Label lbCrossWind;
        private System.Windows.Forms.Label lbHeadWind;
        private System.Windows.Forms.Label lbWindDirection;
        private System.Windows.Forms.Label lbWindspeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxWeather;
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
        private System.Windows.Forms.GroupBox grbPosition;
        private System.Windows.Forms.Label lbLong;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.NumericUpDown numLat;
        private System.Windows.Forms.NumericUpDown numlong;
        private System.Windows.Forms.Button btnUpdateLocation;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cANToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rawViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem communicationToolStripMenuItem1;
    }
}

