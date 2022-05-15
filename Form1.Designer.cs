namespace FootbalClub
{
    partial class Start
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.krajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piłkarzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.krajeToolStripMenuItem,
            this.piłkarzeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 20);
            this.toolStripMenuItem1.Text = "Kluby piłkarskie";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // krajeToolStripMenuItem
            // 
            this.krajeToolStripMenuItem.Name = "krajeToolStripMenuItem";
            this.krajeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.krajeToolStripMenuItem.Text = "Kraje";
            this.krajeToolStripMenuItem.Click += new System.EventHandler(this.krajeToolStripMenuItem_Click);
            // 
            // piłkarzeToolStripMenuItem
            // 
            this.piłkarzeToolStripMenuItem.Name = "piłkarzeToolStripMenuItem";
            this.piłkarzeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.piłkarzeToolStripMenuItem.Text = "Piłkarze";
            this.piłkarzeToolStripMenuItem.Click += new System.EventHandler(this.piłkarzeToolStripMenuItem_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Footbal Clubs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem krajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piłkarzeToolStripMenuItem;
    }
}

