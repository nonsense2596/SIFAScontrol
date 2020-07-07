using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data.ActionClasses
{
    public class HoldAction: ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("hold action");
        }
    }
}
