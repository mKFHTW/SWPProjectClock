using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    public class Invoker
    {
        Command cmd;

        public void invoke(string Line)
        {
            cmd = new Command(Line);
            ICommand obj = null;

            switch (cmd.type)
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
                    if (CommandQueue.getQueue.Count > 0)
                    {
                        int i = 1;
                        //CommandQueue.getQueue[CommandQueue.getQueue.Count - i].Undo == true
                        while (CommandQueue.getQueue.Count - i >= 0)
                        {
                            if (CommandQueue.getQueue[CommandQueue.getQueue.Count - i].Undo != true)
                            {
                                if (CommandQueue.getQueue[CommandQueue.getQueue.Count - i].type == "inc")
                                {
                                    obj = new IncCommand();
                                    break;
                                }

                                else
                                {
                                    obj = new DecCommand();
                                    break;
                                }
                            }                            
                            i++;
                        }
                        if (obj != null)
                            obj.undoCommand(CommandQueue.getQueue[CommandQueue.getQueue.Count - i]);
                        else
                            MessageBox.Show("All commands in Queue are undone !");
                    }
                    else
                        MessageBox.Show("No commans to undo !");
                    break;
                case "redo":
                    obj = new RedoCommand();
                    break;
                case "show":
                    obj = new ShowCommand();
                    break;
                default:
                    break;
            }
            if (cmd.type != "undo")            
                obj.doCommand(cmd);
        }
    }
}
