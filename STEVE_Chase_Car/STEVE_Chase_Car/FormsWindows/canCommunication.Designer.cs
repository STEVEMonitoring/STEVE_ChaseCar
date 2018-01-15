namespace STEVE_Chase_Car.FormsWindows
{
    partial class canCommunication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dev_CANalyst_Console = new System.Windows.Forms.RichTextBox();
            this.dev_CANalyst_btnSend = new System.Windows.Forms.Button();
            this.dev_CANalyst_btnDisconnect = new System.Windows.Forms.Button();
            this.dev_CANalyst_btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.dev_CANalyst_Console);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnSend);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnDisconnect);
            this.groupBox1.Controls.Add(this.dev_CANalyst_btnConnect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 317);
            this.groupBox1.TabIndex = 32;
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
            this.dev_CANalyst_Console.Size = new System.Drawing.Size(276, 291);
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
            // canCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 317);
            this.Controls.Add(this.groupBox1);
            this.Name = "canCommunication";
            this.Text = "canCommunication";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox dev_CANalyst_Console;
        private System.Windows.Forms.Button dev_CANalyst_btnSend;
        private System.Windows.Forms.Button dev_CANalyst_btnDisconnect;
        private System.Windows.Forms.Button dev_CANalyst_btnConnect;
    }
}