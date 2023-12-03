namespace TuyenSinh
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            insertToolStripMenuItem = new ToolStripMenuItem();
            candidateAToolStripMenuItem = new ToolStripMenuItem();
            candidateBToolStripMenuItem = new ToolStripMenuItem();
            candidateCToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            radioButton1 = new RadioButton();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { insertToolStripMenuItem, showToolStripMenuItem, searchToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // insertToolStripMenuItem
            // 
            insertToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { candidateAToolStripMenuItem, candidateBToolStripMenuItem, candidateCToolStripMenuItem });
            insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            insertToolStripMenuItem.Size = new Size(72, 29);
            insertToolStripMenuItem.Text = "Insert";
            // 
            // candidateAToolStripMenuItem
            // 
            candidateAToolStripMenuItem.Name = "candidateAToolStripMenuItem";
            candidateAToolStripMenuItem.Size = new Size(270, 34);
            candidateAToolStripMenuItem.Text = "Candidate A";
            candidateAToolStripMenuItem.Click += candidateAToolStripMenuItem_Click;
            // 
            // candidateBToolStripMenuItem
            // 
            candidateBToolStripMenuItem.Name = "candidateBToolStripMenuItem";
            candidateBToolStripMenuItem.Size = new Size(270, 34);
            candidateBToolStripMenuItem.Text = "Candidate B";
            // 
            // candidateCToolStripMenuItem
            // 
            candidateCToolStripMenuItem.Name = "candidateCToolStripMenuItem";
            candidateCToolStripMenuItem.Size = new Size(270, 34);
            candidateCToolStripMenuItem.Text = " Candidate C";
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(72, 29);
            showToolStripMenuItem.Text = "Show";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(80, 29);
            searchToolStripMenuItem.Text = "Search";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(55, 29);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(217, 166);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem candidateAToolStripMenuItem;
        private ToolStripMenuItem candidateBToolStripMenuItem;
        private ToolStripMenuItem candidateCToolStripMenuItem;
        private RadioButton radioButton1;
    }
}