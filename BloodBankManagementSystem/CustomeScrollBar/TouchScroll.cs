using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    class TouchScroll
    {
        private Point mouseDownPoint;
        private FlowLayoutPanel parentPanel;
        public TouchScroll(FlowLayoutPanel panel)
        {
            parentPanel = panel;
        }

        private void AssignEvent(Control control)
        {
            control.MouseDown += MouseDown;
            control.MouseMove += MouseMove;

            foreach (Control  child in control.Controls)
            {
                AssignEvent(child);
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            Point pointDifference = new Point(Cursor.Position.X + mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y);


            if ((mouseDownPoint.X == Cursor.Position.X) && (mouseDownPoint.Y == Cursor.Position.Y))
            {
                return;
            }

            Point currAutoS = parentPanel.AutoScrollPosition;
            parentPanel.AutoScrollPosition = new Point(Math.Abs(currAutoS.X) - pointDifference.X, Math.Abs(currAutoS.Y) - pointDifference.Y);
            mouseDownPoint = Cursor.Position;

        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mouseDownPoint = Cursor.Position;
            }
        }
    }
}
