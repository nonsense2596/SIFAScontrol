using SIFAScontrol.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.src
{
    class GamePlayer
    {
        public GamePlayer(Actions actionList)
        {
            ActionList = actionList;
        }

        public Actions ActionList { get; set; }
    }
}
