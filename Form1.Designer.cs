using System.Drawing;
using System.Windows.Forms;

namespace VLP_2410_UI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button SetLight;
        private NumericUpDown Intensity;
        private RadioButton On;
        private RadioButton Off;
        private GroupBox GroupBox1;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SetLight = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.On = new System.Windows.Forms.RadioButton();
            this.Intensity = new System.Windows.Forms.NumericUpDown();
            this.Off = new System.Windows.Forms.RadioButton();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).BeginInit();
            this.SuspendLayout();
            // 
            // SetLight
            // 
            this.SetLight.Location = new System.Drawing.Point(165, 115);
            this.SetLight.Name = "SetLight";
            this.SetLight.Size = new System.Drawing.Size(75, 20);
            this.SetLight.TabIndex = 0;
            this.SetLight.Text = "SetLight";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.On);
            this.GroupBox1.Controls.Add(this.Intensity);
            this.GroupBox1.Controls.Add(this.Off);
            this.GroupBox1.Location = new System.Drawing.Point(40, 10);
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.SetLight);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Intensity)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}

