using SIFAScontrol.data.ActionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SIFAScontrol.Abstraction.KeyEventArgs;

namespace SIFAScontrol.data
{
    public class Action
    {
        // TODO based on Action they all shall
        // implementing DownAction and UpAction, to

        public Action(KeyCode kc, string name, string tooltip, GestureSurface area, ActionBase concreteaction)
        {
            KeyCode = kc;
            Name = name;
            Tooltip = tooltip;
            Area = area;
            ConcreteAction = concreteaction;
        }
        public KeyCode KeyCode { get; set; }
        public string Name { get; set; }
        public string Tooltip { get; set; }
        public GestureSurface Area { get; set; }
        public ActionBase ConcreteAction { get; set; }
    }
}
