using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data
{
    class Action
    {

        public Action(string name, string tooltip, GestureSurface area)
        {
            Name = name;
            Tooltip = tooltip;
            Area = area;
        }

        public string Name { get; set; }
        public string Tooltip { get; set; }
        public GestureSurface Area { get; set; }

    }
}
