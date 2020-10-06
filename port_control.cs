using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net.Configuration;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    class port_control
    {
        private SerialPort port = new SerialPort("COM1", 38400, Parity.None, 8, StopBits.One);

        public void Connect()
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
                else
                {
                    port.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public void Close()
        {
            try
            {
                port.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
