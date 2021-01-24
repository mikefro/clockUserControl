using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockControl
{
    public class Alarm
    {
        private int _alarmHour;
        private int _alarmMinute;
        private DateTime _alarm;

        public DateTime GetAlarm()
        { return _alarm; }


        public void SetAlarm(int AlarmHour, int AlarmMinute)
        {
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, AlarmHour, AlarmMinute, 0);
            _alarm = date;
        }

        public int AlarmHour
        {
            get { return _alarmHour; }
            set { _alarmHour = value; }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set { _alarmMinute = value; }
        }
    }
}
