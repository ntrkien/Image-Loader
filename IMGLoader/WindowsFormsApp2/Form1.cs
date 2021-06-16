using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Form2;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        

        public void openBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        
        

        /*public void openSi_Click(object sender, EventArgs e)
        {
            OpenFileDialog fb = new OpenFileDialog();
            fb.Multiselect = true;
            DialogResult resultfb = fb.ShowDialog();
            if (resultfb == DialogResult.OK)
            {
                Form form = new Form();

                PictureBox ptBox = new PictureBox();
                ptBox.Dock = DockStyle.Fill;
                ptBox.Load(fb.FileName);
                ptBox.SizeMode = PictureBoxSizeMode.CenterImage;
                form.Controls.Add(ptBox);
                form.ShowDialog();

            }
        }*/

        public void dtg_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        

       
    }
}
