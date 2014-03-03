using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    class helpCommand : ICommand
    {
        public void doCommand(command cmd)
        {
            MessageBox.Show("This is the help!");
            commandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "help"; }
        }
    }
}
