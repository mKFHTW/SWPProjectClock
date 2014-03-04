using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWPProjectClock
{
    public class Command
    {
        public string type { get; set; }
        public Dictionary<string, string> parameter { get; set; }        

        public Command(string commandLine)
        {
            string[] splitted = commandLine.Split();

            type = splitted[0];

            for (int i = 1; i < splitted.Length; i+=2)            
                parameter.Add(splitted[i], splitted[i + 1]);           
        }


    }
}
