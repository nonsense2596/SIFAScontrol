using SIFAScontrol.Abstraction;
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

        private ReporterState reporterState; // = new ReporterState();

        private List<Gamepad> gamepadlist; //= Gamepad.GetConnectedDevices

        private Gamepad gamepad;

        MouseClicker mouseclicker; 

        public GamePlayer(Actions actions)
        {
            this.actions = actions;
            reporterState = new ReporterState();
            mouseclicker = new MouseClicker();

            gamepadlist = Gamepad.GetConnectedDevices();

            if (gamepadlist.Count > 0)
            {
                gamepad = gamepadlist.First();
                gamepad.StateChanged += Pad_StateChanged;
                gamepad.KeyUp += Pad_KeyUp;
                gamepad.KeyDown += Pad_KeyDown;
            }

            //Thread t = new Thread(DoWork);
            //t.Start();
        }

        bool areleased = true;

        public void DoWork()
        {

            //var pads = Gamepad.GetConnectedDevices();
            //if (pads.Count > 0)
            //{
            //    Gamepad pad = pads.First();
            //    pad.StateChanged += Pad_StateChanged;
            //    pad.KeyUp += Pad_KeyUp;
            //    pad.KeyDown += Pad_KeyDown;
            //}

        }
        private  void Pad_StateChanged(object sender, EventArgs args)
        {
        }
        private  void Pad_KeyDown(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.5, 0.5);

            for(int i = 0; i < actions.ialSize(); i++)
            {
                if (actions[i].KeyCode.Equals(args.Key)){
                    // do stuff
                    Console.WriteLine(actions[i].Name);
                }
            }


        }
        private void Pad_KeyUp(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.0, 0.0);


        }



    }
}


/*if (args.Key.Equals(actions[0].KeyCode))
{
    (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.5, 0.5);
    mouseclicker.DoMouseDown();
}
*/
