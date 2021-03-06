namespace Oblig_1_OGC
{
    partial class SoftSensConf
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Connection = new System.Windows.Forms.TabPage();
            this.connectionStatus1 = new System.Windows.Forms.TextBox();
            this.ConnectionStatusLable = new System.Windows.Forms.Label();
            this.ConnectionStatusWindow = new System.Windows.Forms.TextBox();
            this.DisconnectCOMbutton = new System.Windows.Forms.Button();
            this.ConnectCOMbutton = new System.Windows.Forms.Button();
            this.BitRateLable = new System.Windows.Forms.Label();
            this.ComPortLable = new System.Windows.Forms.Label();
            this.BitRate_list = new System.Windows.Forms.ComboBox();
            this.COM_list = new System.Windows.Forms.ComboBox();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.connectionStatus2 = new System.Windows.Forms.TextBox();
            this.ResValues2Button = new System.Windows.Forms.Button();
            this.ResValuesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upload_to_device_button = new System.Windows.Forms.Button();
            this.read_from_file_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.unit_ID_textBox2 = new System.Windows.Forms.TextBox();
            this.lrv_textBox2 = new System.Windows.Forms.TextBox();
            this.alarm_L_textBox2 = new System.Windows.Forms.TextBox();
            this.alarm_H_textBox2 = new System.Windows.Forms.TextBox();
            this.unit_ID_2_lable = new System.Windows.Forms.Label();
            this.lrv_2_lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.alarm_L_2_lable = new System.Windows.Forms.Label();
            this.alarm_H_2_lable = new System.Windows.Forms.Label();
            this.urv_textBox2 = new System.Windows.Forms.TextBox();
            this.save_to_file_button = new System.Windows.Forms.Button();
            this.read_from_device_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.alarm_H_textBox = new System.Windows.Forms.TextBox();
            this.alarm_L_textBox = new System.Windows.Forms.TextBox();
            this.urv_textBox = new System.Windows.Forms.TextBox();
            this.lrv_textBox = new System.Windows.Forms.TextBox();
            this.alarm_H_lable = new System.Windows.Forms.Label();
            this.alarm_L_lable = new System.Windows.Forms.Label();
            this.urv_lable = new System.Windows.Forms.Label();
            this.lrv_lable = new System.Windows.Forms.Label();
            this.unit_id_lable = new System.Windows.Forms.Label();
            this.unit_ID_textBox = new System.Windows.Forms.TextBox();
            this.MonitoringTab = new System.Windows.Forms.TabPage();
            this.connectionStatus3 = new System.Windows.Forms.TextBox();
            this.LoggedScaled = new System.Windows.Forms.ListBox();
            this.LoggedRaw = new System.Windows.Forms.ListBox();
            this.StopMonitoringButton = new System.Windows.Forms.Button();
            this.MonitorRawButton = new System.Windows.Forms.Button();
            this.MonitorScaledButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialogSSC = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timerScaled = new System.Windows.Forms.Timer(this.components);
            this.timerRaw = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Connection.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MonitoringTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Connection);
            this.tabControl1.Controls.Add(this.ConfigTab);
            this.tabControl1.Controls.Add(this.MonitoringTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // Connection
            // 
            this.Connection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Connection.Controls.Add(this.connectionStatus1);
            this.Connection.Controls.Add(this.ConnectionStatusLable);
            this.Connection.Controls.Add(this.ConnectionStatusWindow);
            this.Connection.Controls.Add(this.DisconnectCOMbutton);
            this.Connection.Controls.Add(this.ConnectCOMbutton);
            this.Connection.Controls.Add(this.BitRateLable);
            this.Connection.Controls.Add(this.ComPortLable);
            this.Connection.Controls.Add(this.BitRate_list);
            this.Connection.Controls.Add(this.COM_list);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Margin = new System.Windows.Forms.Padding(2);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(2);
            this.Connection.Size = new System.Drawing.Size(788, 519);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            // 
            // connectionStatus1
            // 
            this.connectionStatus1.BackColor = System.Drawing.Color.Black;
            this.connectionStatus1.ForeColor = System.Drawing.Color.White;
            this.connectionStatus1.Location = new System.Drawing.Point(714, 0);
            this.connectionStatus1.Margin = new System.Windows.Forms.Padding(2);
            this.connectionStatus1.Name = "connectionStatus1";
            this.connectionStatus1.Size = new System.Drawing.Size(75, 20);
            this.connectionStatus1.TabIndex = 9;
            this.connectionStatus1.Text = "Disconnected";
            // 
            // ConnectionStatusLable
            // 
            this.ConnectionStatusLable.AutoSize = true;
            this.ConnectionStatusLable.Location = new System.Drawing.Point(269, 36);
            this.ConnectionStatusLable.Name = "ConnectionStatusLable";
            this.ConnectionStatusLable.Size = new System.Drawing.Size(95, 13);
            this.ConnectionStatusLable.TabIndex = 8;
            this.ConnectionStatusLable.Text = "Connection status:";
            // 
            // ConnectionStatusWindow
            // 
            this.ConnectionStatusWindow.Location = new System.Drawing.Point(269, 55);
            this.ConnectionStatusWindow.Multiline = true;
            this.ConnectionStatusWindow.Name = "ConnectionStatusWindow";
            this.ConnectionStatusWindow.Size = new System.Drawing.Size(243, 157);
            this.ConnectionStatusWindow.TabIndex = 6;
            // 
            // DisconnectCOMbutton
            // 
            this.DisconnectCOMbutton.BackColor = System.Drawing.Color.Transparent;
            this.DisconnectCOMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectCOMbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DisconnectCOMbutton.Location = new System.Drawing.Point(81, 188);
            this.DisconnectCOMbutton.Margin = new System.Windows.Forms.Padding(2);
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
            this.ConnectCOMbutton.Margin = new System.Windows.Forms.Padding(2);
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
            this.BitRate_list.Margin = new System.Windows.Forms.Padding(2);
            this.BitRate_list.Name = "BitRate_list";
            this.BitRate_list.Size = new System.Drawing.Size(92, 21);
            this.BitRate_list.TabIndex = 1;
            this.BitRate_list.Text = "9600";
            // 
            // COM_list
            // 
            this.COM_list.FormattingEnabled = true;
            this.COM_list.Location = new System.Drawing.Point(81, 55);
            this.COM_list.Margin = new System.Windows.Forms.Padding(2);
            this.COM_list.Name = "COM_list";
            this.COM_list.Size = new System.Drawing.Size(92, 21);
            this.COM_list.TabIndex = 0;
            this.COM_list.Click += new System.EventHandler(this.COM_select);
            // 
            // ConfigTab
            // 
            this.ConfigTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConfigTab.Controls.Add(this.connectionStatus2);
            this.ConfigTab.Controls.Add(this.ResValues2Button);
            this.ConfigTab.Controls.Add(this.ResValuesButton);
            this.ConfigTab.Controls.Add(this.label2);
            this.ConfigTab.Controls.Add(this.label1);
            this.ConfigTab.Controls.Add(this.upload_to_device_button);
            this.ConfigTab.Controls.Add(this.read_from_file_button);
            this.ConfigTab.Controls.Add(this.tableLayoutPanel2);
            this.ConfigTab.Controls.Add(this.save_to_file_button);
            this.ConfigTab.Controls.Add(this.read_from_device_button);
            this.ConfigTab.Controls.Add(this.tableLayoutPanel1);
            this.ConfigTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConfigTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigTab.Margin = new System.Windows.Forms.Padding(2);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Padding = new System.Windows.Forms.Padding(2);
            this.ConfigTab.Size = new System.Drawing.Size(788, 519);
            this.ConfigTab.TabIndex = 1;
            this.ConfigTab.Text = "Configuration";
            // 
            // connectionStatus2
            // 
            this.connectionStatus2.BackColor = System.Drawing.Color.Black;
            this.connectionStatus2.ForeColor = System.Drawing.Color.White;
            this.connectionStatus2.Location = new System.Drawing.Point(714, 0);
            this.connectionStatus2.Margin = new System.Windows.Forms.Padding(2);
            this.connectionStatus2.Name = "connectionStatus2";
            this.connectionStatus2.Size = new System.Drawing.Size(75, 20);
            this.connectionStatus2.TabIndex = 11;
            this.connectionStatus2.Text = "Disconnected";
            // 
            // ResValues2Button
            // 
            this.ResValues2Button.Location = new System.Drawing.Point(594, 385);
            this.ResValues2Button.Name = "ResValues2Button";
            this.ResValues2Button.Size = new System.Drawing.Size(101, 23);
            this.ResValues2Button.TabIndex = 10;
            this.ResValues2Button.Text = "Reset values";
            this.ResValues2Button.UseVisualStyleBackColor = true;
            this.ResValues2Button.Click += new System.EventHandler(this.ResValuesClickUL);
            // 
            // ResValuesButton
            // 
            this.ResValuesButton.Location = new System.Drawing.Point(594, 191);
            this.ResValuesButton.Name = "ResValuesButton";
            this.ResValuesButton.Size = new System.Drawing.Size(101, 23);
            this.ResValuesButton.TabIndex = 9;
            this.ResValuesButton.Text = "Reset values";
            this.ResValuesButton.UseVisualStyleBackColor = true;
            this.ResValuesButton.Click += new System.EventHandler(this.ResValuesClickDL);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Upload";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Download";
            // 
            // upload_to_device_button
            // 
            this.upload_to_device_button.Location = new System.Drawing.Point(91, 332);
            this.upload_to_device_button.Margin = new System.Windows.Forms.Padding(2);
            this.upload_to_device_button.Name = "upload_to_device_button";
            this.upload_to_device_button.Size = new System.Drawing.Size(96, 46);
            this.upload_to_device_button.TabIndex = 5;
            this.upload_to_device_button.Text = "Upload to device";
            this.upload_to_device_button.UseVisualStyleBackColor = true;
            this.upload_to_device_button.Click += new System.EventHandler(this.UploadeParametersClick);
            // 
            // read_from_file_button
            // 
            this.read_from_file_button.Location = new System.Drawing.Point(91, 274);
            this.read_from_file_button.Margin = new System.Windows.Forms.Padding(2);
            this.read_from_file_button.Name = "read_from_file_button";
            this.read_from_file_button.Size = new System.Drawing.Size(96, 46);
            this.read_from_file_button.TabIndex = 4;
            this.read_from_file_button.Text = "Read from file";
            this.read_from_file_button.UseVisualStyleBackColor = true;
            this.read_from_file_button.Click += new System.EventHandler(this.ReadFromFileClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.unit_ID_textBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lrv_textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.alarm_L_textBox2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.alarm_H_textBox2, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.unit_ID_2_lable, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lrv_2_lable, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.alarm_L_2_lable, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.alarm_H_2_lable, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.urv_textBox2, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(191, 274);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(505, 105);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // unit_ID_textBox2
            // 
            this.unit_ID_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_ID_textBox2.Location = new System.Drawing.Point(3, 55);
            this.unit_ID_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.unit_ID_textBox2.Multiline = true;
            this.unit_ID_textBox2.Name = "unit_ID_textBox2";
            this.unit_ID_textBox2.Size = new System.Drawing.Size(95, 47);
            this.unit_ID_textBox2.TabIndex = 14;
            this.unit_ID_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lrv_textBox2
            // 
            this.lrv_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrv_textBox2.Location = new System.Drawing.Point(103, 55);
            this.lrv_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.lrv_textBox2.Multiline = true;
            this.lrv_textBox2.Name = "lrv_textBox2";
            this.lrv_textBox2.Size = new System.Drawing.Size(95, 47);
            this.lrv_textBox2.TabIndex = 13;
            this.lrv_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm_L_textBox2
            // 
            this.alarm_L_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_L_textBox2.Location = new System.Drawing.Point(303, 55);
            this.alarm_L_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.alarm_L_textBox2.Multiline = true;
            this.alarm_L_textBox2.Name = "alarm_L_textBox2";
            this.alarm_L_textBox2.Size = new System.Drawing.Size(95, 47);
            this.alarm_L_textBox2.TabIndex = 11;
            this.alarm_L_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm_H_textBox2
            // 
            this.alarm_H_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_H_textBox2.Location = new System.Drawing.Point(403, 55);
            this.alarm_H_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.alarm_H_textBox2.Multiline = true;
            this.alarm_H_textBox2.Name = "alarm_H_textBox2";
            this.alarm_H_textBox2.Size = new System.Drawing.Size(96, 47);
            this.alarm_H_textBox2.TabIndex = 10;
            this.alarm_H_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unit_ID_2_lable
            // 
            this.unit_ID_2_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_ID_2_lable.AutoSize = true;
            this.unit_ID_2_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_ID_2_lable.Location = new System.Drawing.Point(25, 18);
            this.unit_ID_2_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unit_ID_2_lable.Name = "unit_ID_2_lable";
            this.unit_ID_2_lable.Size = new System.Drawing.Size(50, 17);
            this.unit_ID_2_lable.TabIndex = 9;
            this.unit_ID_2_lable.Text = "Unit ID";
            // 
            // lrv_2_lable
            // 
            this.lrv_2_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lrv_2_lable.AutoSize = true;
            this.lrv_2_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrv_2_lable.Location = new System.Drawing.Point(133, 18);
            this.lrv_2_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lrv_2_lable.Name = "lrv_2_lable";
            this.lrv_2_lable.Size = new System.Drawing.Size(35, 17);
            this.lrv_2_lable.TabIndex = 8;
            this.lrv_2_lable.Text = "LRV";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "URV";
            // 
            // alarm_L_2_lable
            // 
            this.alarm_L_2_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarm_L_2_lable.AutoSize = true;
            this.alarm_L_2_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_L_2_lable.Location = new System.Drawing.Point(310, 18);
            this.alarm_L_2_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alarm_L_2_lable.Name = "alarm_L_2_lable";
            this.alarm_L_2_lable.Size = new System.Drawing.Size(80, 17);
            this.alarm_L_2_lable.TabIndex = 6;
            this.alarm_L_2_lable.Text = "Alarm LOW";
            // 
            // alarm_H_2_lable
            // 
            this.alarm_H_2_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarm_H_2_lable.AutoSize = true;
            this.alarm_H_2_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_H_2_lable.Location = new System.Drawing.Point(411, 18);
            this.alarm_H_2_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alarm_H_2_lable.Name = "alarm_H_2_lable";
            this.alarm_H_2_lable.Size = new System.Drawing.Size(82, 17);
            this.alarm_H_2_lable.TabIndex = 5;
            this.alarm_H_2_lable.Text = "Alarm HIGH";
            // 
            // urv_textBox2
            // 
            this.urv_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urv_textBox2.Location = new System.Drawing.Point(203, 55);
            this.urv_textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.urv_textBox2.Multiline = true;
            this.urv_textBox2.Name = "urv_textBox2";
            this.urv_textBox2.Size = new System.Drawing.Size(95, 47);
            this.urv_textBox2.TabIndex = 12;
            this.urv_textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_to_file_button
            // 
            this.save_to_file_button.Location = new System.Drawing.Point(91, 141);
            this.save_to_file_button.Margin = new System.Windows.Forms.Padding(2);
            this.save_to_file_button.Name = "save_to_file_button";
            this.save_to_file_button.Size = new System.Drawing.Size(96, 46);
            this.save_to_file_button.TabIndex = 2;
            this.save_to_file_button.Text = "Save to file";
            this.save_to_file_button.UseVisualStyleBackColor = true;
            this.save_to_file_button.Click += new System.EventHandler(this.save_to_file);
            // 
            // read_from_device_button
            // 
            this.read_from_device_button.Location = new System.Drawing.Point(91, 83);
            this.read_from_device_button.Margin = new System.Windows.Forms.Padding(2);
            this.read_from_device_button.Name = "read_from_device_button";
            this.read_from_device_button.Size = new System.Drawing.Size(96, 46);
            this.read_from_device_button.TabIndex = 1;
            this.read_from_device_button.Text = "Read from device";
            this.read_from_device_button.UseVisualStyleBackColor = true;
            this.read_from_device_button.Click += new System.EventHandler(this.read_config_button);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.alarm_H_textBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.alarm_L_textBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.urv_textBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lrv_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.alarm_H_lable, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.alarm_L_lable, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.urv_lable, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lrv_lable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.unit_id_lable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.unit_ID_textBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(191, 83);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // alarm_H_textBox
            // 
            this.alarm_H_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_H_textBox.Location = new System.Drawing.Point(403, 55);
            this.alarm_H_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.alarm_H_textBox.Multiline = true;
            this.alarm_H_textBox.Name = "alarm_H_textBox";
            this.alarm_H_textBox.ReadOnly = true;
            this.alarm_H_textBox.Size = new System.Drawing.Size(96, 47);
            this.alarm_H_textBox.TabIndex = 9;
            this.alarm_H_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm_L_textBox
            // 
            this.alarm_L_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_L_textBox.Location = new System.Drawing.Point(303, 55);
            this.alarm_L_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.alarm_L_textBox.Multiline = true;
            this.alarm_L_textBox.Name = "alarm_L_textBox";
            this.alarm_L_textBox.ReadOnly = true;
            this.alarm_L_textBox.Size = new System.Drawing.Size(95, 47);
            this.alarm_L_textBox.TabIndex = 8;
            this.alarm_L_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urv_textBox
            // 
            this.urv_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urv_textBox.Location = new System.Drawing.Point(203, 55);
            this.urv_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.urv_textBox.Multiline = true;
            this.urv_textBox.Name = "urv_textBox";
            this.urv_textBox.ReadOnly = true;
            this.urv_textBox.Size = new System.Drawing.Size(95, 47);
            this.urv_textBox.TabIndex = 7;
            this.urv_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lrv_textBox
            // 
            this.lrv_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrv_textBox.Location = new System.Drawing.Point(103, 55);
            this.lrv_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.lrv_textBox.Multiline = true;
            this.lrv_textBox.Name = "lrv_textBox";
            this.lrv_textBox.ReadOnly = true;
            this.lrv_textBox.Size = new System.Drawing.Size(95, 47);
            this.lrv_textBox.TabIndex = 6;
            this.lrv_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm_H_lable
            // 
            this.alarm_H_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarm_H_lable.AutoSize = true;
            this.alarm_H_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_H_lable.Location = new System.Drawing.Point(411, 18);
            this.alarm_H_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alarm_H_lable.Name = "alarm_H_lable";
            this.alarm_H_lable.Size = new System.Drawing.Size(82, 17);
            this.alarm_H_lable.TabIndex = 4;
            this.alarm_H_lable.Text = "Alarm HIGH";
            // 
            // alarm_L_lable
            // 
            this.alarm_L_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alarm_L_lable.AutoSize = true;
            this.alarm_L_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_L_lable.Location = new System.Drawing.Point(310, 18);
            this.alarm_L_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alarm_L_lable.Name = "alarm_L_lable";
            this.alarm_L_lable.Size = new System.Drawing.Size(80, 17);
            this.alarm_L_lable.TabIndex = 3;
            this.alarm_L_lable.Text = "Alarm LOW";
            // 
            // urv_lable
            // 
            this.urv_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.urv_lable.AutoSize = true;
            this.urv_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urv_lable.Location = new System.Drawing.Point(232, 18);
            this.urv_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urv_lable.Name = "urv_lable";
            this.urv_lable.Size = new System.Drawing.Size(37, 17);
            this.urv_lable.TabIndex = 2;
            this.urv_lable.Text = "URV";
            // 
            // lrv_lable
            // 
            this.lrv_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lrv_lable.AutoSize = true;
            this.lrv_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrv_lable.Location = new System.Drawing.Point(133, 18);
            this.lrv_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lrv_lable.Name = "lrv_lable";
            this.lrv_lable.Size = new System.Drawing.Size(35, 17);
            this.lrv_lable.TabIndex = 1;
            this.lrv_lable.Text = "LRV";
            // 
            // unit_id_lable
            // 
            this.unit_id_lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unit_id_lable.AutoSize = true;
            this.unit_id_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_id_lable.Location = new System.Drawing.Point(25, 18);
            this.unit_id_lable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unit_id_lable.Name = "unit_id_lable";
            this.unit_id_lable.Size = new System.Drawing.Size(50, 17);
            this.unit_id_lable.TabIndex = 0;
            this.unit_id_lable.Text = "Unit ID";
            // 
            // unit_ID_textBox
            // 
            this.unit_ID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_ID_textBox.Location = new System.Drawing.Point(3, 55);
            this.unit_ID_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.unit_ID_textBox.Multiline = true;
            this.unit_ID_textBox.Name = "unit_ID_textBox";
            this.unit_ID_textBox.ReadOnly = true;
            this.unit_ID_textBox.Size = new System.Drawing.Size(95, 47);
            this.unit_ID_textBox.TabIndex = 5;
            this.unit_ID_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MonitoringTab
            // 
            this.MonitoringTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MonitoringTab.Controls.Add(this.connectionStatus3);
            this.MonitoringTab.Controls.Add(this.LoggedScaled);
            this.MonitoringTab.Controls.Add(this.LoggedRaw);
            this.MonitoringTab.Controls.Add(this.StopMonitoringButton);
            this.MonitoringTab.Controls.Add(this.MonitorRawButton);
            this.MonitoringTab.Controls.Add(this.MonitorScaledButton);
            this.MonitoringTab.Controls.Add(this.chart1);
            this.MonitoringTab.Location = new System.Drawing.Point(4, 22);
            this.MonitoringTab.Name = "MonitoringTab";
            this.MonitoringTab.Padding = new System.Windows.Forms.Padding(3);
            this.MonitoringTab.Size = new System.Drawing.Size(788, 519);
            this.MonitoringTab.TabIndex = 2;
            this.MonitoringTab.Text = "Monitor";
            // 
            // connectionStatus3
            // 
            this.connectionStatus3.BackColor = System.Drawing.Color.Black;
            this.connectionStatus3.ForeColor = System.Drawing.Color.White;
            this.connectionStatus3.Location = new System.Drawing.Point(714, 254);
            this.connectionStatus3.Margin = new System.Windows.Forms.Padding(2);
            this.connectionStatus3.Multiline = true;
            this.connectionStatus3.Name = "connectionStatus3";
            this.connectionStatus3.Size = new System.Drawing.Size(75, 26);
            this.connectionStatus3.TabIndex = 17;
            this.connectionStatus3.Text = "Disconnected";
            // 
            // LoggedScaled
            // 
            this.LoggedScaled.FormattingEnabled = true;
            this.LoggedScaled.Location = new System.Drawing.Point(5, 284);
            this.LoggedScaled.Margin = new System.Windows.Forms.Padding(2);
            this.LoggedScaled.Name = "LoggedScaled";
            this.LoggedScaled.Size = new System.Drawing.Size(367, 238);
            this.LoggedScaled.TabIndex = 16;
            // 
            // LoggedRaw
            // 
            this.LoggedRaw.FormattingEnabled = true;
            this.LoggedRaw.Location = new System.Drawing.Point(397, 284);
            this.LoggedRaw.Margin = new System.Windows.Forms.Padding(2);
            this.LoggedRaw.Name = "LoggedRaw";
            this.LoggedRaw.Size = new System.Drawing.Size(388, 238);
            this.LoggedRaw.TabIndex = 15;
            // 
            // StopMonitoringButton
            // 
            this.StopMonitoringButton.Location = new System.Drawing.Point(237, 254);
            this.StopMonitoringButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopMonitoringButton.Name = "StopMonitoringButton";
            this.StopMonitoringButton.Size = new System.Drawing.Size(111, 25);
            this.StopMonitoringButton.TabIndex = 14;
            this.StopMonitoringButton.Text = "Stop monitoring";
            this.StopMonitoringButton.UseVisualStyleBackColor = true;
            this.StopMonitoringButton.Click += new System.EventHandler(this.StopMonitoring);
            // 
            // MonitorRawButton
            // 
            this.MonitorRawButton.Location = new System.Drawing.Point(122, 254);
            this.MonitorRawButton.Margin = new System.Windows.Forms.Padding(2);
            this.MonitorRawButton.Name = "MonitorRawButton";
            this.MonitorRawButton.Size = new System.Drawing.Size(111, 25);
            this.MonitorRawButton.TabIndex = 12;
            this.MonitorRawButton.Text = "Monitor raw";
            this.MonitorRawButton.UseVisualStyleBackColor = true;
            this.MonitorRawButton.Click += new System.EventHandler(this.MonitorRawClick);
            // 
            // MonitorScaledButton
            // 
            this.MonitorScaledButton.Location = new System.Drawing.Point(6, 254);
            this.MonitorScaledButton.Margin = new System.Windows.Forms.Padding(2);
            this.MonitorScaledButton.Name = "MonitorScaledButton";
            this.MonitorScaledButton.Size = new System.Drawing.Size(111, 25);
            this.MonitorScaledButton.TabIndex = 11;
            this.MonitorScaledButton.Text = "Monitor scaled";
            this.MonitorScaledButton.UseVisualStyleBackColor = true;
            this.MonitorScaledButton.Click += new System.EventHandler(this.MonitorScaledClick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(5, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Scaled value";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Raw value";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(778, 242);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // openFileDialogSSC
            // 
            this.openFileDialogSSC.FileName = "openFileDialog1";
            // 
            // SoftSensConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SoftSensConf";
            this.Text = "SoftSensConf";
            this.tabControl1.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.ConfigTab.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MonitoringTab.ResumeLayout(false);
            this.MonitoringTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.TextBox ConnectionStatusWindow;
        private System.Windows.Forms.Button save_to_file_button;
        private System.Windows.Forms.Button read_from_device_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button upload_to_device_button;
        private System.Windows.Forms.Button read_from_file_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alarm_H_lable;
        private System.Windows.Forms.Label alarm_L_lable;
        private System.Windows.Forms.Label urv_lable;
        private System.Windows.Forms.Label lrv_lable;
        private System.Windows.Forms.Label unit_id_lable;
        private System.Windows.Forms.Label unit_ID_2_lable;
        private System.Windows.Forms.Label lrv_2_lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label alarm_L_2_lable;
        private System.Windows.Forms.Label alarm_H_2_lable;
        private System.Windows.Forms.TextBox alarm_H_textBox;
        private System.Windows.Forms.TextBox alarm_L_textBox;
        private System.Windows.Forms.TextBox urv_textBox;
        private System.Windows.Forms.TextBox lrv_textBox;
        private System.Windows.Forms.TextBox unit_ID_textBox;
        private System.Windows.Forms.TextBox unit_ID_textBox2;
        private System.Windows.Forms.TextBox lrv_textBox2;
        private System.Windows.Forms.TextBox urv_textBox2;
        private System.Windows.Forms.TextBox alarm_L_textBox2;
        private System.Windows.Forms.TextBox alarm_H_textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialogSSC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ResValues2Button;
        private System.Windows.Forms.Button ResValuesButton;
        private System.Windows.Forms.Label ConnectionStatusLable;
        private System.Windows.Forms.TabPage MonitoringTab;
        private System.Windows.Forms.Timer timerScaled;
        private System.Windows.Forms.Timer timerRaw;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button MonitorScaledButton;
        private System.Windows.Forms.Button StopMonitoringButton;
        private System.Windows.Forms.Button MonitorRawButton;
        private System.Windows.Forms.ListBox LoggedRaw;
        private System.Windows.Forms.ListBox LoggedScaled;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TextBox connectionStatus1;
        private System.Windows.Forms.TextBox connectionStatus2;
        private System.Windows.Forms.TextBox connectionStatus3;
    }
}

