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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Foto_album
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Wybierz_F_Click(object sender, EventArgs e)
        {
            Kopiuj.Enabled = true;
            var folderPath = string.Empty;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = folderPath;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderBrowserDialog.SelectedPath;
                }
            }
            
            textBox1.Text = folderPath;

        }

        private void Wybierz_2_Click(object sender, EventArgs e)
        {
            var folderPath = string.Empty;

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.SelectedPath = folderPath;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    folderPath = folderBrowserDialog.SelectedPath;
                }
            }

            textBox2.Text = folderPath;
        }

        private void Kopiuj_Click(object sender, EventArgs e)
        {
            var folderPath = textBox1.Text;
            var destination = textBox2.Text;

            ProcessDirectory(folderPath, destination);
            Kopiuj.Enabled = false;
        }
        public static void ProcessDirectory(string targetDirectory,string destination)
        {
            string[] files = Directory.GetFiles(targetDirectory, "*jpg");
            if (files.Length == 0)
            {
                return;
            }

            foreach (string fileName in files)
                ProcessFile(fileName,destination);
    

            string[] subdirectories = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectories)
                ProcessDirectory(subdirectory, destination);
        }

        public static void ProcessFile(string path,string destination)
        {
            string fName = Path.GetFileName(path);
            string dirName = new DirectoryInfo(Path.GetDirectoryName(path)).Name;
            DateTime time = File.GetCreationTime(path);
            string creationTime = time.ToString("yyyyMMddHHmmss");
            string newFileName = creationTime + "_" + dirName + "_" + fName;

            string destinationPath = Path.Combine(destination, newFileName);

            File.Copy(path, destinationPath, true);
        }
}
}
