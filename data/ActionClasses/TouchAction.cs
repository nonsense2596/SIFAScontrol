using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public override void KeyUpAction()
        {
            throw new NotImplementedException();
        }

        public override void StateChangedAction()
        {
            throw new NotImplementedException();
        }
    }
}
