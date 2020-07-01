using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data
{
    public class Action
    {

        public Action(string name, string tooltip, GestureSurface area)
        {
            Name = name;
            Tooltip = tooltip;
            Area = area;
        }
        /*public Action(string name, string tooltip)
        {
            Name = name;
            Tooltip = tooltip;
        }*/

        public string Name { get; set; }
        public string Tooltip { get; set; }
        public GestureSurface Area { get; set; }

    }
}
