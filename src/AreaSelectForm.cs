using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIFAScontrol.src
{
    public partial class AreaSelectForm : Form
    {
        public string RetTeszt { get; set; }

        AreaSelectFormTooltip asft;
        Image bgimage;
        public AreaSelectForm(AreaSelectFormTooltip asft)
        {
            this.asft = asft;


            InitializeComponent();
            WindowState = FormWindowState.Minimized;
            asft.WindowState = FormWindowState.Minimized;
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);


                bgimage = new Bitmap(bitmap);
                this.pictureBox1.Image = bgimage;
                WindowState = FormWindowState.Maximized;
                asft.WindowState = FormWindowState.Normal;
            }
            Paint += new PaintEventHandler(AreaSelectForm_Paint);

            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

            RetTeszt = "keksz";
        }


        List<Rectangle> l = new List<Rectangle>();

        private void AreaSelectForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in l)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Red, 5), item);
            }

        }

        private void AreaSelectForm_Load(object sender, EventArgs e)
        {
           // asft.text.Text = "loller";
        }

        int s_x;
        int s_y;
        bool drawing = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            s_x = e.X;
            s_y = e.Y;
            l.Add(new Rectangle(0, 0, 0, 0));
            drawing = true;
            Invalidate();

            asft.text.Text = s_x.ToString();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                int f_x = e.X;
                int f_y = e.Y;

                int x_min = Math.Min(s_x, f_x);
                int y_min = Math.Min(s_y, f_y);
                int width = Math.Abs(s_x - f_x);
                int height = Math.Abs(s_y - f_y);

                l.RemoveAt(l.Count - 1);
                l.Add(new Rectangle(x_min, y_min, width, height));

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in l)
            {
                e.Graphics.DrawRectangle(new Pen(Color.Red, 5), item);
            }
            pictureBox1.Invoke(new Action(() => pictureBox1.Invalidate()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ~AreaSelectForm()
        {
            bgimage.Dispose();
        }
        override protected void OnFormClosed(System.Windows.Forms.FormClosedEventArgs e)
        {
            asft.Close();
            base.OnFormClosed(e);

        }
    }
}
