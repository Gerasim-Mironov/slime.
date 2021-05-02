using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slime
{
    public partial class tagsJournalForm : Form
    {
        public telescope tempTs;
        public tagsJournalForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            tagsListBox.Items.Clear();

            if (tagsTextBox.Text != string.Empty)
            {
                string income = tagsTextBox.Text;
                List<string> vs = new List<string>();

                string msg = string.Empty;
                for (int i = 0; i < income.Length; i++)
                {
                    if (income[i] == ',' || i == income.Length)
                    {
                        vs.Add(msg);
                        msg = string.Empty;
                    }
                    else if (income[i] == ' ')
                    {
                        ;
                    }
                    else
                    {
                        msg += income[i];
                    }
                }

                foreach (string item in vs)
                {
                    foreach (downloadUnit obj in tempTs.units)
                    {
                        foreach (string sbj in obj.tags)
                        {
                            if (sbj == item)
                            {
                                tagsListBox.Items.Add($"{obj.fileName} ({obj.url}), {obj.unl}");
                            }
                        }
                    }
                }
            }
        }
    }
}
