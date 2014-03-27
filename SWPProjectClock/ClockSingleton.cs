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
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        private static ClockSingleton actualClock = null;

        protected ClockSingleton()
        {
            System.Timers.Timer clockTimer = new System.Timers.Timer(1000);
            clockTimer.Elapsed += new ElapsedEventHandler(Tick);
            clockTimer.Enabled = true;

            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            second = DateTime.Now.Second;
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
            if (second >= 60)
            {
                minute += 1;
                second = 0;
            }
                
            if(minute >= 60)
            {
                minute = 0;
                hour += 1;
            }

            if (hour >= 24)
                hour = 0;

            updateObserver();
        }

        public void dec(Command cmd)
        {           
            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                    hour -= Convert.ToInt32(item.Value) % 24;
                else if (item.Key == "-m")
                    minute -= Convert.ToInt32(item.Value) % 60;
                else
                    second -= Convert.ToInt32(item.Value) % 60;
            }            
        }

        public void inc(Command cmd)
        {           
            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                    hour += Convert.ToInt32(item.Value) % 24;
                else if (item.Key == "-m")
                    minute += Convert.ToInt32(item.Value) % 60;
                else
                    second += Convert.ToInt32(item.Value) % 60;
            }            
        }

        public string set(Command cmd)
        {
            string command = "";

            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                {
                    command += " -h " + (Convert.ToInt32(item.Value) - hour).ToString();
                    hour = Convert.ToInt32(item.Value);
                }
                else if (item.Key == "-m")
                {
                    command += " -m " + (Convert.ToInt32(item.Value) - minute).ToString();
                    minute = Convert.ToInt32(item.Value);
                }
                else
                {
                    command += " -s " + (Convert.ToInt32(item.Value) - second).ToString();
                    second = Convert.ToInt32(item.Value);
                }
            }
            return "inc" + command;            
        }

        /*public void redo(Command cmd)
        {
            int index = CommandQueue.getQueue.Count, i = 1;
            Command newCmd = CommandQueue.getQueue[index - i];            

            switch (newCmd.type)
            {                    
                case "dec":
                    if (newCmd.Undo == false)
                        this.dec(newCmd);
                    else
                        this.inc(newCmd);
                    break;
                case "inc":
                    if (newCmd.Undo == false)
                        this.inc(newCmd);
                    else
                        this.dec(newCmd);
                    break;                
                default:
                    break;
            }
        }   */     
    }
}
