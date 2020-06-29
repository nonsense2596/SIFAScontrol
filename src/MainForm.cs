using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.src
{
    public partial class MainForm : Form
    {
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
            string filePath = "";
            configPicker.InitialDirectory = "c:\\";
            configPicker.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            configPicker.FilterIndex = 2;
            configPicker.RestoreDirectory = true;
            if (configPicker.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = configPicker.FileName;
            }
            Console.WriteLine(filePath);
        }
    }
}
