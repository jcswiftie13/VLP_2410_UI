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
        private DeviceControl DControl = new DeviceControl();
        private System.ComponentModel.IContainer components = null;
        private Button SetLight;
        private Button StartPort;
        private NumericUpDown Intensity;
        private RadioButton On;
        private RadioButton Off;
        private TextBox Display;
        private TextBox Baudrate;
        private GroupBox GroupBox1;
        private GroupBox GroupBox2;
        private Label ComportLabel;
        private Label BaudLabel;
        private ComboBox Comport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        private void InitializeComponent()
        {
            this.SetLight = new System.Windows.Forms.Button();
            this.StartPort = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.On = new System.Windows.Forms.RadioButton();
            this.Intensity = new System.Windows.Forms.NumericUpDown();
            this.Off = new System.Windows.Forms.RadioButton();
            this.ComportLabel = new System.Windows.Forms.Label();
            this.BaudLabel = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Comport = new System.Windows.Forms.ComboBox();
            this.Baudrate = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetLight
            // 
            this.SetLight.Location = new System.Drawing.Point(165, 250);
            this.SetLight.Name = "SetLight";
            this.SetLight.Size = new System.Drawing.Size(75, 20);
            this.SetLight.TabIndex = 0;
            this.SetLight.Text = "SetLight";
            this.SetLight.Click += new System.EventHandler(this.SetLight_Click);
            // 
            // StartPort
            // 
            this.StartPort.Location = new System.Drawing.Point(165, 121);
            this.StartPort.Name = "StartPort";
            this.StartPort.Size = new System.Drawing.Size(75, 25);
            this.StartPort.TabIndex = 3;
            this.StartPort.Text = "StartPort";
            this.StartPort.UseVisualStyleBackColor = true;
            this.StartPort.Click += new System.EventHandler(this.StartPort_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.On);
            this.GroupBox1.Controls.Add(this.Intensity);
            this.GroupBox1.Controls.Add(this.Off);
            this.GroupBox1.Location = new System.Drawing.Point(40, 145);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(210, 100);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Switch";
            // 
            // On
            // 
            this.On.Location = new System.Drawing.Point(20, 20);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(100, 20);
            this.On.TabIndex = 0;
            this.On.Text = "On";
            this.On.CheckedChanged += new System.EventHandler(this.On_CheckedChanged);
            // 
            // Intensity
            // 
            this.Intensity.Location = new System.Drawing.Point(80, 55);
            this.Intensity.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Intensity.Name = "Intensity";
            this.Intensity.Size = new System.Drawing.Size(120, 20);
            this.Intensity.TabIndex = 1;
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(20, 50);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(100, 20);
            this.Off.TabIndex = 1;
            this.Off.Text = "Off";
            this.Off.CheckedChanged += new System.EventHandler(this.Off_CheckedChanged);
            // 
            // ComportLabel
            // 
            this.ComportLabel.AutoSize = true;
            this.ComportLabel.Location = new System.Drawing.Point(15, 30);
            this.ComportLabel.Name = "ComportLabel";
            this.ComportLabel.Size = new System.Drawing.Size(50, 10);
            this.ComportLabel.TabIndex = 3;
            this.ComportLabel.Text = "Comport:";
            // 
            // BaudLabel
            // 
            this.BaudLabel.AutoSize = true;
            this.BaudLabel.Location = new System.Drawing.Point(10, 60);
            this.BaudLabel.Name = "BaudLabel";
            this.BaudLabel.Size = new System.Drawing.Size(50, 10);
            this.BaudLabel.TabIndex = 4;
            this.BaudLabel.Text = "Baud rate:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.ComportLabel);
            this.GroupBox2.Controls.Add(this.BaudLabel);
            this.GroupBox2.Controls.Add(this.Comport);
            this.GroupBox2.Controls.Add(this.Baudrate);
            this.GroupBox2.Location = new System.Drawing.Point(40, 15);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(210, 100);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Port Setup";
            // 
            // Comport
            // 
            this.Comport.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.Comport.Location = new System.Drawing.Point(70, 30);
            this.Comport.Name = "Comport";
            this.Comport.Size = new System.Drawing.Size(120, 20);
            this.Comport.TabIndex = 3;
            // 
            // Baudrate
            // 
            this.Baudrate.Location = new System.Drawing.Point(70, 60);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(120, 20);
            this.Baudrate.TabIndex = 3;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(40, 285);
            this.Display.Multiline = true;
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(210, 60);
            this.Display.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 360);
            this.Controls.Add(this.StartPort);
            this.Controls.Add(this.SetLight);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void SetLight_Click(object sender, EventArgs e)
        {
            Display.Text = $"Set light intensity to {Intensity.Value}";
            string respond = DControl.SetIntensity(Convert.ToInt32(Intensity.Value));
            if (respond != "OK")
            {
                Display.Text = respond;
            }
        }

        private void On_CheckedChanged(object sender, EventArgs e)
        {
            if (On.Checked)
            {
                string respond = DControl.LightOn();
                if (respond != "OK")
                {
                    Display.Text = respond;
                }
                else
                {
                    Display.Text = "Light on";
                }
            }
        }

        private void Off_CheckedChanged(object sender, EventArgs e)
        {
            if (Off.Checked)
            {
                string respond = DControl.LightOff();
                if (respond != "OK")
                {
                    Display.Text = respond;
                }
                else
                {
                    Display.Text = "Light off";
                }
            }
        }

        private void StartPort_Click(object sender, EventArgs e)
        {
            DControl.ConnectDevice(Comport.SelectedItem.ToString(), Convert.ToInt32(Baudrate.Text));
        }
    }
}