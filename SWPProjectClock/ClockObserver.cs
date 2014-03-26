using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    public class ClockObserver
    {
        protected ClockSingleton actual = null;

        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        public ClockObserver()
        {
            actual = ClockSingleton.getClock;
        }

        ~ClockObserver()
        {
            actual.logoffObserver(this);
        }

        public void getActualTime()
        {
            hour = actual.hour;
            minute = actual.minute;
            second = actual.second;
        }
    }
}
