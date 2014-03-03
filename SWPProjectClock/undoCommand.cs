using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class undoCommand : ICommand
    {
        public void doCommand(command cmd)
        {
            command newCmd = commandQueue.getQueue[commandQueue.getQueue.Count - 1];
            ICommand obj = null;

            switch (newCmd.type)
            {
                case "set":
                    // Dauer zwischen vorher und gesetztem Wert relevant ?
                    obj = new setCommand();
                    break;
                case "help":
                    MessageBox.Show("Macht keinen Sinn");
                    break;
                case "dec":
                    newCmd.type = "inc";
                    obj = new incCommand();
                    break;
                case "inc":
                    newCmd.type = "dec";
                    obj = new decCommand();
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
