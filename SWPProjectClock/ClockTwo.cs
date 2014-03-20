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
        int additional;
        int x = 0;
        int y = 0;

        public ClockTwo(int timeZone, int xPos, int yPos)
        {
            InitializeComponent();

            obj = new ObserverTwo();
            timerTwo.Enabled = true;
            additional = timeZone;
            x = xPos;
            y = yPos; ;
        }

        public void update()
        {
            clockControl1.hour = obj.hour + additional;
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

        private void ClockTwo_Load(object sender, EventArgs e)
        {
            this.Top = x;
            this.Left = y;
        }
    }
}
