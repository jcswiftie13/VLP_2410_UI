using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    public partial class Form1 : Form
    {
        private PortControl comport = new PortControl();
        private string respond;
        public Form1()
        {
            InitializeComponent();
            comport.Connect();
        }

        private void SetLight_Click(object sender, EventArgs e)
        {
            string command = comport.CalChecksum(Convert.ToInt32(Intensity.Value).ToString(), "@00F");
            Display.Text = $"Set light intensity to {Intensity.Value}";
            comport.SendData(command);
            respond = comport.GetData();
            if (respond != "OK")
            {
                Display.Text = respond;
            }
        }

        private void On_CheckedChanged(object sender, EventArgs e)
        {
            if (On.Checked)
            {
                Display.Text = "Light on";
                comport.SendData("@00L1007DCRLF");
                respond = comport.GetData();
                if (respond != "OK")
                {
                    Display.Text = respond;
                }
            }
        }

        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            if (Off.Checked)
            {
                Display.Text = "Light off";
                comport.SendData("@00L0007CCRLF");
                respond = comport.GetData();
                if (respond != "OK")
                {
                    Display.Text = respond;
                }
            }
        }
    }
}
