using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        private float ImageScale = 1.0f;
        private int imw, imh;
        private void Form3_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.MouseWheel += new MouseEventHandler(mose);
            imw = this.pictureBox1.Image.Width;
            imh = this.pictureBox1.Image.Height;
        }
        

        private void mose(object sender, MouseEventArgs e)
        {
            const float spd = 0.1f / 120;
            ImageScale += e.Delta * spd;
            if (ImageScale < 0)
            {
                ImageScale = 0;
            }
            this.pictureBox1.Dock = DockStyle.None;
            this.pictureBox1.Size = new Size(
                (int)(imw * ImageScale),
                (int)(imh * ImageScale) );

        }
    }
}
