using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class ObserverOne : ClockObserver
    {
        public override void getActualTime()
        {
            hour = actual.hour;
            minute = actual.minute;
            second = actual.second;
        }
    }
}
