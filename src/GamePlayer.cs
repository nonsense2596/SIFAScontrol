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

            var pads = Gamepad.GetConnectedDevices();
            if (pads.Count > 0)
            {
                Gamepad pad = pads.First();
                pad.StateChanged += Pad_StateChanged;
                pad.KeyUp += Pad_KeyUp;
                pad.KeyDown += Pad_KeyDown;
            }

        }
        private  void Pad_StateChanged(object sender, EventArgs args)
        {
        }
        private  void Pad_KeyDown(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            

            if (args.Key.Equals(actions[0].KeyCode))
            {
                (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.5, 0.5);
            }

        }
        private void Pad_KeyUp(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.0, 0.0);
        }



        }
}
