﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFAScontrol.data.ActionClasses
{
    public class MoveAction: ActionBase
    {
        public override void Action()
        {
            Console.WriteLine("move action");
        }
    }
}