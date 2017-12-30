namespace STEVE_Chase_Car.FormsWindows
{
    partial class ChartView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Min Voltage");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Max Voltage");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Voltage");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Current");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("BMS_PDO1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Min Temp");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Max Temp");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BMS_PDO2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Battery Voltage");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Motor Current Peak Avrage");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Fet Temp");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Motor Rotation Speed");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("PWMduty");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lead Angle");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("MotorFrame0", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Acceleration Pos");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Regeneration Vr Pos");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Output Target Val");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("MotorFrame1", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            this.databaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sTEVE_DatabaseDataSet = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.sTEVEDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartTreeView = new System.Windows.Forms.TreeView();
            this.bMSPDO2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMS_PDO2TableAdapter = new STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter();
            this.btnBmsPdo1 = new System.Windows.Forms.Button();
            this.btnBmsPdo2 = new System.Windows.Forms.Button();
            this.btnMotorFrame0 = new System.Windows.Forms.Button();
            this.btnMotorFrame1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVEDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSPDO2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseChart
            // 
            this.databaseChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.databaseChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.databaseChart.Legends.Add(legend1);
            this.databaseChart.Location = new System.Drawing.Point(12, 69);
            this.databaseChart.Name = "databaseChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.databaseChart.Series.Add(series1);
            this.databaseChart.Size = new System.Drawing.Size(616, 460);
            this.databaseChart.TabIndex = 0;
            this.databaseChart.Text = "chart1";
            this.databaseChart.Click += new System.EventHandler(this.databaseChart_Click);
            this.databaseChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.databaseChart_MouseMove);
            // 
            // sTEVE_DatabaseDataSet
            // 
            this.sTEVE_DatabaseDataSet.DataSetName = "STEVE_DatabaseDataSet";
            this.sTEVE_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTEVEDatabaseDataSetBindingSource
            // 
            this.sTEVEDatabaseDataSetBindingSource.DataSource = this.sTEVE_DatabaseDataSet;
            this.sTEVEDatabaseDataSetBindingSource.Position = 0;
            // 
            // chartTreeView
            // 
            this.chartTreeView.Location = new System.Drawing.Point(635, 69);
            this.chartTreeView.Name = "chartTreeView";
            treeNode1.Checked = true;
            treeNode1.Name = "minVolt";
            treeNode1.Text = "Min Voltage";
            treeNode2.Name = "maxVolt";
            treeNode2.Text = "Max Voltage";
            treeNode3.Name = "Volt";
            treeNode3.Text = "Voltage";
            treeNode4.Name = "current";
            treeNode4.Text = "Current";
            treeNode5.Name = "BMS_PDO1";
            treeNode5.Text = "BMS_PDO1";
            treeNode6.Name = "minTemp";
            treeNode6.Text = "Min Temp";
            treeNode7.Name = "maxTemp";
            treeNode7.Text = "Max Temp";
            treeNode8.Name = "BMS_PDO2";
            treeNode8.Text = "BMS_PDO2";
            treeNode9.Name = "batteryVoltage";
            treeNode9.Text = "Battery Voltage";
            treeNode10.Name = "motorCurrentPeakAvrage";
            treeNode10.Text = "Motor Current Peak Avrage";
            treeNode11.Name = "fetTemp";
            treeNode11.Text = "Fet Temp";
            treeNode12.Name = "motorRotationSpeed";
            treeNode12.Text = "Motor Rotation Speed";
            treeNode13.Name = "PWMduty";
            treeNode13.Text = "PWMduty";
            treeNode14.Name = "leadAngle";
            treeNode14.Text = "Lead Angle";
            treeNode15.Name = "MotorFrame0";
            treeNode15.Text = "MotorFrame0";
            treeNode16.Name = "accelerationPos";
            treeNode16.Text = "Acceleration Pos";
            treeNode17.Name = "regnerationVrPos";
            treeNode17.Text = "Regeneration Vr Pos";
            treeNode18.Name = "outputTargetVal";
            treeNode18.Text = "Output Target Val";
            treeNode19.Name = "MotorFrame1";
            treeNode19.Text = "MotorFrame1";
            this.chartTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode15,
            treeNode19});
            this.chartTreeView.Size = new System.Drawing.Size(187, 334);
            this.chartTreeView.TabIndex = 4;
            this.chartTreeView.DoubleClick += new System.EventHandler(this.chartTreeView_DoubleClick);
            // 
            // bMSPDO2BindingSource
            // 
            this.bMSPDO2BindingSource.DataMember = "BMS_PDO2";
            this.bMSPDO2BindingSource.DataSource = this.sTEVEDatabaseDataSetBindingSource;
            // 
            // bMS_PDO2TableAdapter
            // 
            this.bMS_PDO2TableAdapter.ClearBeforeFill = true;
            // 
            // btnBmsPdo1
            // 
            this.btnBmsPdo1.Location = new System.Drawing.Point(23, 27);
            this.btnBmsPdo1.Name = "btnBmsPdo1";
            this.btnBmsPdo1.Size = new System.Drawing.Size(75, 23);
            this.btnBmsPdo1.TabIndex = 5;
            this.btnBmsPdo1.Text = "BMS PDO1";
            this.btnBmsPdo1.UseVisualStyleBackColor = true;
            this.btnBmsPdo1.Click += new System.EventHandler(this.btnBmsPdo1_Click);
            // 
            // btnBmsPdo2
            // 
            this.btnBmsPdo2.Location = new System.Drawing.Point(155, 27);
            this.btnBmsPdo2.Name = "btnBmsPdo2";
            this.btnBmsPdo2.Size = new System.Drawing.Size(75, 23);
            this.btnBmsPdo2.TabIndex = 6;
            this.btnBmsPdo2.Text = "BMS PDO2";
            this.btnBmsPdo2.UseVisualStyleBackColor = true;
            this.btnBmsPdo2.Click += new System.EventHandler(this.btnBmsPdo2_Click);
            // 
            // btnMotorFrame0
            // 
            this.btnMotorFrame0.Location = new System.Drawing.Point(288, 27);
            this.btnMotorFrame0.Name = "btnMotorFrame0";
            this.btnMotorFrame0.Size = new System.Drawing.Size(100, 23);
            this.btnMotorFrame0.TabIndex = 7;
            this.btnMotorFrame0.Text = "Motor Frame 0";
            this.btnMotorFrame0.UseVisualStyleBackColor = true;
            // 
            // btnMotorFrame1
            // 
            this.btnMotorFrame1.Location = new System.Drawing.Point(422, 27);
            this.btnMotorFrame1.Name = "btnMotorFrame1";
            this.btnMotorFrame1.Size = new System.Drawing.Size(94, 23);
            this.btnMotorFrame1.TabIndex = 8;
            this.btnMotorFrame1.Text = "Motor Frame 1";
            this.btnMotorFrame1.UseVisualStyleBackColor = true;
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.btnMotorFrame1);
            this.Controls.Add(this.btnMotorFrame0);
            this.Controls.Add(this.btnBmsPdo2);
            this.Controls.Add(this.btnBmsPdo1);
            this.Controls.Add(this.chartTreeView);
            this.Controls.Add(this.databaseChart);
            this.Name = "ChartView";
            this.Text = "ChartView";
            ((System.ComponentModel.ISupportInitialize)(this.databaseChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVEDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSPDO2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart databaseChart;
        private System.Windows.Forms.BindingSource sTEVEDatabaseDataSetBindingSource;
        private STEVE_DatabaseDataSet sTEVE_DatabaseDataSet;
        private System.Windows.Forms.TreeView chartTreeView;
        private System.Windows.Forms.BindingSource bMSPDO2BindingSource;
        private STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter bMS_PDO2TableAdapter;
        private System.Windows.Forms.Button btnBmsPdo1;
        private System.Windows.Forms.Button btnBmsPdo2;
        private System.Windows.Forms.Button btnMotorFrame0;
        private System.Windows.Forms.Button btnMotorFrame1;
    }
}