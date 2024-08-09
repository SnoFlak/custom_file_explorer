namespace CustomFileExplorer
{
    partial class Form1
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
            this.currentDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.treeDirs = new System.Windows.Forms.TreeView();
            this.goToParentDirectoryBtn = new System.Windows.Forms.Button();
            this.newFolderBtn = new System.Windows.Forms.Button();
            this.newFileBtn = new System.Windows.Forms.Button();
            this.folderViewer = new System.Windows.Forms.ListView();
            this.quickDirs = new System.Windows.Forms.ListView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.Drives = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpaceRemaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // currentDirectoryTextBox
            // 
            this.currentDirectoryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentDirectoryTextBox.Location = new System.Drawing.Point(38, 12);
            this.currentDirectoryTextBox.Name = "currentDirectoryTextBox";
            this.currentDirectoryTextBox.Size = new System.Drawing.Size(698, 20);
            this.currentDirectoryTextBox.TabIndex = 0;
            // 
            // treeDirs
            // 
            this.treeDirs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeDirs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeDirs.Location = new System.Drawing.Point(12, 150);
            this.treeDirs.Name = "treeDirs";
            this.treeDirs.Size = new System.Drawing.Size(184, 288);
            this.treeDirs.TabIndex = 1;
            // 
            // goToParentDirectoryBtn
            // 
            this.goToParentDirectoryBtn.Location = new System.Drawing.Point(12, 12);
            this.goToParentDirectoryBtn.Name = "goToParentDirectoryBtn";
            this.goToParentDirectoryBtn.Size = new System.Drawing.Size(20, 20);
            this.goToParentDirectoryBtn.TabIndex = 2;
            this.goToParentDirectoryBtn.Text = "up";
            this.goToParentDirectoryBtn.UseVisualStyleBackColor = true;
            // 
            // newFolderBtn
            // 
            this.newFolderBtn.Location = new System.Drawing.Point(742, 12);
            this.newFolderBtn.Name = "newFolderBtn";
            this.newFolderBtn.Size = new System.Drawing.Size(20, 20);
            this.newFolderBtn.TabIndex = 4;
            this.newFolderBtn.Text = "New Folder";
            this.newFolderBtn.UseVisualStyleBackColor = true;
            // 
            // newFileBtn
            // 
            this.newFileBtn.Location = new System.Drawing.Point(768, 12);
            this.newFileBtn.Name = "newFileBtn";
            this.newFileBtn.Size = new System.Drawing.Size(20, 20);
            this.newFileBtn.TabIndex = 5;
            this.newFileBtn.Text = "New File";
            this.newFileBtn.UseVisualStyleBackColor = true;
            // 
            // folderViewer
            // 
            this.folderViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.folderViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderViewer.HideSelection = false;
            this.folderViewer.Location = new System.Drawing.Point(202, 42);
            this.folderViewer.Name = "folderViewer";
            this.folderViewer.Size = new System.Drawing.Size(586, 396);
            this.folderViewer.TabIndex = 8;
            this.folderViewer.UseCompatibleStateImageBehavior = false;
            // 
            // quickDirs
            // 
            this.quickDirs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quickDirs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quickDirs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drives,
            this.SpaceRemaining});
            this.quickDirs.Cursor = System.Windows.Forms.Cursors.Default;
            this.quickDirs.HideSelection = false;
            this.quickDirs.Location = new System.Drawing.Point(12, 42);
            this.quickDirs.Name = "quickDirs";
            this.quickDirs.Size = new System.Drawing.Size(184, 102);
            this.quickDirs.TabIndex = 9;
            this.quickDirs.UseCompatibleStateImageBehavior = false;
            this.quickDirs.SelectedIndexChanged += new System.EventHandler(this.quickDirs_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(716, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(20, 20);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // Drives
            // 
            this.Drives.Text = "Drives";
            // 
            // SpaceRemaining
            // 
            this.SpaceRemaining.Text = "Space Remaining";
            this.SpaceRemaining.Width = 124;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.quickDirs);
            this.Controls.Add(this.folderViewer);
            this.Controls.Add(this.newFileBtn);
            this.Controls.Add(this.newFolderBtn);
            this.Controls.Add(this.goToParentDirectoryBtn);
            this.Controls.Add(this.treeDirs);
            this.Controls.Add(this.currentDirectoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentDirectoryTextBox;
        private System.Windows.Forms.TreeView treeDirs;
        private System.Windows.Forms.Button goToParentDirectoryBtn;
        private System.Windows.Forms.Button newFolderBtn;
        private System.Windows.Forms.Button newFileBtn;
        private System.Windows.Forms.ListView folderViewer;
        private System.Windows.Forms.ListView quickDirs;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColumnHeader Drives;
        private System.Windows.Forms.ColumnHeader SpaceRemaining;
    }
}

