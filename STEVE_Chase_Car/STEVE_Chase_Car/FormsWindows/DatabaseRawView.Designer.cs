namespace STEVE_Chase_Car.FormsWindows
{
    partial class DatabaseRawView
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
            this.steveDatabaseView = new System.Windows.Forms.DataGridView();
            this.sTEVE_DatabaseDataSet = new STEVE_Chase_Car.STEVE_DatabaseDataSet();
            this.sTEVEDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadTable = new System.Windows.Forms.Button();
            this.CBsourceSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.steveDatabaseView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVEDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // steveDatabaseView
            // 
            this.steveDatabaseView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.steveDatabaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.steveDatabaseView.Location = new System.Drawing.Point(16, 15);
            this.steveDatabaseView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.steveDatabaseView.Name = "steveDatabaseView";
            this.steveDatabaseView.Size = new System.Drawing.Size(852, 539);
            this.steveDatabaseView.TabIndex = 0;
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
            // btnLoadTable
            // 
            this.btnLoadTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTable.Location = new System.Drawing.Point(712, 647);
            this.btnLoadTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadTable.Name = "btnLoadTable";
            this.btnLoadTable.Size = new System.Drawing.Size(156, 50);
            this.btnLoadTable.TabIndex = 1;
            this.btnLoadTable.Text = "Load Table";
            this.btnLoadTable.UseVisualStyleBackColor = true;
            this.btnLoadTable.Click += new System.EventHandler(this.btnLoadTable_Click);
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
            this.CBsourceSelect.Location = new System.Drawing.Point(16, 561);
            this.CBsourceSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CBsourceSelect.Name = "CBsourceSelect";
            this.CBsourceSelect.Size = new System.Drawing.Size(217, 24);
            this.CBsourceSelect.TabIndex = 2;
            this.CBsourceSelect.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // DatabaseRawView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 713);
            this.Controls.Add(this.CBsourceSelect);
            this.Controls.Add(this.btnLoadTable);
            this.Controls.Add(this.steveDatabaseView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(899, 750);
            this.Name = "DatabaseRawView";
            this.Text = "DatabaseRawView";
            this.Load += new System.EventHandler(this.DatabaseRawView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.steveDatabaseView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVE_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTEVEDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView steveDatabaseView;
        private System.Windows.Forms.BindingSource sTEVEDatabaseDataSetBindingSource;
        private STEVE_DatabaseDataSet sTEVE_DatabaseDataSet;
        private System.Windows.Forms.Button btnLoadTable;
        private System.Windows.Forms.ComboBox CBsourceSelect;
    }
}