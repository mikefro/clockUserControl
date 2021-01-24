using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClockControl
{
    public partial class DigitalClock : UserControl
    {

        private bool _format24Hours;

        Alarm alarm = new Alarm();

        [Category("Format24Hours")]
        [Description("For 12hours Format Time as False\nFor 24hours Format Time as True")]
        /// <summary>
        /// Choose between 12 or 24 Hours Time Format
        /// </summary>
        public bool Format24Hours
        {
            get { return _format24Hours; }
            set { _format24Hours = value; }
        }

        public event EventHandler AlarmActivated;


        public DigitalClock()
        {
            InitializeComponent();
        }

        //public void Posponer(EventArgs e)
        //{
        //    if (MessageBox.Show("Postpone alarm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        var newMinute =  alarm.AlarmMinute + 1;
        //        Alarm postAlarm = new Alarm();
        //        postAlarm.AlarmMinute += newMinute;
              
        //        // user clicked yes
        //        ComparingTimes(DateTime.Now, postAlarm.GetAlarm(),e);
        //    }
        //    else
        //    {
        //        // user clicked no
        //    }
        //}

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void ComparingTimes(DateTime now, DateTime alarm,EventArgs e)

        {
            if (now.Hour == alarm.Hour && now.Minute == alarm.Minute)
            
                AlarmActivated?.Invoke(this, e);
            
        }

        public void clockTimer_Tick(object sender, EventArgs e)
        {
            checkFormatHours();
            clockLabel.Text = Format24Hours ? DateTime.Now.ToString("HH:mm:ss") : DateTime.Now.ToString("hh:mm:ss");

            DateTime currentAlarm = alarm.GetAlarm();
            DateTime currentTime = DateTime.Now;

            ComparingTimes(currentTime, currentAlarm,e);
                
            
        }

        //Check the choosen format clock
        private void checkFormatHours()
        {
            if (format12HRadioButton.Checked) Format24Hours = false;
            else
                Format24Hours = true;
        }

        //Set the hour and minute alarm
        private void alarmStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alarmStatusCheckBox.Checked)
                alarm.SetAlarm((int)hourNumericUpDown.Value, (int)minuteNumericUpDown.Value);
        }



    }
}
