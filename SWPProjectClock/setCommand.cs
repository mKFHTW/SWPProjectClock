using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SWPProjectClock
{
    class SetCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            ClockSingleton actual = ClockSingleton.getClock;
            string command = "";
                        
            foreach (KeyValuePair<string, string> item in cmd.parameter)
            {
                if (item.Key == "-h")
                {
                    command += " -h " + (Convert.ToInt32(item.Value) - actual.hour).ToString();    
                    actual.hour = Convert.ToInt32(item.Value);                   
                }
                else if (item.Key == "-m")
                {
                    command += " -m " + (Convert.ToInt32(item.Value) - actual.minute).ToString();
                    actual.minute = Convert.ToInt32(item.Value);
                }
                else
                {
                    command += " -s " + (Convert.ToInt32(item.Value) - actual.second).ToString();
                    actual.second = Convert.ToInt32(item.Value);
                }
            }
            Command obj = new Command("inc" + command);
            CommandQueue.getQueue.Add(obj);
        }

        public string getCommandName
        {
            get { return "set"; }
        }
    }
}
