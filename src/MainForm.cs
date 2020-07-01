using SIFAScontrol.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.src
{
    public partial class MainForm : Form
    {
        public string ConfigFilePath { get; set; }

        Actions ActionList;
        GamePlayer gameplayer;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(InterceptKeys.InitializeComponent);
            t.Start();

            //Console.WriteLine("lololol");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigFilePath = "";
            configPicker.InitialDirectory = "C:\\";
            configPicker.Filter = "SIFConfig files (*.sifc)|*.sifc";
            configPicker.Multiselect = false;
            if (configPicker.ShowDialog() == DialogResult.OK)
            {
                ConfigFilePath = configPicker.FileName;
            }
            configPicker.Dispose();
            Console.WriteLine(ConfigFilePath);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AreaSelectFormTooltip asft = new AreaSelectFormTooltip();
            AreaSelectForm asf = new AreaSelectForm(asft);
            asf.Show();
            asft.Show();

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gameplayer = new GamePlayer(ActionList);
            WindowState = FormWindowState.Minimized;
        }
    }
}
