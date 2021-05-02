namespace slime
{
    partial class journalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(journalForm));
            this.successListBox = new System.Windows.Forms.ListBox();
            this.failureListBox = new System.Windows.Forms.ListBox();
            this.succsessLabel = new System.Windows.Forms.Label();
            this.failureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // successListBox
            // 
            this.successListBox.FormattingEnabled = true;
            this.successListBox.Location = new System.Drawing.Point(12, 38);
            this.successListBox.Name = "successListBox";
            this.successListBox.Size = new System.Drawing.Size(375, 368);
            this.successListBox.TabIndex = 0;
            // 
            // failureListBox
            // 
            this.failureListBox.FormattingEnabled = true;
            this.failureListBox.Location = new System.Drawing.Point(413, 38);
            this.failureListBox.Name = "failureListBox";
            this.failureListBox.Size = new System.Drawing.Size(375, 368);
            this.failureListBox.TabIndex = 1;
            // 
            // succsessLabel
            // 
            this.succsessLabel.AutoSize = true;
            this.succsessLabel.Location = new System.Drawing.Point(13, 19);
            this.succsessLabel.Name = "succsessLabel";
            this.succsessLabel.Size = new System.Drawing.Size(53, 13);
            this.succsessLabel.TabIndex = 2;
            this.succsessLabel.Text = "успешно:";
            // 
            // failureLabel
            // 
            this.failureLabel.AutoSize = true;
            this.failureLabel.Location = new System.Drawing.Point(410, 19);
            this.failureLabel.Name = "failureLabel";
            this.failureLabel.Size = new System.Drawing.Size(64, 13);
            this.failureLabel.TabIndex = 3;
            this.failureLabel.Text = "провально:";
            // 
            // journalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.failureLabel);
            this.Controls.Add(this.succsessLabel);
            this.Controls.Add(this.failureListBox);
            this.Controls.Add(this.successListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "journalForm";
            this.Text = "журнал загрузок.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox successListBox;
        public System.Windows.Forms.ListBox failureListBox;
        private System.Windows.Forms.Label succsessLabel;
        private System.Windows.Forms.Label failureLabel;
    }
}