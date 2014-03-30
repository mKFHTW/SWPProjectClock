using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class MacroComamnd : ICommand
    {
        int startIndex, endIndex;
        string name;

        public MacroComamnd()
        {
            startIndex = CommandQueue.Instance.Count;
        }

        public void doCommand(Command cmd)
        {
            switch (cmd.type)
            {                
                case "end":
                    endIndex = CommandQueue.Instance.Count;
                    cmd.parameter.TryGetValue("-n", out name);
                    Macros.Instance.Add(name, startIndex.ToString() + "-" + endIndex.ToString());
                    break;
                case "do":
                    string value;
                    string[] indexes; 
                    cmd.parameter.TryGetValue("-n", out name);
                    Macros.Instance.TryGetValue(name, out value);
                    indexes = value.Split('-');                    

                    for (int i = Convert.ToInt32(indexes[0]); i < Convert.ToInt32(indexes[1]); i++)
                    {
                        Invoker obj = new Invoker(CommandQueue.Instance[i]);
                        obj.invoke("");
                    }
                    break;
                default:
                    break;
            }
        }

        public void undoCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
