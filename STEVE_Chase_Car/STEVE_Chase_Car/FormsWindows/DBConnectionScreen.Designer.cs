﻿namespace STEVE_Chase_Car
{
    partial class DBConnectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConnectionScreen));
            this.btnConnect = new System.Windows.Forms.Button();
            this.TBserver = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBjustTesting = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(208, 276);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 42);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // TBserver
            // 
            this.TBserver.Enabled = false;
            this.TBserver.Location = new System.Drawing.Point(192, 189);
            this.TBserver.Name = "TBserver";
            this.TBserver.Size = new System.Drawing.Size(183, 20);
            this.TBserver.TabIndex = 3;
            this.TBserver.Text = ".\\SQLEXPRESS";
            // 
            // TBdatabase
            // 
            this.TBdatabase.Enabled = false;
            this.TBdatabase.Location = new System.Drawing.Point(192, 215);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(183, 20);
            this.TBdatabase.TabIndex = 4;
            this.TBdatabase.Text = "STEVE_database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Database:";
            // 
            // CBjustTesting
            // 
            this.CBjustTesting.AutoSize = true;
            this.CBjustTesting.BackColor = System.Drawing.SystemColors.Window;
            this.CBjustTesting.Location = new System.Drawing.Point(208, 253);
            this.CBjustTesting.Name = "CBjustTesting";
            this.CBjustTesting.Size = new System.Drawing.Size(136, 17);
            this.CBjustTesting.TabIndex = 10;
            this.CBjustTesting.Text = "I am just testing this out";
            this.CBjustTesting.UseVisualStyleBackColor = false;
            // 
            // DBConnectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 372);
            this.Controls.Add(this.CBjustTesting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBdatabase);
            this.Controls.Add(this.TBserver);
            this.Controls.Add(this.btnConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConnectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEVE Database Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox TBserver;
        private System.Windows.Forms.TextBox TBdatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CBjustTesting;
    }
}