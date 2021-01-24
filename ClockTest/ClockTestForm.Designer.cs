
namespace ClockTest
{
    partial class ClockTestForm
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
            this.digitalClock1 = new ClockControl.DigitalClock();
            this.SuspendLayout();
            // 
            // digitalClock1
            // 
            this.digitalClock1.Format24Hours = false;
            this.digitalClock1.Location = new System.Drawing.Point(34, 12);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(537, 248);
            this.digitalClock1.TabIndex = 0;
            this.digitalClock1.AlarmActivated += new System.EventHandler(this.digitalClock1_AlarmActivated);
            this.digitalClock1.Load += new System.EventHandler(this.digitalClock1_Load);
            // 
            // ClockTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digitalClock1);
            this.Name = "ClockTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClockControl.DigitalClock digitalClock1;

        
    }
}

