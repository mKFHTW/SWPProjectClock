using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class ShowCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            //CommandQueue.getQueue.Add(cmd);
            ClockSingleton actual = ClockSingleton.getClock;

            foreach (var item in cmd.parameter)
            {
                if (item.Key == "-t" && item.Value == "1")
                {
                    ClockOne obj = new ClockOne(timeZone(cmd), posX(cmd), posY(cmd));
                    actual.loginObserver(obj.observerInstance());
                  //  obj.DesktopLocation = new Point(posX(cmd), posY(cmd));
                    obj.Show();
                    
                }

                if (item.Key == "-t" && item.Value == "2")
                {
                    ClockTwo obj = new ClockTwo(timeZone(cmd), posX(cmd), posY(cmd));
                    actual.loginObserver(obj.observerInstance());
                    obj.Show();
                }                
            }
        }

        private int timeZone(Command cmd)
        {
            //CommandQueue.getQueue.Add(cmd);
            ClockSingleton actual = ClockSingleton.getClock;
            int timeZone = 0;

            foreach (var item in cmd.parameter)
            {
                if (item.Key == "-z")
                {
                     timeZone = Convert.ToInt32(item.Value);
                }                
            }
            return timeZone;
        }

        private int posX(Command cmd)
        {
            //CommandQueue.getQueue.Add(cmd);

            int x = 0;

            foreach (var item in cmd.parameter)
            {
                if (item.Key == "-x")
                {
                   x = Convert.ToInt32(item.Value);
                }
            }
            return x;
        }

        private int posY(Command cmd)
        {
            //CommandQueue.getQueue.Add(cmd);

            int y = 0;

            foreach (var item in cmd.parameter)
            {
                if (item.Key == "-y")
                {
                    y = Convert.ToInt32(item.Value);
                }
            }
            return y;
        }

        public void undoCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
