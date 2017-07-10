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
            this.Dev = new System.Windows.Forms.TabPage();
            this.loadDataBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusRTXB = new System.Windows.Forms.RichTextBox();
            this.TBserver = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.testBTN = new System.Windows.Forms.Button();
            this.RTBOverviewTop = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bMS_PDO1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTEVE_databaseDataSet = new STEVE_Chase_Car.STEVE_databaseDataSet();
            this.bMS_PDO1TableAdapter = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.tableAdapterManager = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.TableAdapterManager();
            this.bmS_PDO1TableAdapter1 = new STEVE_Chase_Car.STEVE_databaseDataSetTableAdapters.BMS_PDO1TableAdapter();
            this.mainScreenTabControl.SuspendLayout();
            this.Overview.SuspendLayout();
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
            this.mainScreenTabControl.Controls.Add(this.Dev);
            this.mainScreenTabControl.Location = new System.Drawing.Point(12, 12);
            this.mainScreenTabControl.Multiline = true;
            this.mainScreenTabControl.Name = "mainScreenTabControl";
            this.mainScreenTabControl.Padding = new System.Drawing.Point(70, 10);
            this.mainScreenTabControl.SelectedIndex = 0;
            this.mainScreenTabControl.Size = new System.Drawing.Size(1447, 907);
            this.mainScreenTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainScreenTabControl.TabIndex = 16;
            // 
            // Overview
            // 
            this.Overview.Controls.Add(this.richTextBox2);
            this.Overview.Controls.Add(this.richTextBox1);
            this.Overview.Controls.Add(this.RTBOverviewTop);
            this.Overview.Location = new System.Drawing.Point(4, 36);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(3);
            this.Overview.Size = new System.Drawing.Size(1439, 867);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Overview";
            this.Overview.UseVisualStyleBackColor = true;
            // 
            // Speed
            // 
            this.Speed.Location = new System.Drawing.Point(4, 36);
            this.Speed.Name = "Speed";
            this.Speed.Padding = new System.Windows.Forms.Padding(3);
            this.Speed.Size = new System.Drawing.Size(1439, 867);
            this.Speed.TabIndex = 1;
            this.Speed.Text = "Speed";
            this.Speed.UseVisualStyleBackColor = true;
            // 
            // Battery
            // 
            this.Battery.Location = new System.Drawing.Point(4, 36);
            this.Battery.Name = "Battery";
            this.Battery.Size = new System.Drawing.Size(1439, 867);
            this.Battery.TabIndex = 2;
            this.Battery.Text = "Battery";
            this.Battery.UseVisualStyleBackColor = true;
            // 
            // Weather
            // 
            this.Weather.Location = new System.Drawing.Point(4, 36);
            this.Weather.Name = "Weather";
            this.Weather.Size = new System.Drawing.Size(1439, 867);
            this.Weather.TabIndex = 3;
            this.Weather.Text = "Weather";
            this.Weather.UseVisualStyleBackColor = true;
            // 
            // Dev
            // 
            this.Dev.Controls.Add(this.loadDataBTN);
            this.Dev.Controls.Add(this.label2);
            this.Dev.Controls.Add(this.label1);
            this.Dev.Controls.Add(this.statusRTXB);
            this.Dev.Controls.Add(this.TBserver);
            this.Dev.Controls.Add(this.TBdatabase);
            this.Dev.Controls.Add(this.testBTN);
            this.Dev.Location = new System.Drawing.Point(4, 36);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(1439, 867);
            this.Dev.TabIndex = 4;
            this.Dev.Text = "Dev";
            this.Dev.UseVisualStyleBackColor = true;
            // 
            // loadDataBTN
            // 
            this.loadDataBTN.Location = new System.Drawing.Point(722, 539);
            this.loadDataBTN.Name = "loadDataBTN";
            this.loadDataBTN.Size = new System.Drawing.Size(119, 23);
            this.loadDataBTN.TabIndex = 29;
            this.loadDataBTN.Text = "Load data - do not remove";
            this.loadDataBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Server:";
            // 
            // statusRTXB
            // 
            this.statusRTXB.Location = new System.Drawing.Point(581, 329);
            this.statusRTXB.Name = "statusRTXB";
            this.statusRTXB.Size = new System.Drawing.Size(260, 204);
            this.statusRTXB.TabIndex = 24;
            this.statusRTXB.Text = "";
            // 
            // TBserver
            // 
            this.TBserver.Location = new System.Drawing.Point(625, 277);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(156, 20);
            this.TBserver.TabIndex = 25;
            // 
            // TBdatabase
            // 
            this.TBdatabase.Location = new System.Drawing.Point(640, 303);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(141, 20);
            this.TBdatabase.TabIndex = 26;
            // 
            // testBTN
            // 
            this.testBTN.Location = new System.Drawing.Point(581, 539);
            this.testBTN.Name = "testBTN";
            this.testBTN.Size = new System.Drawing.Size(121, 23);
            this.testBTN.TabIndex = 23;
            this.testBTN.Text = "Connect DB -  do not remove";
            this.testBTN.UseVisualStyleBackColor = true;
            // 
            // RTBOverviewTop
            // 
            this.RTBOverviewTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.RTBOverviewTop.Location = new System.Drawing.Point(3, 3);
            this.RTBOverviewTop.Margin = new System.Windows.Forms.Padding(7);
            this.RTBOverviewTop.Name = "RTBOverviewTop";
            this.RTBOverviewTop.Size = new System.Drawing.Size(1433, 416);
            this.RTBOverviewTop.TabIndex = 0;
            this.RTBOverviewTop.Text = "Some text in here";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox1.Location = new System.Drawing.Point(3, 419);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(700, 445);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox2.Location = new System.Drawing.Point(736, 419);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(700, 445);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 931);
            this.Controls.Add(this.mainScreenTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEVE Main Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainScreenTabControl.ResumeLayout(false);
            this.Overview.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox RTBOverviewTop;
        private System.Windows.Forms.TabPage Weather;
        private System.Windows.Forms.TabPage Dev;
        private System.Windows.Forms.Button testBTN;
        private System.Windows.Forms.TextBox TBdatabase;
        private System.Windows.Forms.TextBox TBserver;
        private System.Windows.Forms.RichTextBox statusRTXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loadDataBTN;
    }
}

