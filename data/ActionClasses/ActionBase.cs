using SIFAScontrol.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data.ActionClasses
{
    public abstract class ActionBase
    {
        public abstract void Action();
        public abstract void StateChangedAction();
        public abstract void KeyDownAction();
        public abstract void KeyUpAction();

        public GestureSurface Area { get; set; }
        protected MouseClicker mouseclicker = new MouseClicker();
    }
}
