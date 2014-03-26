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
        public void doCommand(Command cmd)
        {
            int index = CommandQueue.getQueue.Count, i = 1;

            do
            {
                Command newCmd = CommandQueue.getQueue[index - i];
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
                        if (newCmd.Undo == false)
                            obj = new DecCommand();
                        else
                            obj = new IncCommand();
                        break;
                    case "inc":
                        if (newCmd.Undo == false)
                            obj = new IncCommand();
                        else
                            obj = new DecCommand();
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
                i++;
            } while ((index - i) > 1 && CommandQueue.getQueue[index - i].Undo != false);
        }
        

        public string getCommandName
        {
            get { return "redo"; }
        }
    }
}
