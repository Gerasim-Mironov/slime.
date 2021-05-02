namespace slime
{
    partial class controlsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlsForm));
            this.fileNamesComboBox = new System.Windows.Forms.ComboBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.moveTextBox = new System.Windows.Forms.TextBox();
            this.moveLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNamesComboBox
            // 
            this.fileNamesComboBox.FormattingEnabled = true;
            this.fileNamesComboBox.Location = new System.Drawing.Point(76, 46);
            this.fileNamesComboBox.Name = "fileNamesComboBox";
            this.fileNamesComboBox.Size = new System.Drawing.Size(273, 21);
            this.fileNamesComboBox.TabIndex = 0;
            // 
            // moveButton
            // 
            this.moveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveButton.Location = new System.Drawing.Point(76, 362);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 1;
            this.moveButton.Text = "сместить.";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.renameButton.Location = new System.Drawing.Point(359, 362);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(99, 23);
            this.renameButton.TabIndex = 2;
            this.renameButton.Text = "переименовать.";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(625, 362);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "уничтожить.";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // moveTextBox
            // 
            this.moveTextBox.Location = new System.Drawing.Point(76, 199);
            this.moveTextBox.Name = "moveTextBox";
            this.moveTextBox.Size = new System.Drawing.Size(447, 20);
            this.moveTextBox.TabIndex = 4;
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(76, 168);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(35, 13);
            this.moveLabel.TabIndex = 5;
            this.moveLabel.Text = "label1";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(76, 13);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(67, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "путь файла.";
            // 
            // controlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.moveTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.fileNamesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "controlsForm";
            this.Text = "управление.";
            this.Load += new System.EventHandler(this.controlsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fileNamesComboBox;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox moveTextBox;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Label fileNameLabel;
    }
}