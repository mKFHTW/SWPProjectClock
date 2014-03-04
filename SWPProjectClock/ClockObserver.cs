using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    abstract class ClockObserver
    {
        protected ClockSingleton actual = null;

        protected int hour;
        protected int minute;
        protected int second;

        public ClockObserver()
        {
            actual = ClockSingleton.getClock;
        }

        abstract public void getActualTime();
    }
}
