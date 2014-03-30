using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class IncCommand : ICommand
    {
        ClockSingleton actual;

        public IncCommand() { actual = ClockSingleton.getClock; }

        public void doCommand(Command cmd)
        {
            actual.inc(cmd);
            CommandQueue.Instance.Add(cmd);
        }
        
        public void undoCommand(Command cmd)
        {
            actual.dec(cmd);
            /*int i = 1;

            while (CommandQueue.getQueue[CommandQueue.getQueue.Count - i].Undo == true)
            {
                i++;
            }

            switch (CommandQueue.getQueue[CommandQueue.getQueue.Count - i].type)
            {
                case "inc":
                    actual.dec(CommandQueue.getQueue[CommandQueue.getQueue.Count - i]);
                    break;
                case "dec":
                    actual.inc(CommandQueue.getQueue[CommandQueue.getQueue.Count - i]);
                    break;
                default:
                    break;
            }*/
        }
    }
}
