using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    public class Command : ICloneable
    {
        public string type { get; set; }
        public Dictionary<string, string> parameter = new Dictionary<string,string>();
        bool undo = false;

        public bool Undo { get { return undo; } set { undo = value; } }

        public Command(string commandLine)
        {
            string[] splitted = commandLine.Split();

            type = splitted[0];

            for (int i = 1; i < splitted.Length; i+=2)
            {
                try { parameter.Add(splitted[i], splitted[i + 1]); }
                catch { }
            }
            /*foreach (var item in parameter)
            {
                MessageBox.Show(item.Key + " " + item.Value);   
            }*/
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
