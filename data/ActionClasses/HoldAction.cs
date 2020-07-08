using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.data.ActionClasses
{
    public class HoldAction: ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("hold action");
        }

        public override void KeyDownAction()
        {
            Cursor c = new Cursor(Cursor.Current.Handle);
            Random r = new Random();
            Point p = new Point(r.Next(Area.X_min, Area.X_max), r.Next(Area.Y_min, Area.Y_max));
            Cursor.Position = p;
            mouseclicker.DoMouseDown();
        }

        public override void KeyUpAction()
        {
            mouseclicker.DoMouseUp();

        }

        public override void StateChangedAction()
        {
            throw new NotImplementedException();
        }
    }
}
