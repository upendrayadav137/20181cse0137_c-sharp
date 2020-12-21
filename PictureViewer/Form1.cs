﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        String path;
        static int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void showPicture_Button_Click(object sender, EventArgs e)
        {

            // Shows the Open file dialog window, if user selects
            // an image file load that to file dialog box 
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pictureBox1.Load(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Image not Selected", "Notice",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            // Clears the Picture from PictureBox
            // By setting the Image property to null
            if(pictureBox1.Image!=null)
                pictureBox1.Image = null;
            else
            {
                MessageBox.Show("No image to Clear","Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            // closes the form i.e., closes the parent form
            // Entire app will be closed
            this.Close();
        }

        private void setBg_button_Click(object sender, EventArgs e)
        {
            // shows the color dialog
            // if user selects  color then
            // set that color to background
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void stretch_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(Stretch_checkBox.Checked)
            {
                // Stretches the image
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                // set the image to normal mode
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void previous_button_Click(object sender, EventArgs e)
        {
            FileInfo fInfo = new FileInfo(path);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.jpg");
            if (i < lFiles.Length)
            {
                pictureBox1.Load(lFiles[i--].FullName);
            }
            else
            {
                i = 0;
                pictureBox1.Load(lFiles[i--].FullName);
            }

        }

        private void next_button_Click(object sender, EventArgs e)
        {
            i = 0;
            FileInfo fInfo = new FileInfo(path);
            DirectoryInfo dInfo = fInfo.Directory;
            FileInfo[] lFiles = dInfo.GetFiles("*.jpg");
            if(i<lFiles.Length)
            {
                pictureBox1.Load(lFiles[i++].FullName);
            }
            else
            {
                i = 0;
                pictureBox1.Load(lFiles[i++].FullName);
            }
            
        }

        private void Zoom_trackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
