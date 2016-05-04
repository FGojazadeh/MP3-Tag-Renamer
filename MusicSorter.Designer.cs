namespace Renamer
{
    partial class MusicSorter
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
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.filesList = new System.Windows.Forms.ListView();
            this.Files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.convertButton = new System.Windows.Forms.Button();
            this.itemsCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderButton.Location = new System.Drawing.Point(272, 12);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(102, 23);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.Location = new System.Drawing.Point(272, 208);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 1;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyMusic;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 227);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(362, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 3;
            // 
            // filesList
            // 
            this.filesList.AllowDrop = true;
            this.filesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Files});
            this.filesList.Location = new System.Drawing.Point(12, 12);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(254, 209);
            this.filesList.TabIndex = 1;
            this.filesList.UseCompatibleStateImageBehavior = false;
            this.filesList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filesList_KeyDown);
            // 
            // Files
            // 
            this.Files.Text = "Files";
            this.Files.Width = 254;
            // 
            // convertButton
            // 
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Location = new System.Drawing.Point(272, 59);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(102, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // itemsCountLabel
            // 
            this.itemsCountLabel.AutoSize = true;
            this.itemsCountLabel.Location = new System.Drawing.Point(272, 208);
            this.itemsCountLabel.Name = "itemsCountLabel";
            this.itemsCountLabel.Size = new System.Drawing.Size(0, 13);
            this.itemsCountLabel.TabIndex = 6;
            // 
            // MusicSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.itemsCountLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.selectFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MusicSorter";
            this.Text = "Music Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView filesList;
        private System.Windows.Forms.ColumnHeader Files;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label itemsCountLabel;

    }
}

