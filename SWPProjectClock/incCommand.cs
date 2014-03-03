using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class incCommand : ICommand
    {
        public void doCommand(command cmd)
        {
            ClockSingleton actual = ClockSingleton.getClock;

            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                    actual.hour += Convert.ToInt32(item.Value);
                else if (item.Key == "-m")
                    actual.minute += Convert.ToInt32(item.Value);
                else
                    actual.second += Convert.ToInt32(item.Value);
            }
            commandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "inc"; }
        }
    }
}
