using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    interface ICommand
    {
        string getCommandName { get; }
        void doCommand(command cmd);
    }
}
