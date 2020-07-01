using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.src
{
    public partial class AreaSelectFormTooltip : Form
    {
        public Label text { get; set; }
        public AreaSelectFormTooltip()
        {
            InitializeComponent();
            TopMost = true;
            //FormBorderStyle = FormBorderStyle
            Location = new Point(0, 0);
            StartPosition = FormStartPosition.Manual;


            text = new Label();
            text.Location = new Point(0, 0);
            text.Size = new Size(this.Width, this.Height);
            text.ForeColor = Color.Black;
            text.Font = new Font("Georgia", 16);
            text.Text = "lolo l asdasd sajdasjd adjas 1keqwk dijwq wj qwjd iwqdiq idjq  q pd qijhd qiqj qdjqi qődqkdijdfhe pfjweifejfe eif ";
            text.Show();

            Controls.Add(text);
        }
    }
}
