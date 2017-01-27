namespace TF2_Demo_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonChooseFolder = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonRemoveEmpty = new System.Windows.Forms.Button();
            this.ButtonMoveBookmarks = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDefaultFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.resetDefaultFoldersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDefaultmoveToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonMoveBookmarksToNewFolder = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonChooseFolder
            // 
            this.ButtonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChooseFolder.Location = new System.Drawing.Point(403, 191);
            this.ButtonChooseFolder.Name = "ButtonChooseFolder";
            this.ButtonChooseFolder.Size = new System.Drawing.Size(214, 23);
            this.ButtonChooseFolder.TabIndex = 2;
            this.ButtonChooseFolder.Text = "Choose folder with demos";
            this.ButtonChooseFolder.UseVisualStyleBackColor = true;
            this.ButtonChooseFolder.Click += new System.EventHandler(this.ButtonChooseFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(382, 322);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(403, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 158);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ButtonRemoveEmpty
            // 
            this.ButtonRemoveEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemoveEmpty.Enabled = false;
            this.ButtonRemoveEmpty.Location = new System.Drawing.Point(403, 264);
            this.ButtonRemoveEmpty.Name = "ButtonRemoveEmpty";
            this.ButtonRemoveEmpty.Size = new System.Drawing.Size(214, 23);
            this.ButtonRemoveEmpty.TabIndex = 5;
            this.ButtonRemoveEmpty.Text = "Remove empty demos";
            this.ButtonRemoveEmpty.UseVisualStyleBackColor = true;
            this.ButtonRemoveEmpty.Click += new System.EventHandler(this.ButtonRemoveEmpty_Click);
            // 
            // ButtonMoveBookmarks
            // 
            this.ButtonMoveBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMoveBookmarks.Enabled = false;
            this.ButtonMoveBookmarks.Location = new System.Drawing.Point(403, 293);
            this.ButtonMoveBookmarks.Name = "ButtonMoveBookmarks";
            this.ButtonMoveBookmarks.Size = new System.Drawing.Size(214, 23);
            this.ButtonMoveBookmarks.TabIndex = 6;
            this.ButtonMoveBookmarks.Text = "Move bookmarked demos to saved folder";
            this.ButtonMoveBookmarks.UseVisualStyleBackColor = true;
            this.ButtonMoveBookmarks.Click += new System.EventHandler(this.ButtonMoveBookmarks_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProfileToolStripMenuItem,
            this.chooseProfileToolStripMenuItem,
            this.resetDefaultFoldersToolStripMenuItem,
            this.resetDefaultFoldersToolStripMenuItem1,
            this.resetDefaultmoveToFolderToolStripMenuItem});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.profileToolStripMenuItem.Text = "File";
            // 
            // newProfileToolStripMenuItem
            // 
            this.newProfileToolStripMenuItem.Name = "newProfileToolStripMenuItem";
            this.newProfileToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.newProfileToolStripMenuItem.Text = "Choose default folder with demos";
            this.newProfileToolStripMenuItem.Click += new System.EventHandler(this.DemoFolderToolStripMenuItem_Click);
            // 
            // chooseProfileToolStripMenuItem
            // 
            this.chooseProfileToolStripMenuItem.Name = "chooseProfileToolStripMenuItem";
            this.chooseProfileToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.chooseProfileToolStripMenuItem.Text = "Choose default \"move to\" folder";
            this.chooseProfileToolStripMenuItem.Click += new System.EventHandler(this.MNoveToStripMenuItem_Click);
            // 
            // resetDefaultFoldersToolStripMenuItem
            // 
            this.resetDefaultFoldersToolStripMenuItem.Name = "resetDefaultFoldersToolStripMenuItem";
            this.resetDefaultFoldersToolStripMenuItem.Size = new System.Drawing.Size(250, 6);
            // 
            // resetDefaultFoldersToolStripMenuItem1
            // 
            this.resetDefaultFoldersToolStripMenuItem1.Name = "resetDefaultFoldersToolStripMenuItem1";
            this.resetDefaultFoldersToolStripMenuItem1.Size = new System.Drawing.Size(253, 22);
            this.resetDefaultFoldersToolStripMenuItem1.Text = "Reset default folder with demos";
            this.resetDefaultFoldersToolStripMenuItem1.Click += new System.EventHandler(this.resetDefaultFoldersToolStripMenuItem1_Click);
            // 
            // resetDefaultmoveToFolderToolStripMenuItem
            // 
            this.resetDefaultmoveToFolderToolStripMenuItem.Name = "resetDefaultmoveToFolderToolStripMenuItem";
            this.resetDefaultmoveToFolderToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.resetDefaultmoveToFolderToolStripMenuItem.Text = "Reset default \"move to\" folder";
            this.resetDefaultmoveToFolderToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultmoveToFolderToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ButtonMoveBookmarksToNewFolder
            // 
            this.ButtonMoveBookmarksToNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMoveBookmarksToNewFolder.Enabled = false;
            this.ButtonMoveBookmarksToNewFolder.Location = new System.Drawing.Point(403, 322);
            this.ButtonMoveBookmarksToNewFolder.Name = "ButtonMoveBookmarksToNewFolder";
            this.ButtonMoveBookmarksToNewFolder.Size = new System.Drawing.Size(214, 23);
            this.ButtonMoveBookmarksToNewFolder.TabIndex = 8;
            this.ButtonMoveBookmarksToNewFolder.Text = "Move bookmarked demos";
            this.ButtonMoveBookmarksToNewFolder.UseVisualStyleBackColor = true;
            this.ButtonMoveBookmarksToNewFolder.Click += new System.EventHandler(this.ButtonMoveBookmarksToNewFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 364);
            this.Controls.Add(this.ButtonMoveBookmarksToNewFolder);
            this.Controls.Add(this.ButtonMoveBookmarks);
            this.Controls.Add(this.ButtonRemoveEmpty);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ButtonChooseFolder);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(385, 300);
            this.Name = "Form1";
            this.Text = "Stepanex\'s tool to organize demos v2.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonChooseFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonRemoveEmpty;
        private System.Windows.Forms.Button ButtonMoveBookmarks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultFoldersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultmoveToFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator resetDefaultFoldersToolStripMenuItem;
        private System.Windows.Forms.Button ButtonMoveBookmarksToNewFolder;
    }
}

