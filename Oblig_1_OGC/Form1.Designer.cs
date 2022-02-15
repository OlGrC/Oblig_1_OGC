namespace Oblig_1_OGC
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Connection = new System.Windows.Forms.TabPage();
            this.DisconnectCOMbutton = new System.Windows.Forms.Button();
            this.ConnectCOMbutton = new System.Windows.Forms.Button();
            this.BitRateLable = new System.Windows.Forms.Label();
            this.ComPortLable = new System.Windows.Forms.Label();
            this.BitRate_list = new System.Windows.Forms.ComboBox();
            this.COM_list = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ConnectionStatusWindow = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Connection_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.Connection.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Connection);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // Connection
            // 
            this.Connection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Connection.Controls.Add(this.statusStrip1);
            this.Connection.Controls.Add(this.ConnectionStatusWindow);
            this.Connection.Controls.Add(this.DisconnectCOMbutton);
            this.Connection.Controls.Add(this.ConnectCOMbutton);
            this.Connection.Controls.Add(this.BitRateLable);
            this.Connection.Controls.Add(this.ComPortLable);
            this.Connection.Controls.Add(this.BitRate_list);
            this.Connection.Controls.Add(this.COM_list);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Connection.Size = new System.Drawing.Size(788, 519);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            // 
            // DisconnectCOMbutton
            // 
            this.DisconnectCOMbutton.BackColor = System.Drawing.Color.Transparent;
            this.DisconnectCOMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectCOMbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisconnectCOMbutton.Location = new System.Drawing.Point(81, 188);
            this.DisconnectCOMbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisconnectCOMbutton.Name = "DisconnectCOMbutton";
            this.DisconnectCOMbutton.Size = new System.Drawing.Size(91, 24);
            this.DisconnectCOMbutton.TabIndex = 5;
            this.DisconnectCOMbutton.Text = "Disconnect";
            this.DisconnectCOMbutton.UseVisualStyleBackColor = false;
            this.DisconnectCOMbutton.Click += new System.EventHandler(this.Disconnect_COM_button);
            // 
            // ConnectCOMbutton
            // 
            this.ConnectCOMbutton.BackColor = System.Drawing.Color.Transparent;
            this.ConnectCOMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectCOMbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectCOMbutton.Location = new System.Drawing.Point(81, 142);
            this.ConnectCOMbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectCOMbutton.Name = "ConnectCOMbutton";
            this.ConnectCOMbutton.Size = new System.Drawing.Size(91, 24);
            this.ConnectCOMbutton.TabIndex = 4;
            this.ConnectCOMbutton.Text = "Connenct";
            this.ConnectCOMbutton.UseVisualStyleBackColor = false;
            this.ConnectCOMbutton.Click += new System.EventHandler(this.Connect_COM_button);
            // 
            // BitRateLable
            // 
            this.BitRateLable.AutoSize = true;
            this.BitRateLable.Location = new System.Drawing.Point(29, 102);
            this.BitRateLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BitRateLable.Name = "BitRateLable";
            this.BitRateLable.Size = new System.Drawing.Size(40, 13);
            this.BitRateLable.TabIndex = 3;
            this.BitRateLable.Text = "Bit rate";
            // 
            // ComPortLable
            // 
            this.ComPortLable.AutoSize = true;
            this.ComPortLable.Location = new System.Drawing.Point(29, 58);
            this.ComPortLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComPortLable.Name = "ComPortLable";
            this.ComPortLable.Size = new System.Drawing.Size(49, 13);
            this.ComPortLable.TabIndex = 2;
            this.ComPortLable.Text = "Com port";
            // 
            // BitRate_list
            // 
            this.BitRate_list.FormattingEnabled = true;
            this.BitRate_list.Items.AddRange(new object[] {
            "",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.BitRate_list.Location = new System.Drawing.Point(81, 100);
            this.BitRate_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BitRate_list.Name = "BitRate_list";
            this.BitRate_list.Size = new System.Drawing.Size(92, 21);
            this.BitRate_list.TabIndex = 1;
            // 
            // COM_list
            // 
            this.COM_list.FormattingEnabled = true;
            this.COM_list.Location = new System.Drawing.Point(81, 55);
            this.COM_list.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.COM_list.Name = "COM_list";
            this.COM_list.Size = new System.Drawing.Size(92, 21);
            this.COM_list.TabIndex = 0;
            this.COM_list.Click += new System.EventHandler(this.COM_select);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(788, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ConnectionStatusWindow
            // 
            this.ConnectionStatusWindow.Location = new System.Drawing.Point(269, 55);
            this.ConnectionStatusWindow.Multiline = true;
            this.ConnectionStatusWindow.Name = "ConnectionStatusWindow";
            this.ConnectionStatusWindow.Size = new System.Drawing.Size(243, 157);
            this.ConnectionStatusWindow.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Connection_status});
            this.statusStrip1.Location = new System.Drawing.Point(2, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Connection_status
            // 
            this.Connection_status.ActiveLinkColor = System.Drawing.Color.Green;
            this.Connection_status.BackColor = System.Drawing.Color.DimGray;
            this.Connection_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Connection_status.Name = "Connection_status";
            this.Connection_status.Size = new System.Drawing.Size(34, 17);
            this.Connection_status.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Connection;
        private System.Windows.Forms.Button DisconnectCOMbutton;
        private System.Windows.Forms.Button ConnectCOMbutton;
        private System.Windows.Forms.Label BitRateLable;
        private System.Windows.Forms.Label ComPortLable;
        private System.Windows.Forms.ComboBox BitRate_list;
        private System.Windows.Forms.ComboBox COM_list;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox ConnectionStatusWindow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Connection_status;
    }
}

