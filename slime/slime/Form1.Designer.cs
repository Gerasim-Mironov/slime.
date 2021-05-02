namespace slime
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadButton = new System.Windows.Forms.Button();
            this.journalButton = new System.Windows.Forms.Button();
            this.controlsButton = new System.Windows.Forms.Button();
            this.tagsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadButton.Location = new System.Drawing.Point(134, 110);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(101, 28);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "скачать файл.";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // journalButton
            // 
            this.journalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.journalButton.Location = new System.Drawing.Point(574, 110);
            this.journalButton.Name = "journalButton";
            this.journalButton.Size = new System.Drawing.Size(101, 28);
            this.journalButton.TabIndex = 1;
            this.journalButton.Text = "загрузки.";
            this.journalButton.UseVisualStyleBackColor = true;
            this.journalButton.Click += new System.EventHandler(this.journalButton_Click);
            // 
            // controlsButton
            // 
            this.controlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controlsButton.Location = new System.Drawing.Point(134, 339);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(101, 28);
            this.controlsButton.TabIndex = 2;
            this.controlsButton.Text = "управление.";
            this.controlsButton.UseVisualStyleBackColor = true;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // tagsButton
            // 
            this.tagsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tagsButton.Location = new System.Drawing.Point(574, 339);
            this.tagsButton.Name = "tagsButton";
            this.tagsButton.Size = new System.Drawing.Size(101, 28);
            this.tagsButton.TabIndex = 3;
            this.tagsButton.Text = "идти по следам.";
            this.tagsButton.UseVisualStyleBackColor = true;
            this.tagsButton.Click += new System.EventHandler(this.tagsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tagsButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.journalButton);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "slime.";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button journalButton;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button tagsButton;
    }
}

