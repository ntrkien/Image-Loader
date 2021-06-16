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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private String locale;
        private string[] files;

        private void Form2_Load(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.ShowDialog();

            
            if (f.SelectedPath != "")
            {
                files = Directory.GetFiles(f.SelectedPath);    //lay dia chi
                locale = f.SelectedPath;
                DataTable table = new DataTable();                      //tao data table
                table.Columns.Add("File Name");
                table.Columns.Add("File Resolution");
                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo info = new FileInfo(files[i]);
                    table.Rows.Add(info.Name);
                }
                dtgView.DataSource = table;
            }

            
        }

       

        private void dtgView_DoubleClick_1(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            String imgName = dtgView.CurrentRow.Cells[0].Value.ToString();
            form3.pictureBox1.ImageLocation = locale + @"\"+ imgName;
            form3.ShowDialog();
        }
    }
}
