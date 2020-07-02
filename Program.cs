using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XInputDotNetPure;
using System.Runtime.InteropServices;
using System.Drawing;
using SIFAScontrol.src;
using SIFAScontrol.data;
using SIFAScontrol.Abstraction;

namespace SIFAScontrol
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            var pads = Gamepad.GetConnectedDevices();
            if(pads.Count > 0)
            {
                Gamepad pad = pads.First();
                pad.StateChanged += Pad_StateChanged;
                pad.KeyUp += Pad_KeyUp;
                pad.KeyDown += Pad_KeyDown;
            }
            else
            {
                Console.WriteLine("No gamepads connected");
            }
            Console.ReadLine();







            /*Launcher launcher = Launcher.Instance;  

            Console.WriteLine("lola");
            var stdIn = Console.OpenStandardInput();
            byte[] bytes = new byte[100];
            int outputLength;


            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();

            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            Console.WriteLine("{0}x{1}",screenWidth, screenHeight);*/





            /*while (true)
            {
                GamePadState state = GamePad.GetState(PlayerIndex.One);
                Console.WriteLine("IsConnected {0} Packet #{1}", state.IsConnected, state.PacketNumber);
                Console.WriteLine("\tTriggers {0} {1}", state.Triggers.Left, state.Triggers.Right);
                Console.WriteLine("move stick {0} ", state.ThumbSticks.Left.X);
                Thread.Sleep(100);
            }*/

        }

        static MouseClicker mouseclicker = new MouseClicker();


        private static void Pad_StateChanged(object sender, EventArgs args)
        {
            
            //Console.WriteLine((sender as Gamepad)?.ToString());
            string result = (sender as Gamepad)?.StickToString();
            if (result != "0;0")
            {
                //Cursor c = new Cursor(Cursor.Current.Handle);
                mouseclicker.DoMouseClick();
                //Cursor.Position = new Point(Cursor.Position.X - 3, Cursor.Position.Y);
            }
                Console.WriteLine(result);
                
            //Gamepad gp = (Gamepad)sender;
            //Console.WriteLine(args.ToString());
            //if (gp.A)
            //{
            //    Console.WriteLine("A");
            //}
            //foreach (XInput.GamepadButtons gpb in (XInput.GamepadButtons[]) Enum.GetValues(typeof(XInput.GamepadButtons)))
            //{

            //}

            //Enum.GetValues(typeof(XInput.GamepadButtons)).Cast<XInput.GamepadButtons>().ToList().ForEach(x => Console.WriteLine(x.Equals(gp.A) ? "A" : ""));

        }

        private static void Pad_KeyDown(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            //(sender as Gamepad).Vibration = new VibrationMotorSpeed(0.5, 0.5);
            
            //Console.WriteLine(args.Key);
            
            
            /*Actions teszt = new Actions();
            for(int i = 0; i < 6; i++)
            {
                if(teszt[i].KeyCode == args.Key)
                {
                    Console.WriteLine(teszt[i].Name);
                }   
            }*/
            //foreach ()
            //{
            //    if (args.Key == )
            //    {
            //        Console.WriteLine(gpb);
            //    }
            //}
        }

        private static void Pad_KeyUp(object sender, SIFAScontrol.Abstraction.KeyEventArgs args)
        {
            (sender as Gamepad).Vibration = new VibrationMotorSpeed(0.0, 0.0);
            Console.WriteLine(args.Key);
        }

    }
}
