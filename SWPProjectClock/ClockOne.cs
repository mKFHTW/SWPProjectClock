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
        int additional;
        int x = 0;
        int y = 0; 

        public ClockOne(int timeZone, int xPos, int yPos)
        {
            InitializeComponent();

            obj = new ObserverOne();
            timerOne.Enabled = true;
            additional = timeZone;
            x = xPos;
            y = yPos;
            
        }

        public void update()
        {
            lbTime.Text = (obj.hour + additional) + " : " + obj.minute + " : " + obj.second;
        }

        private void timerOne_Tick(object sender, EventArgs e)
        {
            update();
        }

        public ClockObserver observerInstance()
        {
            return obj;
        }

        private void ClockOne_Load(object sender, EventArgs e)
        {
            this.Top = x;
            this.Left = y;
           
        }
    }
}
