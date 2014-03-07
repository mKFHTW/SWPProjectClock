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
    partial class ClockOne : Form
    {
        ObserverOne obj = null;

        public ClockOne(string timeZone)
        {
            InitializeComponent();

             obj = new ObserverOne();
             timerOne.Enabled = true;
        }

        public void update()
        {
            lbTime.Text = obj.hour + " : " + obj.minute + " : " + obj.second;
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {
            update();
        }

        public ClockObserver observerInstance()
        {
            return obj;
        }
    }
}
