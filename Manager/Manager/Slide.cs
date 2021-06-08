using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Manager
{
    static class Slide
    {
        static Control Control = null;

        public delegate void Callback(string ControlName);
        private static Callback CalBck;

        public static bool Show(Control Cntrl, Callback callback)
        {
            if (Control != null)
                return false;

            Control = Cntrl;
            CalBck = callback;

            Timer timer = new Timer();
            timer.Tick += new EventHandler(SlideIn);
            timer.Interval = 1;
            timer.Start();

            Control.BringToFront();
            Control.Focus();

            return true;
        }

        public static bool Hide(Control Cntrl)
        {
            if (Control != null)
                return false;

            Control = Cntrl;

            Timer timer = new Timer();
            timer.Tick += new EventHandler(SlideOut);
            timer.Interval = 1;
            timer.Start();

            return true;
        }

        private static void SlideIn(object sender, EventArgs e)
        {
            if (Control.Left == 0)
            {
                (sender as Timer).Stop();
                if (CalBck != null) CalBck(Control.Name);
                Control = null;
            }
            else
                Control.Left -= Control.Left > -20 ? Control.Left : -20;
        }

        private static void SlideOut(object sender, EventArgs e)
        {
            if (Control.Right <= 0)
            {
                (sender as Timer).Stop();
                Control.Left = -1 * Control.Width;
                Control = null;
            }
            else
                Control.Left -= 20;
        }
    }
}
