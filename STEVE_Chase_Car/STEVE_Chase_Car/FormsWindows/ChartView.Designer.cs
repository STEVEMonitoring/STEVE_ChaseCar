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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("minVolt");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("maxVolt");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Volt");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Current");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("BMS_PDO1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("minTemp");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("maxTemp");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("BMS_PDO2", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("batteryVoltage");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("motorCurrentPeakAvrage");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("fetTemp");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("motorRotationSpeed");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("PWMduty");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("leadAngle");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("MotorFrame0", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("accelerationPos");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("regenerationVrPos");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("outputTargetVal");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("MotorFrame1", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18});
            this.databaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sTEVE_DatabaseDataSet = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.sTEVEDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadChart = new System.Windows.Forms.Button();
            this.CBsourceSelect = new System.Windows.Forms.ComboBox();
            this.chartTreeView = new System.Windows.Forms.TreeView();
            this.bMSPDO2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMS_PDO2TableAdapter = new STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.databaseChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVEDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSPDO2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseChart
            // 
            chartArea1.Name = "ChartArea1";
            this.databaseChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.databaseChart.Legends.Add(legend1);
            this.databaseChart.Location = new System.Drawing.Point(187, 2);
            this.databaseChart.Name = "databaseChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.databaseChart.Series.Add(series1);
            this.databaseChart.Size = new System.Drawing.Size(523, 426);
            this.databaseChart.TabIndex = 0;
            this.databaseChart.Text = "chart1";
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
            // btnLoadChart
            // 
            this.btnLoadChart.Location = new System.Drawing.Point(600, 498);
            this.btnLoadChart.Name = "btnLoadChart";
            this.btnLoadChart.Size = new System.Drawing.Size(110, 36);
            this.btnLoadChart.TabIndex = 1;
            this.btnLoadChart.Text = "Load Chart";
            this.btnLoadChart.UseVisualStyleBackColor = true;
            this.btnLoadChart.Click += new System.EventHandler(this.btnLoadChart_Click);
            // 
            // CBsourceSelect
            // 
            this.CBsourceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBsourceSelect.FormattingEnabled = true;
            this.CBsourceSelect.Items.AddRange(new object[] {
            "BMS_PDO1",
            "BMS_PDO2",
            "MotorFrame0",
            "MotorFrame1",
            "MotorFrame2",
            "MPPT"});
            this.CBsourceSelect.Location = new System.Drawing.Point(187, 434);
            this.CBsourceSelect.Name = "CBsourceSelect";
            this.CBsourceSelect.Size = new System.Drawing.Size(164, 21);
            this.CBsourceSelect.TabIndex = 3;
            this.CBsourceSelect.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // chartTreeView
            // 
            this.chartTreeView.Location = new System.Drawing.Point(13, 13);
            this.chartTreeView.Name = "chartTreeView";
            treeNode1.Name = "minVolt";
            treeNode1.Text = "minVolt";
            treeNode2.Name = "maxVolt";
            treeNode2.Text = "maxVolt";
            treeNode3.Name = "Volt";
            treeNode3.Text = "Volt";
            treeNode4.Name = "Current";
            treeNode4.Text = "Current";
            treeNode5.Name = "BMS_PDO1";
            treeNode5.Text = "BMS_PDO1";
            treeNode6.Name = "minTemp";
            treeNode6.Text = "minTemp";
            treeNode7.Name = "maxTemp";
            treeNode7.Text = "maxTemp";
            treeNode8.Name = "BMS_PDO2";
            treeNode8.Text = "BMS_PDO2";
            treeNode9.Name = "batteryVoltage";
            treeNode9.Text = "batteryVoltage";
            treeNode10.Name = "motorCurrentPeakAvrage";
            treeNode10.Text = "motorCurrentPeakAvrage";
            treeNode11.Name = "fetTemp";
            treeNode11.Text = "fetTemp";
            treeNode12.Name = "motorRotationSpeed";
            treeNode12.Text = "motorRotationSpeed";
            treeNode13.Name = "PWMduty";
            treeNode13.Text = "PWMduty";
            treeNode14.Name = "leadAngle";
            treeNode14.Text = "leadAngle";
            treeNode15.Name = "MotorFrame0";
            treeNode15.Text = "MotorFrame0";
            treeNode16.Name = "accelerationPos";
            treeNode16.Text = "accelerationPos";
            treeNode17.Name = "regenerationVrPos";
            treeNode17.Text = "regenerationVrPos";
            treeNode18.Name = "outputTargetVal";
            treeNode18.Text = "outputTargetVal";
            treeNode19.Name = "MotorFrame1";
            treeNode19.Text = "MotorFrame1";
            this.chartTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode15,
            treeNode19});
            this.chartTreeView.Size = new System.Drawing.Size(168, 415);
            this.chartTreeView.TabIndex = 4;
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
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 546);
            this.Controls.Add(this.chartTreeView);
            this.Controls.Add(this.CBsourceSelect);
            this.Controls.Add(this.btnLoadChart);
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
        private System.Windows.Forms.Button btnLoadChart;
        private System.Windows.Forms.ComboBox CBsourceSelect;
        private System.Windows.Forms.TreeView chartTreeView;
        private System.Windows.Forms.BindingSource bMSPDO2BindingSource;
        private STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter bMS_PDO2TableAdapter;
    }
}