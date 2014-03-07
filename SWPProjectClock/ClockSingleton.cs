using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace SWPProjectClock
{
    public class ClockSingleton : Clock
    {
        /*private int hour = 0;
        private int minute = 0;
        private int second = 0;*/

        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        private static ClockSingleton actualClock = null;

        protected ClockSingleton()
        {
            System.Timers.Timer clockTimer = new System.Timers.Timer(1000);
            clockTimer.Elapsed += new ElapsedEventHandler(Tick);
            clockTimer.Enabled = true;
        }

        public static ClockSingleton getClock
        {
            get
            {
                if (actualClock == null)
                    return actualClock = new ClockSingleton();
                else
                    return actualClock;
            }


        }

        private void Tick(object source, ElapsedEventArgs e)
        {
            second += 1;
            if (second == 60)
            {
                minute += 1;
                second = 0;
            }
                
            if(minute == 60)
            {
                minute = 0;
                hour += 1;
            }

            if (hour == 24)
                hour = 0;

            updateObserver();
        }
    }
}
