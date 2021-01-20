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
        private int _alarmHour;
        private int _alarmMinute;

        public bool Format24Hours
        {
            get { return _format24Hours; }
            set { _format24Hours = value; }
        }

        public event EventHandler AlarmActivated;

        private DateTime _alarm;

        public DateTime Alarm
        {
            get { return _alarm; }
            private set
            {
                var dateNow = DateTime.Now;
                var date = new DateTime(0, dateNow.Month, dateNow.Day, AlarmHour, AlarmMinute, 0);
                _alarm = date;
            }
        }

        public int AlarmHour
        {
            get { return _alarmHour; }
            set { _alarmHour = value;}
        }
         
        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set { _alarmMinute = value;}
        }


        public DigitalClock()
        {
            InitializeComponent();
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        public void clockTimer_Tick(object sender, EventArgs e)
        {
            checkFormatHours();
            clockLabel.Text = Format24Hours? DateTime.Now.ToString("HH:mm:ss") : DateTime.Now.ToString("hh:mm:ss");
            var dateNow = DateTime.Now;
            var date = new DateTime(0, dateNow.Month, dateNow.Day, AlarmHour, AlarmMinute, 0);
            _alarm = date;

            DateTime currentTime = DateTime.Now;
            if (Alarm.Hour == currentTime.Hour && Alarm.Minute == currentTime.Minute)
            {
                AlarmActivated?.Invoke(this, e);
            }
        }

        //Check the choosen format clock
        private void checkFormatHours()
        {
            Format24Hours = formart24HRadioButton.Checked ? true : false;
        }

        private void alarmStatusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alarmStatusCheckBox.Checked)
            {
                AlarmHour = (int)hourNumericUpDown.Value;
                AlarmMinute = (int)minuteNumericUpDown.Value;
            }
        }

    }
}
