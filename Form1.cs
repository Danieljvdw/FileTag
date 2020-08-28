using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace FileTag
{
    public partial class Form1 : Form
    {
        string fileTagsFileName = Directory.GetCurrentDirectory() + "\\fileTags.xml";
        string taggedFilesFileName = Directory.GetCurrentDirectory() + "\\taggedFiles.xml";

        List<taggedFile> taggedFiles = new List<taggedFile>();
        taggedFile currentTaggedFile = new taggedFile();
        List<string> tags = new List<string>();

        public Form1()
        {
            InitializeComponent();

            loadTags();
            loadTaggedFiles();
            loadFiles(Properties.Settings.Default.Path);
        }

#if false
        private void deleteDuplicated(object sender, EventArgs e)
        {
            string[] duplicate = File.ReadAllLines("C:\\Users\\danie\\Documents\\duplicate.txt");

            foreach(string s in duplicate)
            {
                if(s.Contains("cont") || s.StartsWith("-"))
                {

                }
                else
                {
                    string[] tokens = s.Split('\t');
                    string path = tokens[1] + "\\" + tokens[0];

                    File.Delete(path);

                    Console.WriteLine("Will delete: " + path);
                }
            }
        }
#endif

        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Path = folderBrowserDialog.SelectedPath;
                Properties.Settings.Default.Save();

                loadFiles(Properties.Settings.Default.Path);
            }
        }

        private void loadFiles(string path)
        {
            if (!Directory.Exists(path))
                return;

            lblDirectory.Text = path;

            dgvFiles.Rows.Clear();

            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                dgvFiles.Rows.Add(s.Substring(path.Length + 1));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            saveTag(textBox1.Text);
        }

        private void DgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            saveTaggedFile();
            loadTaggedFile((string)dgvFiles.Rows[e.RowIndex].Cells[0].Value);
        }

        private void DgvTags_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            toggleTag((string)dgvTags.Rows[e.RowIndex].Cells[0].Value);
        }

        private void loadTags()
        {
            dgvTags.Rows.Clear();

#if false
            DataSet ds = new DataSet();

            if (!File.Exists(fileTagsFileName))
                return;

            ds.ReadXml(fileTagsFileName);

            foreach (DataRow d in ds.Tables[0].Rows)
            {
                dgvTags.Rows.Add(d.ItemArray);
            }
#else
            if (!File.Exists(fileTagsFileName))
                return;

            tags = xml.ReadFromXmlFile<List<string>>(fileTagsFileName);

            foreach (string tag in tags)
            {
                dgvTags.Rows.Add(tag);
            }
#endif
        }

        private void saveTag(string tag)
        {
#if false
            dgvTags.Rows.Add(tag);

            DataTable dt = new DataTable();
            dt.TableName = "Tags";

            for (int i = 0; i < dgvTags.Columns.Count; i++)
            {
                string headerText = dgvTags.Columns[i].HeaderText;
                headerText = Regex.Replace(headerText, "[-/, ]", "_");

                DataColumn column = new DataColumn(headerText);
                dt.Columns.Add(column);
            }

            foreach (DataGridViewRow row in dgvTags.Rows)
            {
                object[] cellValues = new object[dgvTags.Columns.Count];

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }

                if (!row.IsNewRow)
                    dt.Rows.Add(cellValues);
            }

            dt.WriteXml(fileTagsFileName);
#else

#endif
            tags.Add(tag);

            xml.WriteToXmlFile<List<string>>(fileTagsFileName, tags);

            loadTags();
            updateTags();
        }

        private void loadTaggedFiles()
        {
            if (!File.Exists(taggedFilesFileName))
                return;

            taggedFiles = xml.ReadFromXmlFile<List<taggedFile>>(taggedFilesFileName);
        }

        private void loadTaggedFile(string filename)
        {
            bool fileExists = false;

            foreach(taggedFile taggedFile in taggedFiles)
            {
                if(taggedFile.file == filename)
                {
                    currentTaggedFile = taggedFile;
                    fileExists = true;
                    break;
                }
            }

            if (!fileExists)
            {
                currentTaggedFile = new taggedFile();
                currentTaggedFile.file = filename;
                taggedFiles.Add(currentTaggedFile);
            }

            updateTags();
        }

        private void saveTaggedFile()
        {
            int filePosition = 0;
            bool fileExists = false;

            foreach (taggedFile taggedFile in taggedFiles)
            {
                if (taggedFile.file == currentTaggedFile.file)
                {
                    currentTaggedFile = taggedFile;
                    fileExists = true;
                    break;
                }

                filePosition++;
            }

            taggedFiles.Insert(filePosition, currentTaggedFile);
            if (fileExists)
            {
                taggedFiles.RemoveAt(filePosition + 1);
            }

#if flase
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(taggedFile));
            
            using (var stream = File.OpenWrite(taggedFilesFileName))
            {
                xmlSerializer.Serialize(stream, taggedFiles);
            }
#else
            xml.WriteToXmlFile<List<taggedFile>>(taggedFilesFileName, taggedFiles);
#endif
        }

        private void toggleTag(string tag)
        {
            bool isTagged = false;
            int tagPosition = 0;

            foreach(string t in currentTaggedFile.tags)
            {
                if(t == tag)
                {
                    isTagged = true;
                    break;
                }

                tagPosition++;
            }

            if(isTagged)
            {
                currentTaggedFile.tags.RemoveAt(tagPosition);
            }
            else
            {
                currentTaggedFile.tags.Add(tag);
            }

            updateTags();
        }

        private void updateTags()
        {
            foreach (DataGridViewRow tagRow in dgvTags.Rows)
            {
                bool tagToggled = false;

                foreach (string tag in currentTaggedFile.tags)
                {
                    if (tag == (string)tagRow.Cells[0].Value)
                    {
                        tagToggled = true;
                        break;
                    }
                }

                if (tagToggled)
                {
                    tagRow.Cells[0].Style.BackColor = Color.Green;
                }
                else
                {
                    tagRow.Cells[0].Style.BackColor = Color.White;
                }
            }
        }

        private void DgvTags_SelectionChanged(object sender, EventArgs e)
        {
            dgvTags.ClearSelection();
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, e);
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }

    public class taggedFile
    {
        
        public string file;
        public List<string> tags;

        public taggedFile()
        {
            file = "";
            tags = new List<string>();
        }
    }
}
