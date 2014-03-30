using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class DecCommand : ICommand
    {
        ClockSingleton actual;

        public DecCommand() { actual = ClockSingleton.getClock; }

        public void doCommand(Command cmd)
        {         
            actual.dec(cmd);
            CommandQueue.Instance.Add(cmd);
        }

        public void undoCommand(Command cmd)
        {
            actual.inc(cmd);
        }
    }
}
