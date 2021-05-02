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
    public partial class downloadForm : Form
    {
        public downloadUnit temp;
        public telescope tempTs = new telescope();

        Task re;

        public downloadForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string temple = string.Empty;
            List<string> tags = new List<string>();
            for (int i = 0; i < tagsTextBox.Text.Length; i++)
            {
                if (tagsTextBox.Text[i] == ',' || i == tagsTextBox.Text.Length)
                {
                    tags.Add(temple);
                    temple = string.Empty;
                }
                else if (tagsTextBox.Text[i] == ' ')
                {
                    ;
                }
                else
                {
                    temple += tagsTextBox.Text[i];
                }
            }

            DateTime ae = DateTime.Now;

            temp = new downloadUnit(linkTextBox.Text, locationTextBox.Text, fileNameTextBox.Text, tags, ae);

            pauseButton.Visible = true;
            re = Task.Run(() =>
            {
                tempTs.download(temp);
                MessageBox.Show("дело сделано.", "голос.");
                temp.success = true;
                tempTs.units.Add(temp);
            });
            pauseButton.Visible = false;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if(pauseButton.Text == "пауза.")
            {
                pauseButton.Text = "продолжить.";

                re.Wait();
            }
            else if(pauseButton.Text == "продолжить.")
            {
                re = Task.Factory.StartNew(() =>
                {
                    tempTs.download(temp);
                    Console.WriteLine("дело сделано.");
                    temp.success = true;
                    tempTs.units.Add(temp);
                });
            }
        }
    }
}
