using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace Renamer
{
    public partial class MusicSorter : Form
    {
        public List<string> files;
        public List<string> unconvertedFiles;
        public List<string> mp3s;
        public MusicSorter()
        {
            InitializeComponent();
            unconvertedFiles = new List<string>();
            mp3s = new List<string>();
            filesList.View = View.Details;
            filesList.GridLines = true;
            filesList.FullRowSelect = true;
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            string dialogResult = folderBrowserDialog.ShowDialog().ToString();
            if (dialogResult == "OK")
            {
                filesList.Items.Clear();
                files = Directory.GetFiles(folderBrowserDialog.SelectedPath).ToList();
                foreach (var file in files)
                {
                    if (file.Substring(file.Length - 3) == "mp3")
                    {
                        filesList.Columns[0].ListView.Items.Add(new ListViewItem(file.Replace(folderBrowserDialog.SelectedPath + "\\", "")));
                        mp3s.Add(file);
                    }
                }
                itemsCountLabel.Text = String.Format("Files in list: {0}", mp3s.Count);

            }
            else
            {
                ResultLabel.Text = dialogResult;
            }
        }


        private void convertButton_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = mp3s.Count;
            progressBar.Value = 0;
            foreach (var filePath in mp3s)
            {

                TagLib.Tag tag = TagLib.File.Create(filePath).GetTag(TagTypes.Id3v1);
                string fileOriginName = filePath.Replace(folderBrowserDialog.SelectedPath + "\\", "");
                string resultName = !string.IsNullOrEmpty(tag.FirstPerformer) && !string.IsNullOrEmpty(tag.Title) ? tag.FirstPerformer + " - " + tag.Title + ".mp3" : fileOriginName;


                resultName = resultName.Replace("<", "");
                resultName = resultName.Replace(">", "");
                resultName = resultName.Replace(":", "");
                resultName = resultName.Replace("\\", "");
                resultName = resultName.Replace("\"", "");
                resultName = resultName.Replace("/", "");
                resultName = resultName.Replace("|", "");
                resultName = resultName.Replace("?", "");
                resultName = resultName.Replace("*", "");
                if (!System.IO.File.Exists(folderBrowserDialog.SelectedPath + "\\" + resultName))
                {
                    System.IO.File.Move(filePath, folderBrowserDialog.SelectedPath + "\\" + resultName);
                }
                else { unconvertedFiles.Add(filePath); }

                progressBar.Value += 1;
            }
            ResultLabel.Text = "Converted!";
            filesList.Items.Clear();
            foreach (var file in unconvertedFiles)
            {
                filesList.Columns[0].ListView.Items.Add(new ListViewItem(file.Replace(folderBrowserDialog.SelectedPath + "\\", "")));
            }
        }

        private void filesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ListViewItem item in filesList.SelectedItems)
                {
                    mp3s.Remove(folderBrowserDialog.SelectedPath + "\\" + item.Text);
                    filesList.Items.Remove(item);
                    itemsCountLabel.Text = String.Format("Files in list: {0}", mp3s.Count);
                }
            }
        }



    }
}
