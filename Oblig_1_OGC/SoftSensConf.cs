using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace Oblig_1_OGC
{
    public partial class SoftSensConf : Form
    {
        List<float> scaledReading = new List<float>();
        List<float> rawReading = new List<float>();
        List<string> timeStampScaled = new List<string>();
        List<string> timeStampRaw = new List<string>();
        
        public SoftSensConf()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecivedHandler);

            timerScaled.Interval = 5000;
            timerScaled.Tick += new EventHandler(timerScaled_Tick);

            timerRaw.Interval = 5000;
            timerRaw.Tick += new EventHandler(timerRaw_Tick);

            timerStatus.Interval = 5000;
            timerStatus.Tick += new EventHandler(timerStatus_Tick);
            
        }
        private void timerScaled_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
        }

        private void timerRaw_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readstatus");
            }
            else if(!serialPort1.IsOpen)
            {
                timerStatus.Stop();
                connectionStatus1.Text = "Disconnected";
                connectionStatus2.Text = "Disconnected";
                connectionStatus3.Text = "Disconnected";
                connectionStatus1.ForeColor = Color.White;
                connectionStatus2.ForeColor = Color.White;
                connectionStatus3.ForeColor = Color.White;
                connectionStatus1.BackColor = Color.Black;
                connectionStatus2.BackColor = Color.Black;
                connectionStatus3.BackColor = Color.Black;
                ConnectionStatusWindow.AppendText("Status: Disconnected" + "\r\n");
                MessageBox.Show("Disconnected!" + "\r\n" + "Check connection");
            }
        }

        void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();
            ConnectionStatusWindow.Invoke((MethodInvoker)delegate
            {  
            //Handeling return from readstatus
            if (RecievedData.Contains("readstatus"))
            {                
                if (RecievedData.Contains("0"))
                {
                    connectionStatus1.Text = "Connected";
                    connectionStatus2.Text = "Connected";
                    connectionStatus3.Text = "Connected";
                    connectionStatus1.ForeColor = Color.Black;
                    connectionStatus2.ForeColor = Color.Black;
                    connectionStatus3.ForeColor = Color.Black;
                    connectionStatus1.BackColor = Color.Green;
                    connectionStatus2.BackColor = Color.Green;
                    connectionStatus3.BackColor = Color.Green;
                }
                else if (RecievedData.Contains("1"))
                {
                    connectionStatus1.Text = "Warning!";
                    connectionStatus2.Text = "Warning!";
                    connectionStatus3.Text = "Warning!";
                    connectionStatus1.ForeColor = Color.Black;
                    connectionStatus2.ForeColor = Color.Black;
                    connectionStatus3.ForeColor = Color.Black;
                    connectionStatus1.BackColor = Color.Yellow;
                    connectionStatus2.BackColor = Color.Yellow;
                    connectionStatus3.BackColor = Color.Yellow;
                }
                else if (RecievedData.Contains("2"))
                {
                    connectionStatus1.Text = "Alarm LOW";
                    connectionStatus2.Text = "Alarm LOW";
                    connectionStatus3.Text = "Alarm LOW";
                    connectionStatus1.ForeColor = Color.Black;
                    connectionStatus2.ForeColor = Color.Black;
                    connectionStatus3.ForeColor = Color.Black;
                    connectionStatus1.BackColor = Color.Red;
                    connectionStatus2.BackColor = Color.Red;
                    connectionStatus3.BackColor = Color.Red;
                }
                else if (RecievedData.Contains("3"))
                {
                    connectionStatus1.Text = "Alarm HIGH";
                    connectionStatus2.Text = "Alarm HIGH";
                    connectionStatus3.Text = "Alarm HIGH";
                    connectionStatus1.ForeColor = Color.Black;
                    connectionStatus2.ForeColor = Color.Black;
                    connectionStatus3.ForeColor = Color.Black;
                    connectionStatus1.BackColor = Color.Red;
                    connectionStatus2.BackColor = Color.Red;
                    connectionStatus3.BackColor = Color.Red;
                }
            }
            //Handeling return from readconf
            if (RecievedData.Contains("readconf"))
            {
                string[] splitData = RecievedData.Split(';');
                
                unit_ID_textBox.Text = splitData[1];
                lrv_textBox.Text = splitData[2];
                urv_textBox.Text = splitData[3];
                alarm_L_textBox.Text = splitData[4];
                alarm_H_textBox.Text = splitData[5];
            }
            //Handeling return from writeconf
            else if (RecievedData.Contains("writeconf"))
            {
                if (RecievedData.Contains("1"))
                {
                    MessageBox.Show("Password accepted!" + "\r\n" + "Parameters successfully changed");
                }
                else if (RecievedData.Contains("0"))
                {
                    MessageBox.Show("Password not accepted!" + "\r\n" + "Try again");
                }
                else if (RecievedData.Contains ("You"))
                {
                    MessageBox.Show("Something wrong with input parameters!" + "\r\n" + "Try again");
                }
            }
            //Handeling return from readscaled
            else if (RecievedData.Contains("readscaled"))
            {
                string[] splitData = RecievedData.Split(';');
                string date = DateAndTime.DateString + ";" + DateAndTime.TimeString;
                LoggedScaled.Items.Add(date + ";" + splitData[1]);

                scaledReading.Add(float.Parse(splitData[1], CultureInfo.InvariantCulture));
                timeStampScaled.Add(date);

                chart1.Series[0].Points.DataBindXY(timeStampScaled, scaledReading);
                chart1.Invalidate();    
            }
            //Handeling return from readraw
            else if (RecievedData.Contains("readraw"))
            {
                string[] splitData = RecievedData.Split(';');
                string date = DateAndTime.DateString + ";" + DateAndTime.TimeString;

                rawReading.Add(float.Parse(splitData[1], CultureInfo.InvariantCulture));
                LoggedRaw.Items.Add(date + ";" + splitData[1]);

                timeStampRaw.Add(date);

                chart1.Series[1].Points.DataBindXY(timeStampRaw, rawReading);
                chart1.Invalidate();

            }
            });
        }

        private void COM_select(object sender, EventArgs e)
        {
            COM_list.Items.Clear();
            COM_list.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Connect_COM_button(object sender, EventArgs e)
        {
            bool okToConnenct = true;

            int.TryParse(BitRate_list.Text, out int bitRate);

            try
            {
                serialPort1.PortName = COM_list.Text;
                serialPort1.BaudRate = bitRate;
            }
            catch (FormatException ex)
            {
                okToConnenct = false;
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                okToConnenct = false;
                MessageBox.Show(ex.Message);
            }
            catch (System.IO.IOException ex)
            {
                okToConnenct = false;
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                okToConnenct = false;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (okToConnenct)
                {
                    serialPort1.Open();
                    timerStatus.Start();
                    if (serialPort1.IsOpen)
                    {
                        ConnectionStatusWindow.AppendText("Status: Connected" + "\r\n");
                    }
                    
                }
            }
        }

        private void Disconnect_COM_button(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void read_config_button(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readconf");
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }
        private void save_to_file(object sender, EventArgs e)
        {
            string fileNameWF = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = ("ssc files (*.ssc)|*.ssc|All files (*.*)|*.*");
            saveFileDialog1.FilterIndex = 2;


            if (serialPort1.IsOpen
                && unit_ID_textBox.Text.Length > 0
                && lrv_textBox.Text.Length > 0
                && urv_textBox.Text.Length > 0
                && alarm_L_textBox.Text.Length > 0
                && alarm_H_textBox.Text.Length > 0)
            {
                DialogResult dr = saveFileDialog1.ShowDialog();
                fileNameWF = saveFileDialog1.FileName;
                bool saveSucess = false;

                try
                {
                    if (dr == DialogResult.OK )
                    {
                        StreamWriter sw = new StreamWriter(fileNameWF);
                        string[] save_string = { unit_ID_textBox.Text, ";", lrv_textBox.Text, ";",
                          urv_textBox.Text, ";", alarm_L_textBox.Text, ";", alarm_H_textBox.Text};

                        foreach (string line in save_string)
                        {
                            sw.Write(line);
                        }
                        sw.Close();
                        saveSucess = true;
                    }
                }
                catch (Exception)
                {
                    saveSucess = false;
                }
                finally
                {
                    if (saveSucess)
                    {
                        MessageBox.Show("Successfully saved to " + fileNameWF);
                    }
                    else
                    {
                        MessageBox.Show("No parameters was saved");
                    }
                }
            }
            else if (serialPort1.IsOpen
                    &&unit_ID_textBox.Text.Length <= 0
                    && lrv_textBox.Text.Length <= 0
                    && urv_textBox.Text.Length <= 0
                    && alarm_L_textBox.Text.Length <= 0
                    && alarm_H_textBox.Text.Length <= 0)
            {
                MessageBox.Show("Try again!" + "\r\n" + "All parameterwindows must be filled");
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }

        private void ResValuesClickDL(object sender, EventArgs e)
        {
            unit_ID_textBox.Clear();
            lrv_textBox.Clear();   
            urv_textBox.Clear();    
            alarm_L_textBox.Clear();
            alarm_H_textBox.Clear();
        }

        private void ReadFromFileClick(object sender, EventArgs e)
        {
            bool successRF = false;
            string fileNameRF = string.Empty;
            string[] fileSplit = new string[] { };
            openFileDialogSSC.InitialDirectory = "C:\\";
            openFileDialogSSC.Filter = ("ssc files (*.ssc)|*.ssc|All files (.)|.");
            openFileDialogSSC.FilterIndex = 2;

            fileNameRF = openFileDialogSSC.FileName;


            if (serialPort1.IsOpen)
            {
                try
                {
                    if (DialogResult.OK == openFileDialogSSC.ShowDialog())
                    {
                        fileNameRF = openFileDialogSSC.FileName;
                        successRF = true;
                    }
                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("No file chosen!");
                }
                finally
                {
                    if (successRF)
                    {
                        StreamReader sr = new StreamReader(fileNameRF);
                        fileSplit = sr.ReadToEnd().Split(';');
                        unit_ID_textBox2.Text = fileSplit[0];
                        lrv_textBox2.Text = fileSplit[1];
                        urv_textBox2.Text = fileSplit[2];
                        alarm_L_textBox2.Text = fileSplit[3];
                        alarm_H_textBox2.Text = fileSplit[4];
                        MessageBox.Show("Parameters gathered from fil " + fileNameRF);
                    }
                }
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }

        }

        private void ResValuesClickUL(object sender, EventArgs e)
        {
            unit_ID_textBox2.Clear();
            lrv_textBox2.Clear();
            urv_textBox2.Clear();
            alarm_L_textBox2.Clear();
            alarm_H_textBox2.Clear();
        }

        private void UploadeParametersClick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen
                && unit_ID_textBox2.Text.Length > 0
                && lrv_textBox2.Text.Length > 0
                && urv_textBox2.Text.Length > 0
                && alarm_L_textBox2.Text.Length > 0
                && alarm_H_textBox2.Text.Length > 0)
            {
                string message, title, defaultValue;
                object passwordInput;

                message = "Please enter password for this task";
                title = "Login";
                defaultValue = "********";

                passwordInput = Interaction.InputBox(message, title, defaultValue);

                string sendMessage = "writeconf>" + passwordInput.ToString() + ">" + unit_ID_textBox2.Text + ";" + lrv_textBox2.Text + ";"
                                        + urv_textBox2.Text + ";" + alarm_L_textBox2.Text + ";" + alarm_H_textBox2.Text;

                serialPort1.WriteLine(sendMessage);
            }
            else if (serialPort1.IsOpen
                    &&unit_ID_textBox2.Text.Length <= 0
                    && lrv_textBox2.Text.Length <= 0
                    && urv_textBox2.Text.Length <= 0
                    && alarm_L_textBox2.Text.Length <= 0
                    && alarm_H_textBox2.Text.Length <= 0)
            {
                MessageBox.Show("Try again!" + "\r\n" + "All parameterwindows must be filled");
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }

        private void MonitorScaledClick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timerScaled.Start();
                timerScaled_Tick(null, null);
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }

        private void MonitorRawClick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timerRaw.Start();
                timerRaw_Tick(null, null);
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }

        private void StopMonitoring(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timerScaled.Stop();
                timerRaw.Stop();

                string message = "Do you wanna save logged values?";
                string caption = "Save data?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = DialogResult.None;
                result = MessageBox.Show(message, caption, buttons);

                saveFileDialogCSV.InitialDirectory = "c:\\"; 
                saveFileDialogCSV.Filter = "CSV file (.csv)|.csv|All files (.)|.";
                
                
                if (result == DialogResult.Yes)
                {
                    if (LoggedRaw.Items.Count > 0)
                    {
                        try
                        {
                            saveFileDialogCSV.Title = "Save Raw Data";
                            string saveRaw;
                            saveFileDialogCSV.ShowDialog();
                            string fileName = saveFileDialogCSV.FileName;
                            StreamWriter swR = new StreamWriter(fileName);

                            foreach (var item in LoggedRaw.Items)
                            {
                                saveRaw = item.ToString();
                                swR.Write(saveRaw);
                            }
                            swR.Close();
                        }
                        catch (Exception)
                        {}
                        finally
                        {
                            LoggedRaw.Items.Clear();
                        }


                    }
                    else if (LoggedRaw.Items.Count <= 0)
                    {
                        MessageBox.Show("Raw data not saved because there was no data to save");
                    }
                    if (LoggedScaled.Items.Count > 0)
                    {
                        string fileName = saveFileDialogCSV.FileName;

                        try
                        {
                            saveFileDialogCSV.Title = "Save Scaled Data";
                            string saveScaled;
                            saveFileDialogCSV.ShowDialog();
                            StreamWriter swS = new StreamWriter(fileName);

                            foreach (var item in LoggedScaled.Items)
                            {
                                saveScaled = item.ToString();
                                swS.Write(saveScaled);
                            }
                            swS.Close();
                        }
                        catch (Exception)
                        {}
                        finally
                        {
                            LoggedRaw.Items.Clear();
                        }
                    }
                    else if (LoggedScaled.Items.Count <= 0)
                    {
                        MessageBox.Show("Scaled data not saved because there was no data to save");
                    }
                }
            }
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }
    }
}
