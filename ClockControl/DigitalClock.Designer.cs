
namespace ClockControl
{
    partial class DigitalClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockGroupBox = new System.Windows.Forms.GroupBox();
            this.alarmGroupBox = new System.Windows.Forms.GroupBox();
            this.alarmStatusLabel = new System.Windows.Forms.Label();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.hourLabel = new System.Windows.Forms.Label();
            this.alarmStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.format12HRadioButton = new System.Windows.Forms.RadioButton();
            this.formart24HRadioButton = new System.Windows.Forms.RadioButton();
            this.clockGroupBox.SuspendLayout();
            this.alarmGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.BackColor = System.Drawing.Color.Black;
            this.clockLabel.Font = new System.Drawing.Font("ROG Fonts", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.Lime;
            this.clockLabel.Location = new System.Drawing.Point(18, 64);
            this.clockLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(185, 44);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "label1";
            // 
            // clockGroupBox
            // 
            this.clockGroupBox.Controls.Add(this.alarmGroupBox);
            this.clockGroupBox.Controls.Add(this.clockLabel);
            this.clockGroupBox.Location = new System.Drawing.Point(9, 13);
            this.clockGroupBox.Name = "clockGroupBox";
            this.clockGroupBox.Size = new System.Drawing.Size(503, 211);
            this.clockGroupBox.TabIndex = 4;
            this.clockGroupBox.TabStop = false;
            this.clockGroupBox.Text = "Clock";
            // 
            // alarmGroupBox
            // 
            this.alarmGroupBox.Controls.Add(this.formart24HRadioButton);
            this.alarmGroupBox.Controls.Add(this.format12HRadioButton);
            this.alarmGroupBox.Controls.Add(this.alarmStatusLabel);
            this.alarmGroupBox.Controls.Add(this.minuteNumericUpDown);
            this.alarmGroupBox.Controls.Add(this.hourNumericUpDown);
            this.alarmGroupBox.Controls.Add(this.label1);
            this.alarmGroupBox.Controls.Add(this.hourLabel);
            this.alarmGroupBox.Controls.Add(this.alarmStatusCheckBox);
            this.alarmGroupBox.Location = new System.Drawing.Point(274, 19);
            this.alarmGroupBox.Name = "alarmGroupBox";
            this.alarmGroupBox.Size = new System.Drawing.Size(200, 186);
            this.alarmGroupBox.TabIndex = 0;
            this.alarmGroupBox.TabStop = false;
            this.alarmGroupBox.Text = "Set Alarm";
            // 
            // alarmStatusLabel
            // 
            this.alarmStatusLabel.AutoSize = true;
            this.alarmStatusLabel.Location = new System.Drawing.Point(12, 151);
            this.alarmStatusLabel.Name = "alarmStatusLabel";
            this.alarmStatusLabel.Size = new System.Drawing.Size(80, 13);
            this.alarmStatusLabel.TabIndex = 7;
            this.alarmStatusLabel.Text = "Alarm activated";
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(106, 69);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.minuteNumericUpDown.TabIndex = 6;
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(106, 36);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(63, 20);
            this.hourNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minute";
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(12, 36);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(30, 13);
            this.hourLabel.TabIndex = 3;
            this.hourLabel.Text = "Hour";
            // 
            // alarmStatusCheckBox
            // 
            this.alarmStatusCheckBox.AutoSize = true;
            this.alarmStatusCheckBox.Location = new System.Drawing.Point(131, 151);
            this.alarmStatusCheckBox.Name = "alarmStatusCheckBox";
            this.alarmStatusCheckBox.Size = new System.Drawing.Size(15, 14);
            this.alarmStatusCheckBox.TabIndex = 2;
            this.alarmStatusCheckBox.UseVisualStyleBackColor = true;
            this.alarmStatusCheckBox.CheckedChanged += new System.EventHandler(this.alarmStatusCheckBox_CheckedChanged);
            // 
            // format12HRadioButton
            // 
            this.format12HRadioButton.AutoSize = true;
            this.format12HRadioButton.Checked = true;
            this.format12HRadioButton.Location = new System.Drawing.Point(15, 116);
            this.format12HRadioButton.Name = "format12HRadioButton";
            this.format12HRadioButton.Size = new System.Drawing.Size(68, 17);
            this.format12HRadioButton.TabIndex = 8;
            this.format12HRadioButton.TabStop = true;
            this.format12HRadioButton.Text = "12 Hours";
            this.format12HRadioButton.UseVisualStyleBackColor = true;
            // 
            // formart24HRadioButton
            // 
            this.formart24HRadioButton.AutoSize = true;
            this.formart24HRadioButton.Location = new System.Drawing.Point(106, 116);
            this.formart24HRadioButton.Name = "formart24HRadioButton";
            this.formart24HRadioButton.Size = new System.Drawing.Size(68, 17);
            this.formart24HRadioButton.TabIndex = 9;
            this.formart24HRadioButton.TabStop = true;
            this.formart24HRadioButton.Text = "24 Hours";
            this.formart24HRadioButton.UseVisualStyleBackColor = true;
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockGroupBox);
            this.Name = "DigitalClock";
            this.Size = new System.Drawing.Size(515, 241);
            this.Load += new System.EventHandler(this.DigitalClock_Load);
            this.clockGroupBox.ResumeLayout(false);
            this.clockGroupBox.PerformLayout();
            this.alarmGroupBox.ResumeLayout(false);
            this.alarmGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.GroupBox clockGroupBox;
        private System.Windows.Forms.GroupBox alarmGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.CheckBox alarmStatusCheckBox;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.Label alarmStatusLabel;
        private System.Windows.Forms.RadioButton formart24HRadioButton;
        private System.Windows.Forms.RadioButton format12HRadioButton;
    }
}
