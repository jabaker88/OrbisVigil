namespace OrbitVigilSolution
{
    partial class OrbisVigilMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.hardwareTabPage = new System.Windows.Forms.TabPage();
            this.outputTabPage = new System.Windows.Forms.TabPage();
            this.OutputConsole = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.mainFormTabControl.SuspendLayout();
            this.outputTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.hardwareTabPage);
            this.mainFormTabControl.Controls.Add(this.outputTabPage);
            this.mainFormTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFormTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(609, 314);
            this.mainFormTabControl.TabIndex = 1;
            // 
            // hardwareTabPage
            // 
            this.hardwareTabPage.Location = new System.Drawing.Point(4, 22);
            this.hardwareTabPage.Name = "hardwareTabPage";
            this.hardwareTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hardwareTabPage.Size = new System.Drawing.Size(601, 288);
            this.hardwareTabPage.TabIndex = 0;
            this.hardwareTabPage.Text = "Hardware";
            this.hardwareTabPage.UseVisualStyleBackColor = true;
            // 
            // outputTabPage
            // 
            this.outputTabPage.Controls.Add(this.OutputConsole);
            this.outputTabPage.Location = new System.Drawing.Point(4, 22);
            this.outputTabPage.Name = "outputTabPage";
            this.outputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outputTabPage.Size = new System.Drawing.Size(601, 288);
            this.outputTabPage.TabIndex = 1;
            this.outputTabPage.Text = "Console Output";
            this.outputTabPage.UseVisualStyleBackColor = true;
            // 
            // OutputConsole
            // 
            this.OutputConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputConsole.Location = new System.Drawing.Point(3, 3);
            this.OutputConsole.Multiline = true;
            this.OutputConsole.Name = "OutputConsole";
            this.OutputConsole.Size = new System.Drawing.Size(595, 282);
            this.OutputConsole.TabIndex = 0;
            // 
            // OrbisVigilMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 338);
            this.Controls.Add(this.mainFormTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrbisVigilMainForm";
            this.Text = "Orbis Vigil";
            this.Load += new System.EventHandler(this.OrbisVigilMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainFormTabControl.ResumeLayout(false);
            this.outputTabPage.ResumeLayout(false);
            this.outputTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage hardwareTabPage;
        private System.Windows.Forms.TabPage outputTabPage;
        private System.Windows.Forms.TextBox OutputConsole;
    }
}

