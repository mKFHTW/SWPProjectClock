namespace SWPProjectClock
{
    partial class ClockTwo
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
            this.timerTwo = new System.Windows.Forms.Timer(this.components);
            this.clockControl1 = new SWPProjectClock.ClockControl();
            this.SuspendLayout();
            // 
            // timerTwo
            // 
            this.timerTwo.Enabled = true;
            this.timerTwo.Tick += new System.EventHandler(this.timerTwo_Tick);
            // 
            // clockControl1
            // 
            this.clockControl1.hour = 0;
            this.clockControl1.Location = new System.Drawing.Point(4, 3);
            this.clockControl1.minute = 0;
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.second = 0;
            this.clockControl1.ShowHourHand = true;
            this.clockControl1.ShowMajorSegments = true;
            this.clockControl1.ShowMinorSegments = true;
            this.clockControl1.ShowMinuteHand = true;
            this.clockControl1.ShowSecondhand = true;
            this.clockControl1.Size = new System.Drawing.Size(150, 150);
            this.clockControl1.TabIndex = 0;
            // 
            // ClockTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 178);
            this.Controls.Add(this.clockControl1);
            this.Name = "ClockTwo";
            this.Text = "ClockTwo";
            this.Load += new System.EventHandler(this.ClockTwo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ClockControl clockControl1;
        private System.Windows.Forms.Timer timerTwo;
    }
}