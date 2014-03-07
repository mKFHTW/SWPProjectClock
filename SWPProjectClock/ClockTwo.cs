using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWPProjectClock
{
    public partial class ClockTwo : Form
    {
        ObserverTwo obj = null;

        public ClockTwo(string timeZone)
        {
            InitializeComponent();

             obj = new ObserverTwo();
             timerTwo.Enabled = true;
        }

        public void update()
        {            
            clockControl1.hour = obj.hour;
            clockControl1.minute = obj.minute;
            clockControl1.second = obj.second;
            clockControl1.Refresh();
        }

        private void timerTwo_Tick(object sender, EventArgs e)
        {
            update();
        }

        public ClockObserver observerInstance()
        {
            return obj;
        }
    }
}
