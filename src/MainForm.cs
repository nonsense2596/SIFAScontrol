using SIFAScontrol.data;
using SIFAScontrol.Touch;
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

        Actions actions;
        GamePlayer gameplayer;

        public MainForm()
        {
            InitializeComponent();
            actions = new Actions();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // read settings from file

            // read settings from file
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

        AreaSelectFormTooltip asft;
        AreaSelectForm asf;

        private void button2_Click(object sender, EventArgs e)
        {
            asft = new AreaSelectFormTooltip();
            asf = new AreaSelectForm(asft, actions);
            asf.FormClosing += asf_FormClosedEvent; //(a, b) => { };
            asf.Show();
            asft.Show();

           
        }

        private void asf_FormClosedEvent(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("lolololoedsadasdasd");
            // write settings out to file

            // write settings out to file

        }

        private void button3_Click(object sender, EventArgs e)
        {

            gameplayer = new GamePlayer(actions);
            //WindowState = FormWindowState.Minimized;
        }





    }
}
