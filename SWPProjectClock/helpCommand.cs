using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class HelpCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            MessageBox.Show("This is the help!");
            CommandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "help"; }
        }
    }
}
