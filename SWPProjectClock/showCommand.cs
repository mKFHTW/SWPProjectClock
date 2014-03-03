using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class showCommand : ICommand
    {
        public void doCommand(command cmd)
        {
            commandQueue.getQueue.Add(cmd);
        }

        public string getCommandName
        {
            get { return "show"; }
        }
    }
}
