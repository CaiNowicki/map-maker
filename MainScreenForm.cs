using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map_maker
{
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the relevant texture image file.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                //set up here to select from the folder from earlier
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                    //add in error handling here to ensure the file selected is an image file
                    //something with file endings?
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
