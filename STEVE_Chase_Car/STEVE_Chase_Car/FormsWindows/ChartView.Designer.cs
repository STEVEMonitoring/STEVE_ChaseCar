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
            this.databaseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sTEVE_DatabaseDataSet = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.sTEVEDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSPDO2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMS_PDO2TableAdapter = new STEVE_Chase_Car.STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter();
            this.btnBmsPdo1 = new System.Windows.Forms.Button();
            this.btnBmsPdo2 = new System.Windows.Forms.Button();
            this.btnMotorFrame0 = new System.Windows.Forms.Button();
            this.btnMotorFrame1 = new System.Windows.Forms.Button();
            this.clbChartChoice = new System.Windows.Forms.CheckedListBox();
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
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
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
            this.btnBmsPdo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnBmsPdo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBmsPdo1.ForeColor = System.Drawing.Color.White;
            this.btnBmsPdo1.Location = new System.Drawing.Point(12, 27);
            this.btnBmsPdo1.Name = "btnBmsPdo1";
            this.btnBmsPdo1.Size = new System.Drawing.Size(75, 23);
            this.btnBmsPdo1.TabIndex = 5;
            this.btnBmsPdo1.Text = "BMS PDO1";
            this.btnBmsPdo1.UseVisualStyleBackColor = false;
            this.btnBmsPdo1.Click += new System.EventHandler(this.btnBmsPdo1_Click);
            // 
            // btnBmsPdo2
            // 
            this.btnBmsPdo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnBmsPdo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBmsPdo2.ForeColor = System.Drawing.Color.White;
            this.btnBmsPdo2.Location = new System.Drawing.Point(169, 27);
            this.btnBmsPdo2.Name = "btnBmsPdo2";
            this.btnBmsPdo2.Size = new System.Drawing.Size(75, 23);
            this.btnBmsPdo2.TabIndex = 6;
            this.btnBmsPdo2.Text = "BMS PDO2";
            this.btnBmsPdo2.UseVisualStyleBackColor = false;
            this.btnBmsPdo2.Click += new System.EventHandler(this.btnBmsPdo2_Click);
            // 
            // btnMotorFrame0
            // 
            this.btnMotorFrame0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnMotorFrame0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorFrame0.ForeColor = System.Drawing.Color.White;
            this.btnMotorFrame0.Location = new System.Drawing.Point(340, 27);
            this.btnMotorFrame0.Name = "btnMotorFrame0";
            this.btnMotorFrame0.Size = new System.Drawing.Size(100, 23);
            this.btnMotorFrame0.TabIndex = 7;
            this.btnMotorFrame0.Text = "Motor Frame 0";
            this.btnMotorFrame0.UseVisualStyleBackColor = false;
            this.btnMotorFrame0.Click += new System.EventHandler(this.btnMotorFrame0_Click);
            // 
            // btnMotorFrame1
            // 
            this.btnMotorFrame1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnMotorFrame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorFrame1.ForeColor = System.Drawing.Color.White;
            this.btnMotorFrame1.Location = new System.Drawing.Point(534, 27);
            this.btnMotorFrame1.Name = "btnMotorFrame1";
            this.btnMotorFrame1.Size = new System.Drawing.Size(94, 23);
            this.btnMotorFrame1.TabIndex = 8;
            this.btnMotorFrame1.Text = "Motor Frame 1";
            this.btnMotorFrame1.UseVisualStyleBackColor = false;
            this.btnMotorFrame1.Click += new System.EventHandler(this.btnMotorFrame1_Click);
            // 
            // clbChartChoice
            // 
            this.clbChartChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbChartChoice.CheckOnClick = true;
            this.clbChartChoice.FormattingEnabled = true;
            this.clbChartChoice.Location = new System.Drawing.Point(634, 69);
            this.clbChartChoice.Name = "clbChartChoice";
            this.clbChartChoice.Size = new System.Drawing.Size(188, 199);
            this.clbChartChoice.TabIndex = 9;
            this.clbChartChoice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clbChartChoice_MouseUp);
            // 
            // ChartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.clbChartChoice);
            this.Controls.Add(this.btnMotorFrame1);
            this.Controls.Add(this.btnMotorFrame0);
            this.Controls.Add(this.btnBmsPdo2);
            this.Controls.Add(this.btnBmsPdo1);
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
        private System.Windows.Forms.BindingSource bMSPDO2BindingSource;
        private STEVE_DatabaseDataSetTableAdapters.BMS_PDO2TableAdapter bMS_PDO2TableAdapter;
        private System.Windows.Forms.Button btnBmsPdo1;
        private System.Windows.Forms.Button btnBmsPdo2;
        private System.Windows.Forms.Button btnMotorFrame0;
        private System.Windows.Forms.Button btnMotorFrame1;
        private System.Windows.Forms.CheckedListBox clbChartChoice;
    }
}