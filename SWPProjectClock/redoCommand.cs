using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class redoCommand : ICommand
    {
        public void doCommand(command cmd)
        {
            command newCmd = commandQueue.getQueue[commandQueue.getQueue.Count - 1];
            ICommand obj = null;

            switch (newCmd.type)
            {
                case "set":
                    obj = new setCommand();
                    break;
                case "help":
                    obj = new helpCommand();
                    break;
                case "dec":
                    obj = new decCommand();
                    break;
                case "inc":
                    obj = new incCommand();
                    break;
                case "undo":
                    obj = new undoCommand();
                    break;
                case "redo":
                    obj = new redoCommand();
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
