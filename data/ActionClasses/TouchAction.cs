using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.data.ActionClasses
{
    public class TouchAction: ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("touch action");
            Console.WriteLine(Area.height + " " + Area.width);
        }

        public override void KeyDownAction()
        {
            Cursor c = new Cursor(Cursor.Current.Handle);
            Random r = new Random();
            Point p = new Point(r.Next(Area.X_min,Area.X_max),r.Next(Area.Y_min,Area.Y_max));
            Cursor.Position = p;
            mouseclicker.DoMouseDown();
            mouseclicker.DoMouseUp();
        }

        public override void KeyUpAction()
        {
            // void
        }

        public override void StateChangedAction()
        {
            // do nothing
        }
    }
}
