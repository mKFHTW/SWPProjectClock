using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    public class commandQueue
    {        
        // Singleton oder jeweils immer die Queue als Receiver fürs Command Pattern?
        //public List<command> commandQueue { get; set; }

        private static List<command> obj = null;
            
        protected commandQueue()
        { }

        public static List<command> getQueue { 
            get
            {
            if (obj == null)
                return obj = new List<command>();
            else
                return obj;
            }    
        }
    }
}
