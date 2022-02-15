using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Oblig_1_OGC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void COM_select(object sender, EventArgs e)
        {
            COM_list.Items.Clear();
            COM_list.Items.AddRange(SerialPort.GetPortNames());
        }

        private void Connect_COM_button(object sender, EventArgs e)
        {
            bool okToConnenct = true;

            try
            {
                serialPort1.PortName = COM_list.Text;
            }
            catch (ArgumentException ex)
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
            ConnectionStatusWindow.AppendText("Status: Disconnected" + "\r\n");
        }
    }
}
