using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class RedoCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            Command newCmd = CommandQueue.getQueue[CommandQueue.getQueue.Count - 1];
            ICommand obj = null;

            switch (newCmd.type)
            {
                case "set":
                    obj = new SetCommand();
                    break;
                case "help":
                    obj = new HelpCommand();
                    break;
                case "dec":
                    obj = new DecCommand();
                    break;
                case "inc":
                    obj = new IncCommand();
                    break;
                case "undo":
                    obj = new UndoCommand();
                    break;
                case "redo":
                    obj = new RedoCommand();
                    break;
                default:
                    break;
            }

            obj.doCommand(newCmd);
        }

        public string getCommandName
        {
            get { return "redo"; }
        }
    }
}
