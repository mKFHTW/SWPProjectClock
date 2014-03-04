using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class ClockSingleton : Clock
    {
        /*private int hour = 0;
        private int minute = 0;
        private int second = 0;*/

        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        private static ClockSingleton actualClock = null;

        protected ClockSingleton()
        { }

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


    }
}
