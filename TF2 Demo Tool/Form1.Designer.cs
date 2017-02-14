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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDemoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTicks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilePathDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonChooseFolder
            // 
            this.ButtonChooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonChooseFolder.Location = new System.Drawing.Point(556, 358);
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
            this.richTextBox1.Location = new System.Drawing.Point(12, 193);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(538, 322);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // ButtonRemoveEmpty
            // 
            this.ButtonRemoveEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemoveEmpty.Enabled = false;
            this.ButtonRemoveEmpty.Location = new System.Drawing.Point(556, 431);
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
            this.ButtonMoveBookmarks.Location = new System.Drawing.Point(556, 460);
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
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
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
            this.ButtonMoveBookmarksToNewFolder.Location = new System.Drawing.Point(556, 489);
            this.ButtonMoveBookmarksToNewFolder.Name = "ButtonMoveBookmarksToNewFolder";
            this.ButtonMoveBookmarksToNewFolder.Size = new System.Drawing.Size(214, 23);
            this.ButtonMoveBookmarksToNewFolder.TabIndex = 8;
            this.ButtonMoveBookmarksToNewFolder.Text = "Move bookmarked demos";
            this.ButtonMoveBookmarksToNewFolder.UseVisualStyleBackColor = true;
            this.ButtonMoveBookmarksToNewFolder.Click += new System.EventHandler(this.ButtonMoveBookmarksToNewFolder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDemoName,
            this.ColumnMapName,
            this.ColumnTicks,
            this.ColumnPlayerName,
            this.ColumnServerName,
            this.ColumnFilePathDem});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ColumnDemoName
            // 
            this.ColumnDemoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDemoName.FillWeight = 150F;
            this.ColumnDemoName.HeaderText = "Demo name";
            this.ColumnDemoName.Name = "ColumnDemoName";
            this.ColumnDemoName.ReadOnly = true;
            // 
            // ColumnMapName
            // 
            this.ColumnMapName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMapName.HeaderText = "Map name";
            this.ColumnMapName.Name = "ColumnMapName";
            this.ColumnMapName.ReadOnly = true;
            // 
            // ColumnTicks
            // 
            this.ColumnTicks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTicks.HeaderText = "Ticks";
            this.ColumnTicks.Name = "ColumnTicks";
            this.ColumnTicks.ReadOnly = true;
            // 
            // ColumnPlayerName
            // 
            this.ColumnPlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPlayerName.HeaderText = "Player name";
            this.ColumnPlayerName.Name = "ColumnPlayerName";
            this.ColumnPlayerName.ReadOnly = true;
            // 
            // ColumnServerName
            // 
            this.ColumnServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnServerName.HeaderText = "Server name or I.P.";
            this.ColumnServerName.Name = "ColumnServerName";
            this.ColumnServerName.ReadOnly = true;
            // 
            // ColumnFilePathDem
            // 
            this.ColumnFilePathDem.HeaderText = "File path to .dem";
            this.ColumnFilePathDem.Name = "ColumnFilePathDem";
            this.ColumnFilePathDem.ReadOnly = true;
            this.ColumnFilePathDem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonMoveBookmarksToNewFolder);
            this.Controls.Add(this.ButtonMoveBookmarks);
            this.Controls.Add(this.ButtonRemoveEmpty);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ButtonChooseFolder);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(380, 397);
            this.Name = "Form1";
            this.Text = "Stepanex\'s tool to organize demos v3.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonChooseFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDemoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTicks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilePathDem;
    }
}

