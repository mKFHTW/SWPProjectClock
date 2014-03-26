using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class UndoCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            int index = CommandQueue.getQueue.Count;
            for (int i = 1; i < 11; i++) // neu ungetestet !
            {
                //MessageBox.Show("Count " + CommandQueue.getQueue.Count + " i " + i + " diff " + (CommandQueue.getQueue.Count - i));
                if (index - i < 0)
                    break;

                Command newCmd = CommandQueue.getQueue[index - i];
                
                ICommand obj = null;

                switch (newCmd.type)
                {
                    case "set":
                        // Dauer zwischen vorher und gesetztem Wert relevant ?
                        obj = new SetCommand();
                        break;
                    case "help":
                        MessageBox.Show("Macht keinen Sinn");
                        break;
                    case "dec":
                        newCmd.type = "inc";
                        obj = new IncCommand();
                        break;
                    case "inc":
                        newCmd.type = "dec";
                        obj = new DecCommand();
                        break;
                    case "undo":
                        MessageBox.Show("Macht keinen Sinn");
                        break;
                    case "redo":
                        MessageBox.Show("Macht keinen Sinn");
                        break;
                    default:
                        break;
                }

                //i++;
                newCmd.Undo = true; // neu ungetestet !
                obj.doCommand(newCmd);
                //CommandQueue.getQueue.Add(newCmd); // neu ungetestet !                
            }
        }

        public string getCommandName
        {
            get { return "undo"; }
        }
    }
}
