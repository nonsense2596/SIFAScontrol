using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data
{
    class Actions
    {
        public Actions(Action previousFormation, Action nextFormation, Action pause, Action leftTouch, Action rightTouch)
        {
            PreviousFormation = previousFormation;
            NextFormation = nextFormation;
            Pause = pause;
            LeftTouch = leftTouch;
            RightTouch = rightTouch;
        }

        public Action PreviousFormation { get; set; }
        public Action NextFormation { get; set; }
        public Action Pause { get; set; }
        public Action LeftTouch { get; set; }
        public Action RightTouch { get; set; }
    }
}
