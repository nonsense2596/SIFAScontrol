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



            Launcher launcher = Launcher.Instance;  // ez felel minden mas szolgaltatas elinditasaert

            








            Thread t = new Thread(InitInterceptKeys);
            t.Start();
            
            Console.WriteLine("lola");
            var stdIn = Console.OpenStandardInput();
            byte[] bytes = new byte[100];
            int outputLength;




            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();

            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();

            Console.WriteLine("{0}x{1}",screenWidth, screenHeight);



            while (true)
            {
                GamePadState state = GamePad.GetState(PlayerIndex.One);
                Console.WriteLine("IsConnected {0} Packet #{1}", state.IsConnected, state.PacketNumber);
                Console.WriteLine("\tTriggers {0} {1}", state.Triggers.Left, state.Triggers.Right);
                Console.WriteLine("move stick {0} ", state.ThumbSticks.Left.X);
                Thread.Sleep(100);
            }

        }
        public static void InitInterceptKeys()
        {
            InterceptKeys.InitializeComponent();
        }
        public static void Loller()
        {
            while (true)
            {
                /*GamePadState state = GamePad.GetState(PlayerIndex.One);
                Console.WriteLine("IsConnected {0} Packet #{1}", state.IsConnected, state.PacketNumber);
                Console.WriteLine("\tTriggers {0} {1}", state.Triggers.Left, state.Triggers.Right);
                Console.WriteLine("move stick {0} ", state.ThumbSticks.Left.X);*/
                //Thread.Sleep(100);
                //Console.WriteLine(DateTime.Now.Millisecond);
            }
        }
    }
}
