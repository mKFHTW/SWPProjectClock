using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class IncCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            ClockSingleton actual = ClockSingleton.getClock;            

            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                    actual.hour += Convert.ToInt32(item.Value) % 24;
                else if (item.Key == "-m")
                    actual.minute += Convert.ToInt32(item.Value) % 60;
                else
                    actual.second += Convert.ToInt32(item.Value) % 60;
            }
            CommandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "inc"; }
        }
    }
}
