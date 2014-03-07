using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    public class Clock
    {
        List<ClockObserver> observer = new List<ClockObserver>();

        public void loginObserver(ClockObserver obj)
        {
            observer.Add(obj);
        }

        public void logoffObserver(ClockObserver obj)
        {
            observer.Remove(obj);
        }

        public void updateObserver()
        {
            foreach (ClockObserver item in observer)
            {
                item.getActualTime();
            }
        }
    }
}
