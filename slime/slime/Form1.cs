using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slime
{
    public partial class Form1 : Form
    {
        private telescope ts = new telescope();
        public telescope temporaryTs = new telescope();
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            downloadForm foam = new downloadForm();
            foam.ShowDialog();

            temporaryTs = foam.tempTs;
            
            foreach(downloadUnit item in temporaryTs.units)
            {
                ts.units.Add(item);
            }
            temporaryTs.units.Clear();
        }

        private void journalButton_Click(object sender, EventArgs e)
        {
            journalForm foam = new journalForm();

            if (ts.units != null)
            {
                foreach (downloadUnit item in ts.units)
                {
                    if (item.success == true)
                    {
                        foam.successListBox.Items.Add($"{item.fileName} ({item.url}), {item.unl}");
                    }
                }

                foreach (downloadUnit item in ts.units)
                {
                    if (item.success == false)
                    {
                        foam.failureListBox.Items.Add($"{item.fileName} ({item.url}), {item.unl}");
                    }
                }
            }

            foam.ShowDialog();
        }

        private void tagsButton_Click(object sender, EventArgs e)
        {
            tagsJournalForm foam = new tagsJournalForm();
            foam.tempTs = ts;
            foam.ShowDialog();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            controlsForm foam = new controlsForm();
            foam.tempTs = ts;
            foam.ShowDialog();
        }
    }


    public class telescope
    {
        public List<downloadUnit> units = new List<downloadUnit>();
        async public Task download(downloadUnit re)
        {
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile(re.url, re.savePath + "\\" + re.fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show($"ну ты и {e.Message}", "голос.");
                //return false;
            }

            //return true;
        }
    }
    public class downloadUnit
    {
        public string url { get; set; }
        public string savePath { get; set; }
        public string fileName { get; set; }

        public List<string> tags { get; set; }

        public DateTime unl { get; set; }

        public bool? success;

        public downloadUnit()
        {
            tags = new List<string>();
        }

        public downloadUnit(string url, string savePath, string fileName, List<string> tags, DateTime unl)
        {
            this.url = url;
            this.savePath = savePath;
            this.fileName = fileName;
            this.tags = tags;
            this.unl = unl;
        }
        public downloadUnit(string url, string savePath, string fileName, List<string> tags, DateTime unl, bool? success)
        {
            this.url = url;
            this.savePath = savePath;
            this.fileName = fileName;
            this.tags = tags;
            this.unl = unl;
            this.success = success;
        }
    }
}
