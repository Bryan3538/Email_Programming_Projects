using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_VS_Solutions
{
    public partial class ExtensionModificationForm : Form
    {
        List<string> extensions;
        List<string> inExtensions;
        bool changes;
        public ExtensionModificationForm(List<string> inExtensions)
        {
            InitializeComponent();

            this.inExtensions = inExtensions;
            extensions = new List<string>(inExtensions.Count - 1);

            foreach (string ext in inExtensions)
                extensions.Add(ext);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addTextBox.Text.Trim() != "")
            {
                string extension = addTextBox.Text.Trim();

                if (!extension.StartsWith("."))
                    extension = extension.Insert(0, ".");

                if (!extensions.Contains(extension))
                {
                    extensions.Add(extension);
                    extensions.Sort();
                    updateListBox();
                    changes = true;
                }

                extensionsListBox.SetSelected(extensionsListBox.Items.IndexOf(extension), true);

            }
            else
            {
                MessageBox.Show("You must enter an extension before adding.", "Add Extensions Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateListBox()
        {
            if (extensionsListBox.Items.Count > 0)
                extensionsListBox.Items.Clear();

            foreach (string extension in extensions)
                extensionsListBox.Items.Add(extension);
        }

        private void ExtensionModificationForm_Load(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (extensionsListBox.SelectedIndex >= 0 &&
                extensionsListBox.SelectedIndex < extensions.Count)
            {
                extensions.RemoveAt(extensionsListBox.SelectedIndex);
                extensions.Sort();
                updateListBox();
                changes = true;
            }
            else
            {
                MessageBox.Show("You must select an extension before you can remove it!", "Remove Extension Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveExtensions();
            this.Dispose();
        }

        private void saveExtensions()
        {
            if (changes == true)
            {
                StringBuilder newExtensionList = new StringBuilder();

                if (extensions.Count > 0)
                {
                    extensions.Sort();
                    newExtensionList.Append(extensions.ElementAt(0));

                    for (int i = 1; i < extensions.Count; i++)
                    {
                        newExtensionList.Append(", ");
                        newExtensionList.Append(extensions.ElementAt(i));
                    }
                }

                //save them to file;
                StreamWriter writer = new StreamWriter(MainForm.EXTENSION_FILE);
                writer.Write(newExtensionList.ToString());
                writer.Close();

                //save them for this instance of the program
                inExtensions.Clear();
                foreach (string ext in extensions)
                    inExtensions.Add(ext);
            }
        }
    }
}
