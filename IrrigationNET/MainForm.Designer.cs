namespace IrrigationNET
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainToolBar = new System.Windows.Forms.ToolStrip();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.TsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).BeginInit();
            this.MainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmFile});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // MainToolBar
            // 
            this.MainToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolBar.Location = new System.Drawing.Point(0, 24);
            this.MainToolBar.Name = "MainToolBar";
            this.MainToolBar.Size = new System.Drawing.Size(800, 25);
            this.MainToolBar.TabIndex = 1;
            this.MainToolBar.Text = "toolStrip1";
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.Location = new System.Drawing.Point(0, 428);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(800, 22);
            this.MainStatusBar.TabIndex = 2;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 49);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainContainer.Size = new System.Drawing.Size(800, 379);
            this.MainContainer.SplitterDistance = 179;
            this.MainContainer.TabIndex = 3;
            // 
            // TsmFile
            // 
            this.TsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiExitApp});
            this.TsmFile.Name = "TsmFile";
            this.TsmFile.Size = new System.Drawing.Size(37, 20);
            this.TsmFile.Text = "&File";
            // 
            // TsmiExitApp
            // 
            this.TsmiExitApp.Name = "TsmiExitApp";
            this.TsmiExitApp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.TsmiExitApp.Size = new System.Drawing.Size(180, 22);
            this.TsmiExitApp.Text = "E&xit";
            this.TsmiExitApp.Click += new System.EventHandler(this.TsmiExitApp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainContainer);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MainToolBar);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Irrigation.NET (Version 1.0.0.0-Beta)";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainContainer)).EndInit();
            this.MainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiExitApp;
        private System.Windows.Forms.ToolStrip MainToolBar;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.SplitContainer MainContainer;
    }
}

