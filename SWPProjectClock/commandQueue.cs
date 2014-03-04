using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    public class CommandQueue
    {        
        // Singleton oder jeweils immer die Queue als Receiver fürs Command Pattern?
        //public List<command> commandQueue { get; set; }

        private static List<Command> obj = null;
            
        protected CommandQueue()
        { }

        public static List<Command> getQueue { 
            get
            {
            if (obj == null)
                return obj = new List<Command>();
            else
                return obj;
            }    
        }
    }
}
