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

namespace picture_view_app
{
    public partial class picture_Form1 : Form
    {
        string dirpath;
        static int i = 0;

        public picture_Form1()
        {
            InitializeComponent();
        }

        private void picture_Form1_Load(object sender, EventArgs e)
        {

        }

        private void show_button_Click(object sender, EventArgs e)
        {
            
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dirpath = openFileDialog1.FileName;
                    
                pictureBox1.Load(openFileDialog1.FileName);
                next_button.Enabled = true;
                previous_button.Enabled = true;

            }
            else
            {

            }
            

        }

        private void picture_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void background_button_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stretch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stretch_checkBox.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void next_button_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show(dirpath);
            FileInfo finfo = new FileInfo(dirpath);
            DirectoryInfo dinfo = finfo.Directory;
          FileInfo[] IFiles= dinfo.GetFiles("*.jpg");
            if (i < IFiles.Length)
                pictureBox1.Load(IFiles[i++].FullName);
            else
                i = 0;

        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dirpath);
            FileInfo finfo = new FileInfo(dirpath);
            DirectoryInfo dinfo = finfo.Directory;
            FileInfo[] IFiles = dinfo.GetFiles("*.jpg");
            if (i < IFiles.Length)
                pictureBox1.Load(IFiles[i--].FullName);
            else
            {
                i = 0;
                MessageBox.Show("no other pictures");
                previous_button.Enabled = false;
                

                
            }
        }
    }
}
