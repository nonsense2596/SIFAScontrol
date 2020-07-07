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

        public GestureSurface Area { get; set; }
    }
}
