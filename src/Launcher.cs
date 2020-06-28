using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.src
{
    class Launcher
    {

        private static Launcher instance = null;
        private static readonly object padlock = new Object();

        MainForm mf; // ez felel minden mas grafikus bizbaz elinditasaert

        Launcher()
        {
            //mf = new MainForm();
            //Application.Run(mf);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Idle += delegate { Thread t = new Thread(Program.InitInterceptKeys); t.Start(); };

            Application.Run(new MultiFormContext(new MainForm()));
            
        }

        public static Launcher Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new Launcher();
                    }
                }
                return instance;
            }
        }

    }
}
