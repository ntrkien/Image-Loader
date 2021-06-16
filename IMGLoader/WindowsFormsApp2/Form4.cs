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

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }


        private string[] imgFiles;

        private void Form4_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();

            if (f.SelectedPath != "")
            {
                imgFiles = Directory.GetFiles(f.SelectedPath, "*.png");
                showingImage(sender);
            }


        }

        public void showingImage(object sender)
        {
            int i = 0, j = 0;
            PictureBox p;
            Button t;

            foreach (var png in imgFiles)
            {
                p = new PictureBox();
                t = new Button();
                System.Drawing.Image img = System.Drawing.Image.FromFile(png);
                p.ImageLocation = png;

                float pcW = 0; float pcH = 0;
                float pcWH = (float)img.Width / (float)img.Height;
                if (img.Width > img.Height)
                {
                    pcW = ((float)img.Width / (float)400);
                    pcH = ((float)img.Height / pcW);
                    pcW = 400;
                }
                else if (img.Width < img.Height)
                {
                    pcH = ((float)img.Height / (float)400);
                    pcW = ((float)img.Width) / pcH;
                    pcH = 400;

                }
                else if (img.Width == img.Height)
                {
                    pcH = pcW = 400;
                }

                if (j == 0)
                {
                    p.Location = new Point(i * 400, 22);
                }
                else
                {
                    p.Location = new Point(i * 400, j * 678 + 22);
                }
                
                t.Location = new Point(i * 400, j * 678);
                

                t.Width = 400;
                t.Text = png + "___" + img.Width.ToString() + "x" + img.Height.ToString();//Hien thi dia chi file len button t
                p.Width = (int)pcW;
                p.Height = (int)pcH;
                p.SizeMode = PictureBoxSizeMode.StretchImage;   //Mode hien thi hinh anh = scale

                i++;                    //Anh tiep theo

                if (i % 4 == 0)         //4 Anh trong 1 hang
                {
                    j++;                //Du 4 Anh thi xuong dong
                    i = 0;
                }
                this.Controls.Add(p);
                this.Controls.Add(t);

                p.Click += p_Click;
            }
        }
        public void p_Click(object sender, EventArgs e)
        {
            PictureBox t = (PictureBox)sender;

            Form3 form3 = new Form3();

            form3.pictureBox1.Image = t.Image;
            form3.ShowDialog();
            form3.AutoScroll = true;

        }

    }
}
