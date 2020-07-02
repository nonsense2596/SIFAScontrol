using SIFAScontrol.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XInputDotNetPure;

namespace SIFAScontrol.src
{
    class GamePlayer
    {
        public Actions actions { get; set; }

        private ReporterState reporterState = new ReporterState();

        public GamePlayer(Actions actions)
        {
            this.actions = actions;


            Thread t = new Thread(DoWork);
            t.Start();
        }

        bool areleased = true;

        public void DoWork()
        {
            while (true)
            {
                if (reporterState.Poll())
                {
                    if(reporterState.LastActiveState.Buttons.A == XInputDotNetPure.ButtonState.Pressed)
                    {
                        //Console.WriteLine("faszomA");
                        if (areleased)
                        {
                            Console.WriteLine("AaAaAaA");
                            areleased = false;
                        }

                    }
                    if(reporterState.LastActiveState.Buttons.A == XInputDotNetPure.ButtonState.Released)
                    {
                        areleased = true;
                    }
                }
            }
        }



    }
}
