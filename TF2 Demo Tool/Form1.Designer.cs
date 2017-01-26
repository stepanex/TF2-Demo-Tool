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
            this.SuspendLayout();
            // 
            // ButtonChooseFolder
            // 
            this.ButtonChooseFolder.Location = new System.Drawing.Point(271, 12);
            this.ButtonChooseFolder.Name = "ButtonChooseFolder";
            this.ButtonChooseFolder.Size = new System.Drawing.Size(176, 23);
            this.ButtonChooseFolder.TabIndex = 2;
            this.ButtonChooseFolder.Text = "Choose folder with the demos";
            this.ButtonChooseFolder.UseVisualStyleBackColor = true;
            this.ButtonChooseFolder.Click += new System.EventHandler(this.ButtonChooseFolder_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 191);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 301);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 173);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ButtonRemoveEmpty
            // 
            this.ButtonRemoveEmpty.Enabled = false;
            this.ButtonRemoveEmpty.Location = new System.Drawing.Point(271, 107);
            this.ButtonRemoveEmpty.Name = "ButtonRemoveEmpty";
            this.ButtonRemoveEmpty.Size = new System.Drawing.Size(176, 23);
            this.ButtonRemoveEmpty.TabIndex = 5;
            this.ButtonRemoveEmpty.Text = "Remove empty demos";
            this.ButtonRemoveEmpty.UseVisualStyleBackColor = true;
            this.ButtonRemoveEmpty.Click += new System.EventHandler(this.ButtonRemoveEmpty_Click);
            // 
            // ButtonMoveBookmarks
            // 
            this.ButtonMoveBookmarks.Enabled = false;
            this.ButtonMoveBookmarks.Location = new System.Drawing.Point(271, 147);
            this.ButtonMoveBookmarks.Name = "ButtonMoveBookmarks";
            this.ButtonMoveBookmarks.Size = new System.Drawing.Size(176, 23);
            this.ButtonMoveBookmarks.TabIndex = 6;
            this.ButtonMoveBookmarks.Text = "Move bookmarked demos";
            this.ButtonMoveBookmarks.UseVisualStyleBackColor = true;
            this.ButtonMoveBookmarks.Click += new System.EventHandler(this.ButtonMoveBookmarks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 504);
            this.Controls.Add(this.ButtonMoveBookmarks);
            this.Controls.Add(this.ButtonRemoveEmpty);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ButtonChooseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stepanex\'s tool to organize demos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonChooseFolder;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonRemoveEmpty;
        private System.Windows.Forms.Button ButtonMoveBookmarks;
    }
}

