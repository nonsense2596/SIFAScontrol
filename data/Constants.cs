using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SIFAScontrol.XInput;

namespace SIFAScontrol.data
{
    public class Constants
    {
        public const int ButtonCount = 14;

        public static readonly XInput.GamepadButtons[] ButtonValue = {
            GamepadButtons.DPadUp,
            GamepadButtons.DPadDown,
            GamepadButtons.DPadLeft,
            GamepadButtons.DPadRight,
            GamepadButtons.Start,
            GamepadButtons.Back,
            GamepadButtons.LeftThumb,
            GamepadButtons.RightThumb,
            GamepadButtons.LeftShoulder,
            GamepadButtons.RightShoulder,
            GamepadButtons.A,
            GamepadButtons.B,
            GamepadButtons.X,
            GamepadButtons.Y,
        };
    }
}
