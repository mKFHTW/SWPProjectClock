using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class RedoCommand : ICommand
    {
        ClockSingleton actual;

        public RedoCommand() { actual = ClockSingleton.getClock; }

        public void doCommand(Command cmd)
        {
            int index = CommandQueue.getQueue.Count, i = 1;
            Command newCmd = CommandQueue.getQueue[index - i];

            switch (newCmd.type)
            {
                case "dec":
                    if (newCmd.Undo == false)
                        actual.dec(newCmd);
                    else
                        actual.inc(newCmd);
                    break;
                case "inc":
                    if (newCmd.Undo == false)
                        actual.inc(newCmd);
                    else
                        actual.dec(newCmd);
                    break;
                default:
                    break;
            }            

            Command obj = (Command)CommandQueue.getQueue[CommandQueue.getQueue.Count - 1].Clone();

            if (obj.Undo == true)
            {
                if (obj.type == "inc")
                    obj.type = "dec";
                else
                    obj.type = "inc";
            }

            CommandQueue.getQueue.Add(obj);
        }

        public void undoCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
