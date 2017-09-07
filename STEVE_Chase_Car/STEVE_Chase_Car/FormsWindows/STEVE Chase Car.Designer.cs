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
            this.weatherBrowser = new System.Windows.Forms.WebBrowser();
            this.solarLocation = new System.Windows.Forms.TabPage();
            this.solarBrowser = new System.Windows.Forms.WebBrowser();
            this.Dev = new System.Windows.Forms.TabPage();
            this.btnReloadBrowsers = new System.Windows.Forms.Button();
            this.loadDataBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusRTXB = new System.Windows.Forms.RichTextBox();
            this.TBserver = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.testBTN = new System.Windows.Forms.Button();
            this.bMS_PDO1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTEVE_databaseDataSet = new STEVE_Chase_Car.STEVE_databaseDataSet();
            this.bMS_PDO1TableAdapter = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.tableAdapterManager = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.TableAdapterManager();
            this.bmS_PDO1TableAdapter1 = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.timer_rec = new System.Windows.Forms.Timer(this.components);
            this.mainScreenTabControl.SuspendLayout();
            this.Weather.SuspendLayout();
            this.solarLocation.SuspendLayout();
            this.Dev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMS_PDO1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreenTabControl
            // 
            this.mainScreenTabControl.Controls.Add(this.Overview);
            this.mainScreenTabControl.Controls.Add(this.Speed);
            this.mainScreenTabControl.Controls.Add(this.Battery);
            this.mainScreenTabControl.Controls.Add(this.Weather);
            this.mainScreenTabControl.Controls.Add(this.solarLocation);
            this.mainScreenTabControl.Controls.Add(this.Dev);
            this.mainScreenTabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainScreenTabControl.Location = new System.Drawing.Point(13, 13);
            this.mainScreenTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainScreenTabControl.Multiline = true;
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.Padding = new System.Drawing.Point(70, 10);
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1635, 738);
            this.mainScreenTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainScreenTabControl.TabIndex = 16;
            // 
            // Overview
            // 
            this.Overview.Location = new System.Drawing.Point(4, 39);
            this.Overview.Margin = new System.Windows.Forms.Padding(4);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(4);
            this.Overview.Size = new System.Drawing.Size(1627, 695);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Overview";
            this.Overview.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(4, 39);
            this.Speed.Margin = new System.Windows.Forms.Padding(4);
            this.Speed.Name = "Speed";
            this.Speed.Padding = new System.Windows.Forms.Padding(4);
            this.Speed.Size = new System.Drawing.Size(1627, 695);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "Speed";
            this.Speed.UseVisualStyleBackColor = true;
            // 
            // Battery
            // 
            this.Battery.Location = new System.Drawing.Point(4, 39);
            this.Battery.Margin = new System.Windows.Forms.Padding(4);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(1627, 695);
            this.Battery.TabIndex = 2;
            this.Battery.Text = "Battery";
            this.Battery.UseVisualStyleBackColor = true;
            // 
            // Weather
            // 
            this.Weather.Controls.Add(this.weatherBrowser);
            this.Weather.Location = new System.Drawing.Point(4, 39);
            this.Weather.Margin = new System.Windows.Forms.Padding(4);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(1627, 695);
            this.Weather.TabIndex = 3;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // weatherBrowser
            // 
            this.weatherBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherBrowser.Location = new System.Drawing.Point(0, 0);
            this.weatherBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.weatherBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.weatherBrowser.Name = "weatherBrowser";
            this.weatherBrowser.Size = new System.Drawing.Size(1627, 695);
            this.weatherBrowser.TabIndex = 0;
            // 
            // solarLocation
            // 
            this.solarLocation.Controls.Add(this.solarBrowser);
            this.solarLocation.Location = new System.Drawing.Point(4, 39);
            this.solarLocation.Margin = new System.Windows.Forms.Padding(4);
            this.solarLocation.Name = "solarLocation";
            this.solarLocation.Size = new System.Drawing.Size(1627, 695);
            this.solarLocation.TabIndex = 5;
            this.solarLocation.Text = "Solar Location";
            this.solarLocation.UseVisualStyleBackColor = true;
            // 
            // solarBrowser
            // 
            this.solarBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solarBrowser.Location = new System.Drawing.Point(0, 0);
            this.solarBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.solarBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.solarBrowser.Name = "solarBrowser";
            this.solarBrowser.Size = new System.Drawing.Size(1627, 695);
            this.solarBrowser.TabIndex = 0;
            // 
            // Dev
            // 
            this.Dev.Controls.Add(this.btnReloadBrowsers);
            this.Dev.Controls.Add(this.loadDataBTN);
            this.Dev.Controls.Add(this.label2);
            this.Dev.Controls.Add(this.label1);
            this.Dev.Controls.Add(this.statusRTXB);
            this.Dev.Controls.Add(this.TBserver);
            this.Dev.Controls.Add(this.TBdatabase);
            this.Dev.Controls.Add(this.testBTN);
            this.Dev.Location = new System.Drawing.Point(4, 39);
            this.Dev.Margin = new System.Windows.Forms.Padding(4);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(1627, 695);
            this.Dev.TabIndex = 4;
            this.Dev.Text = "Dev";
            this.Dev.UseVisualStyleBackColor = true;
            // 
            // btnReloadBrowsers
            // 
            this.btnReloadBrowsers.Location = new System.Drawing.Point(0, 4);
            this.btnReloadBrowsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadBrowsers.Name = "btnReloadBrowsers";
            this.btnReloadBrowsers.Size = new System.Drawing.Size(300, 102);
            this.btnReloadBrowsers.TabIndex = 30;
            this.btnReloadBrowsers.Text = "Reload Browsers";
            this.btnReloadBrowsers.UseVisualStyleBackColor = true;
            this.btnReloadBrowsers.Click += new System.EventHandler(this.btnReloadBrowsers_Click);
            // 
            // loadDataBTN
            // 
            this.loadDataBTN.Location = new System.Drawing.Point(830, 346);
            this.loadDataBTN.Margin = new System.Windows.Forms.Padding(4);
            this.loadDataBTN.Name = "loadDataBTN";
            this.loadDataBTN.Size = new System.Drawing.Size(159, 28);
            this.loadDataBTN.TabIndex = 29;
            this.loadDataBTN.Text = "Load data - do not remove";
            this.loadDataBTN.UseVisualStyleBackColor = true;
            this.loadDataBTN.Click += new System.EventHandler(this.loadDataBTN_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server:";
            // 
            // statusRTXB
            // 
            this.statusRTXB.Location = new System.Drawing.Point(642, 88);
            this.statusRTXB.Margin = new System.Windows.Forms.Padding(4);
            this.statusRTXB.Name = "statusRTXB";
            this.statusRTXB.Size = new System.Drawing.Size(345, 250);
            this.statusRTXB.TabIndex = 24;
            this.statusRTXB.Text = "";
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(700, 24);
            this.TBserver.Margin = new System.Windows.Forms.Padding(4);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(207, 22);
            this.TBserver.TabIndex = 25;
            // 
            // TBdatabase
            // 
            this.TBdatabase.Location = new System.Drawing.Point(720, 56);
            this.TBdatabase.Margin = new System.Windows.Forms.Padding(4);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(187, 22);
            this.TBdatabase.TabIndex = 26;
            // 
            // testBTN
            // 
            this.testBTN.Location = new System.Drawing.Point(642, 346);
            this.testBTN.Margin = new System.Windows.Forms.Padding(4);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(161, 28);
            this.testBTN.TabIndex = 23;
            this.testBTN.Text = "Connect DB -  do not remove";
            this.testBTN.UseVisualStyleBackColor = true;
            this.testBTN.Click += new System.EventHandler(this.testBTN_Click_1);
            // 
            // bMS_PDO1BindingSource
            // 
            this.bMS_PDO1BindingSource.DataMember = "BMS_PDO1";
            this.bMS_PDO1BindingSource.DataSource = this.sTEVE_databaseDataSet;
            // 
            // sTEVE_databaseDataSet
            // 
            this.sTEVE_databaseDataSet.DataSetName = "STEVE_databaseDataSet";
            this.sTEVE_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bMS_PDO1TableAdapter
            // 
            this.bMS_PDO1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BMS_PDO1TableAdapter = this.bMS_PDO1TableAdapter;
            this.tableAdapterManager.UpdateOrder = STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bmS_PDO1TableAdapter1
            // 
            this.bmS_PDO1TableAdapter1.ClearBeforeFill = true;
            // 
            // timer_rec
            // 
            this.timer_rec.Tick += new System.EventHandler(this.timer_rec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 823);
            this.Controls.Add(this.mainScreenTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEVE Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainScreenTabControl.ResumeLayout(false);
            this.Weather.ResumeLayout(false);
            this.solarLocation.ResumeLayout(false);
            this.Dev.ResumeLayout(false);
            this.Dev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bMS_PDO1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private STEVE_databaseDataSet sTEVE_databaseDataSet;
        private System.Windows.Forms.BindingSource bMS_PDO1BindingSource;
        private STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter bMS_PDO1TableAdapter;
        private STEVE_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter bmS_PDO1TableAdapter1;
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
        private System.Windows.Forms.WebBrowser weatherBrowser;
        private System.Windows.Forms.TabPage solarLocation;
        private System.Windows.Forms.WebBrowser solarBrowser;
        private System.Windows.Forms.Button btnReloadBrowsers;
        public System.Windows.Forms.Timer timer_rec;
    }
}

