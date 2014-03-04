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
            Command newCmd = CommandQueue.getQueue[CommandQueue.getQueue.Count - 1];
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

            obj.doCommand(newCmd);
        }

        public string getCommandName
        {
            get { return "undo"; }
        }
    }
}
