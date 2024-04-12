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
    public partial class FileSelectForm : Form
    {
        public FileSelectForm()
        {
            InitializeComponent();
        }

        private void FileSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select the folder containing the map texture image files.";
                folderDialog.ShowNewFolderButton = false; // this means the user can't create new folders, just open them

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; // store the file path for later processing
                }
            }
        }
    }
}
