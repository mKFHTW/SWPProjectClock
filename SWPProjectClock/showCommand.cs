using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class ShowCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            CommandQueue.getQueue.Add(cmd);
            ClockSingleton actual = ClockSingleton.getClock;

            foreach (var item in cmd.parameter)
            {
                if (item.Key == "-t" && item.Value == "1")
                {
                    ClockOne obj = new ClockOne("test");
                    actual.loginObserver(obj.observerInstance());
                    obj.Show();
                }

                if (item.Key == "-t" && item.Value == "2")
                {
                    ClockTwo obj = new ClockTwo("test");
                    actual.loginObserver(obj.observerInstance());
                    obj.Show();
                }
            }
        }

        public string getCommandName
        {
            get { return "show"; }
        }
    }
}
