using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    class Macros
    {
        public static Dictionary<string, string> obj;             
    
        protected Macros()
        { }

        public static Dictionary<string, string> Instance
        {
            get
            {
                if (obj == null)
                    return obj = new Dictionary<string,string>();
                else
                    return obj;
            }
        }
    }
}
