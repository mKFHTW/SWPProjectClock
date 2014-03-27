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
        ClockSingleton actual;

        public SetCommand() { actual = ClockSingleton.getClock; }

        public void doCommand(Command cmd)
        {            
            Command obj = new Command(actual.set(cmd));
            CommandQueue.getQueue.Add(obj);
        }

        public void undoCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
