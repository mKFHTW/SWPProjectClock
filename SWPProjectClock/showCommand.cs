using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class ShowCommand : ICommand
    {
        public void doCommand(Command cmd)
        {
            CommandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "show"; }
        }
    }
}
