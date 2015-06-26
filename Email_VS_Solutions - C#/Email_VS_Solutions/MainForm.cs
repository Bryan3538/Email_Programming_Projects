using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_VS_Solutions
{
    public partial class MainForm : Form
    {

        private List<string> extensions;
        public const string EXTENSION_FILE = "bad_extensions.csv";
        private DirectoryInfo currentProject; //TODO: Add 'Rescan Project' button
        private List<string> files;
        private delegate void fileAction(string path);
        private string backupPath;
        private const string EXT_APPEND = "_changed";
        private const string CHANGED_MESSAGE = "{Changed & Restorable} ";

        public MainForm()
        {
            InitializeComponent();
            SetupTextBox();
            files = new List<string>();
            backupPath = "";
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            extensions = new List<string>(31);
            readExtensions();
        }

        private void GetFilesRecursively(DirectoryInfo directory, fileAction action)
        {
            //process files in this directory
            foreach (string file in Directory.GetFiles(directory.FullName))
            {
                action(file);  
            }

            //get all other directories within
            foreach (DirectoryInfo di in directory.GetDirectories())
            {
                GetFilesRecursively(di, action);
            }
        }

        private void backupFile(string fileToBackup)
        {
            //just the name of the individual file, not the path
            string filename = fileToBackup.Substring(fileToBackup.LastIndexOf("\\") + 1);
            //setting up information to get the directory as a substring
            int start = currentProject.FullName.Length;
            int end = fileToBackup.Length - filename.Length - 1;
            int length = end - start;
            string directory = length > 0 ? fileToBackup.Substring(start, length) : "";
            //new file path complete with nested directories
            string newFile = backupPath + directory + "\\" + filename;
            //recreates any subdirectories as needed
            if (directory != "" && !Directory.Exists(backupPath + directory))
                Directory.CreateDirectory(backupPath + directory);
            //raw data of the file being written
            byte[] data = File.ReadAllBytes(fileToBackup);
            //overwrite any existing files with this name
            if(File.Exists(newFile))
            {
                File.Delete(newFile);
            }
            //create the new file
            FileStream writer = new FileStream(newFile, System.IO.FileMode.CreateNew, System.IO.FileAccess.Write);
            writer.Write(data, 0, data.Length);
            writer.Close();
        }
        //visual stylilng of the main textbox
        private void SetupTextBox()
        {
            Font f = new Font("Arial", 12);
            badFilesTextBox.Multiline = true;
            badFilesTextBox.Height = this.Height - 258;
            badFilesTextBox.Width = this.Width - 25;
            badFilesTextBox.ScrollBars = ScrollBars.Both;
            badFilesTextBox.WordWrap = false;
            badFilesTextBox.Font = f;
            badFilesTextBox.ForeColor = Color.WhiteSmoke;
            badFilesTextBox.BackColor = (Color)ColorTranslator.FromHtml("#313A43");
            badFilesTextBox.Left = 5;
            badFilesTextBox.Top = 150;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = getProjectDirectory("Select the project's directory.");

            if(di != null)
                scanSolution(di);
        }

        private DirectoryInfo getProjectDirectory(string description)
        {
            DirectoryInfo di = null;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = description;
            DialogResult result = folderDialog.ShowDialog();
            

            if (result == DialogResult.OK)
            {
                di = new DirectoryInfo(folderDialog.SelectedPath);
            }

            return di;
        }

        private void scanSolution(DirectoryInfo di)
        {
            if (di != null)
            {
                currentProject = di;
                updateProjectLabel(currentProject.FullName, currentProjectLabel);

                files.Clear();

                badFilesTextBox.Clear();
                int startTime = DateTime.Now.Millisecond;
                GetFilesRecursively(di, addToList);
                int endTime = DateTime.Now.Millisecond;

                
                //fill in text box
                files.Sort();
                StringBuilder b = new StringBuilder();
                foreach (string path in files)
                    b.Append(path + Environment.NewLine);

                badFilesTextBox.AppendText(b.ToString());
                badFilesTextBox.AppendText(String.Format("Found {0} files.", files.Count));
            }
        }

        private void displayFiles()
        {
            files.Sort();
            //fill in text box
            StringBuilder b = new StringBuilder();
            foreach (string path in files)
                b.Append(path + Environment.NewLine);

            badFilesTextBox.AppendText(b.ToString());
            badFilesTextBox.AppendText(String.Format("Found {0} files.", files.Count));
        }

        private void addToList(string path)
        {
            foreach (string extension in extensions)
            {
                if (path.Substring(path.Length - extension.Length).Equals(extension))
                {
                    files.Add(path);
                    break;
                }
            }

            if (path.EndsWith(EXT_APPEND))
            {
                files.Add(CHANGED_MESSAGE + path);
            }
        }

        private void updateProjectLabel(string path, Label label)
        {
            string shownPath = path;
            const int MAX_SIZE = 65; //calculated by trial and error using default label font sizes
            
            if (shownPath.Length > MAX_SIZE)
            {
                shownPath = shownPath.Substring(0, MAX_SIZE);
                shownPath += "...";
            }

            currentProjectToolTip.SetToolTip(label, path);
            label.Text = shownPath;
        }

        //private void scanSolution()
        //{
        //    List<string> files = new List<string>();

        //    if (extensions.Count == 0)
        //        readExtensions();

        //    DirectoryInfo di;

        //    FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        //    DialogResult result = folderDialog.ShowDialog();

        //    if (result == DialogResult.OK)
        //    {
        //        di = new DirectoryInfo(folderDialog.SelectedPath);

        //        badFilesTextBox.Clear();
        //        int startTime = DateTime.Now.Millisecond;
        //        GetFilesRecursively(di, files);
        //        int endTime = DateTime.Now.Millisecond;

        //        //fill in text box
        //        StringBuilder b = new StringBuilder();
        //        foreach (string path in files)
        //            b.Append(path + Environment.NewLine);

        //        badFilesTextBox.AppendText(b.ToString());
        //        badFilesTextBox.AppendText(String.Format("Found {0} files.", files.Count));
        //        badFilesTextBox.AppendText(Environment.NewLine + String.Format("Scan took {0} seconds", (endTime - startTime) / 1000.0));
        //    }
        //}

        private void readExtensions()
        {
            if (File.Exists(EXTENSION_FILE))
            {
                StreamReader reader = new StreamReader(EXTENSION_FILE);
                string rawExtensions = reader.ReadLine();
                string[] badExtensions = rawExtensions.Split(',');

                foreach (string s in badExtensions)
                {
                    extensions.Add(s.Trim());
                }

                reader.Close();
            }
            else
            {
                MessageBox.Show("The required extensions file for this program is missing. If you wish for the scan to work, " 
                    + "please add extensions via the Add/Remove Extensions Dialog", "Extension File Missing", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void modifyExtensionsButton_Click(object sender, EventArgs e)
        {
            ExtensionModificationForm modForm = new ExtensionModificationForm(extensions);
            modForm.ShowDialog();
        }

        private void rescanProjectButton_Click(object sender, EventArgs e)
        {
            if (currentProject != null)
                scanSolution(currentProject);
            else
                MessageBox.Show("You must scan a project before you can rescan it!", "Rescan Project Failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void backupDirectory(object sender, EventArgs e)
        {
            //get the backup directory
            DirectoryInfo backupDirectory = getProjectDirectory("Select a directory to back up to.");

            if (backupDirectory != null)
            {
                
                //if a project and backup directory are selected and the user agrees to the above prompts
                if (currentProject != null && backupDirectory != null)
                {
                    //give warning that data will be overwritten
                    DialogResult result = MessageBox.Show("Backing up data will automatically overwrite data in the chosen backup directory. Proceed?",
                        "Overwrite Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        //create the new directory
                        string rootDirectory = currentProject.FullName.Substring(currentProject.FullName.LastIndexOf("\\") + 1);
                        //set the full backup path
                        backupPath = backupDirectory.FullName + "\\" + rootDirectory + "_backup";
                        //create the directory for the backup
                        if (!Directory.Exists(backupPath))
                            Directory.CreateDirectory(backupPath);
                        //backup the project
                        GetFilesRecursively(currentProject, backupFile);
                        //set the backup directory label
                        updateProjectLabel(backupPath, backupDirectoryLabel);
                        //tell the user of the successful backup
                        MessageBox.Show("Your project was backed up successfully.",
                        "Backup Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("You must select a project and backup directory first!");
            }
        }

        private void emailableButton_Click(object sender, EventArgs e)
        {
            string newName = "";

            

            if (files != null && files.Count > 0)
            {
                if (backupPath == "")
                {
                    DialogResult result = MessageBox.Show("You have not backed up this project yet, are you sure you wish to modify it?",
                        "Modify Project Before Backup Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        return;
                    }

                }

                foreach (string file in files)
                {
                    if (!file.StartsWith(CHANGED_MESSAGE))
                    {
                        //rename it so the extension is different
                        newName = file + EXT_APPEND;

                        if (File.Exists(file) && !File.Exists(newName))
                        {
                            File.Move(file, newName);
                            //File.Delete(file);
                        }
                    }
                    
                }

                MessageBox.Show("Your project should now be safe to email.");
                scanSolution(currentProject);
            }
            else 
            {
                if (currentProject == null)
                {
                    MessageBox.Show("You must select a project before I can make it emailable!",
                        "Make Emailable Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Your current project is already emailable.",
                        "Make Emailable Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        } 

        private void restoreButton_Click(object sender, EventArgs e)
        {
            if (currentProject != null)
            {
                GetFilesRecursively(currentProject, restoreFile);
                MessageBox.Show("Your project has been restored to its original state.");
                scanSolution(currentProject);
            }
            else
                MessageBox.Show("You must select a project before one can be restored!",
                    "Project Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void restoreFile(string path)
        {
            string newName = "";

            if (path.EndsWith(EXT_APPEND))
            {
                newName = path.Substring(0, path.Length - EXT_APPEND.Length);
                File.Move(path, newName);
                File.Delete(path);
            }
        }
    }
}
