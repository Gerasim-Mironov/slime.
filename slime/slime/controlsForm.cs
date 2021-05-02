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

namespace slime
{
    public partial class controlsForm : Form
    {
        public telescope tempTs = new telescope();
        private downloadUnit tempUnit;

        private FileInfo vh;

        private bool renameConfirm = false;
        private bool moveConfirm = false;

        private string exclusiveUnitSavePath = string.Empty;
        public controlsForm()
        {
            InitializeComponent();

            moveLabel.Visible = false;
            moveTextBox.Visible = false;
        }

        private void controlsForm_Load(object sender, EventArgs e)
        {
            fileNamesComboBox.SelectedValueChanged += seizeFileInfo;

            foreach(downloadUnit unit in tempTs.units)
            {
                fileNamesComboBox.Items.Add($"{unit.savePath}\\{unit.fileName}");
            }
            if (fileNamesComboBox.Items.Count >= 1)
            {
                fileNamesComboBox.SelectedIndex = 0;
            }
        }

        private void seizeFileInfo(object sender, EventArgs e)
        {
            vh = new FileInfo(fileNamesComboBox.Text);

            #region newUnit
            string url = tempTs.units[fileNamesComboBox.SelectedIndex].url;
            string tempPath = string.Empty;
            string savePath = tempTs.units[fileNamesComboBox.SelectedIndex].savePath;
            string fileName = tempTs.units[fileNamesComboBox.SelectedIndex].fileName;
            List<string> tags = tempTs.units[fileNamesComboBox.SelectedIndex].tags;
            DateTime dv = tempTs.units[fileNamesComboBox.SelectedIndex].unl;
            bool? success = tempTs.units[fileNamesComboBox.SelectedIndex].success;
            #endregion

            tempUnit = new downloadUnit(url, tempPath, fileName, tags, dv, success);
            this.exclusiveUnitSavePath = savePath;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("действительно удалить?.", "голос.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                File.Delete(vh.FullName);
                tempTs.units.RemoveAt(fileNamesComboBox.SelectedIndex);

                MessageBox.Show("дело сделано.", "голос.");

                fileNamesComboBox.Items.Clear();
                foreach (downloadUnit unit in tempTs.units)
                {
                    fileNamesComboBox.Items.Add($"{unit.savePath}\\{unit.fileName}");
                }
            }
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            if(moveConfirm == false)
            {
                moveLabel.Visible = true;
                moveLabel.Text = "новое место жительства.";

                moveTextBox.Visible = true;

                moveConfirm = true;
            }
            else
            {
                if(moveTextBox.Text != string.Empty)
                {
                    File.Move(vh.FullName, moveTextBox.Text + "\\" + vh.Name);

                    tempUnit.savePath = moveTextBox.Text;
                    tempTs.units[fileNamesComboBox.SelectedIndex + 1] = tempUnit;

                    moveLabel.Visible = false;

                    moveTextBox.Visible = false;
                    moveTextBox.Text = string.Empty;

                    moveConfirm = false;
                }
                else
                {
                    MessageBox.Show("ты не ввёл текст.");
                }
            }

            fileNamesComboBox.Items.Clear();
            foreach (downloadUnit unit in tempTs.units)
            {
                fileNamesComboBox.Items.Add($"{unit.savePath}\\{unit.fileName}");
            }
            fileNamesComboBox.SelectedIndex = 0;
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            if (renameConfirm == false)
            {
                moveLabel.Visible = true;
                moveLabel.Text = "новое имя.";

                moveTextBox.Visible = true;

                renameConfirm = true;
            }
            else
            {
                if (moveTextBox.Text != string.Empty)
                {
                    string tempName = moveTextBox.Text + vh.Extension;
                    string newName = vh.DirectoryName + "\\" + tempName;

                    File.Move(vh.FullName, newName);

                    tempUnit.savePath = this.exclusiveUnitSavePath;
                    tempUnit.fileName = tempName;
                    tempTs.units[fileNamesComboBox.SelectedIndex + 1] = tempUnit;

                    moveLabel.Visible = false;

                    moveTextBox.Visible = false;
                    moveTextBox.Text = string.Empty;

                    moveConfirm = false;
                }
                else
                {
                    MessageBox.Show("ты не ввёл текст.");
                }
            }

            fileNamesComboBox.Items.Clear();
            foreach (downloadUnit unit in tempTs.units)
            {
                fileNamesComboBox.Items.Add($"{unit.savePath}\\{unit.fileName}");
            }
            fileNamesComboBox.SelectedIndex = 0;
        }
    }
}
