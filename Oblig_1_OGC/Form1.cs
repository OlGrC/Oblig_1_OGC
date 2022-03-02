using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace Oblig_1_OGC
{
    public partial class Form1 : Form
    {
        List<int> scaledReading = new List<int>();
        List<float> rawReading = new List<float>();
        List<DateTime> Timestamp = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecivedHandler);

            timerScaled.Interval = 5000;
            timerScaled.Tick += new EventHandler(timerScaled_Tick);

            timerRaw.Interval = 5000;
            timerRaw.Tick += new EventHandler(timerScaled_Tick);

        }
        private void timerScaled_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
        }

        private void timerRaw_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        void DataRecivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();

            if (RecievedData.Contains("readconf"))
            {
                string[] splitData = RecievedData.Split(';');

                unit_ID_textBox.Text = splitData[1];
                lrv_textBox.Text = splitData[2];
                urv_textBox.Text = splitData[3];
                alarm_L_textBox.Text = splitData[4];
                alarm_H_textBox.Text = splitData[5];
            }
            if (RecievedData.Contains("writeconf"))
            {
                if (RecievedData.Contains("1"))
                {
                    MessageBox.Show("Password accepted!" + "\r\n" + "Parameters successfully changed");
                }
                else if (RecievedData.Contains(""))
                {
                    MessageBox.Show("Password not accepted!" + "\r\n" + "Try again");
                }
                else if (RecievedData.Contains ("You"))
                {
                    MessageBox.Show("Something wrong with input parameters!" + "\r\n" + "Try again");
                }
            }
                
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
                    ConnectionStatusWindow.AppendText("Status: Connected" + "\r\n");
                }
            }
        }

        private void Disconnect_COM_button(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                ConnectionStatusWindow.AppendText("Status: Disconnected" + "\r\n");
            }
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


            if (serialPort1.IsOpen)
            {
                DialogResult dr = saveFileDialog1.ShowDialog();
                fileNameWF = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fileNameWF);

                try
                {
                    if (dr == DialogResult.OK)
                    {
                        string[] save_string = { unit_ID_textBox.Text, ";", lrv_textBox.Text, ";",
                          urv_textBox.Text, ";", alarm_L_textBox.Text, ";", alarm_H_textBox.Text};

                        foreach (string line in save_string)
                        {
                            sw.Write(line);
                        }
                        MessageBox.Show("Successfully saved to " + fileNameWF);
                    }
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Aborted!");
                }
                finally
                {
                    sw.Close();
                }
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
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = ("ssc files (*.ssc)|*.ssc");
            openFileDialog1.FilterIndex = 2;

            fileNameRF = openFileDialog1.FileName;


            if (serialPort1.IsOpen)
            {
                try
                {
                    if (DialogResult.OK == openFileDialog1.ShowDialog())
                    {
                        fileNameRF = openFileDialog1.FileName;
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
            if (serialPort1.IsOpen)
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
            else
            {
                string message = "Not allowed!" + "\r\n" + "Establish connection first";
                MessageBox.Show(message);
            }
        }
    }
}
