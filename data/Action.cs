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

        public Action(KeyCode kc, string name, string tooltip, GestureSurface area)
        {
            KeyCode = kc;
            Name = name;
            Tooltip = tooltip;
            Area = area;
        }
        public KeyCode KeyCode { get; set; }
        public string Name { get; set; }
        public string Tooltip { get; set; }
        public GestureSurface Area { get; set; }
        public void DownAction()
        {

        }
        public void UpAction()
        {

        }
    }
}
