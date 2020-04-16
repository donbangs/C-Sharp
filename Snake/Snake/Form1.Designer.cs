namespace Snake
{
    partial class Snake
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
            this.components = new System.ComponentModel.Container();
            this.pole_gry = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szybkoscGryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wolniejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szybciejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyniki = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.zerujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pole_gry
            // 
            this.pole_gry.BackColor = System.Drawing.SystemColors.Desktop;
            this.pole_gry.Location = new System.Drawing.Point(21, 65);
            this.pole_gry.Name = "pole_gry";
            this.pole_gry.Size = new System.Drawing.Size(280, 280);
            this.pole_gry.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauzaToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.szybkoscGryToolStripMenuItem,
            this.wyniki});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(421, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauzaToolStripMenuItem
            // 
            this.pauzaToolStripMenuItem.Name = "pauzaToolStripMenuItem";
            this.pauzaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.pauzaToolStripMenuItem.Text = "Pauza";
            this.pauzaToolStripMenuItem.Click += new System.EventHandler(this.pauzaToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // szybkoscGryToolStripMenuItem
            // 
            this.szybkoscGryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wolniejToolStripMenuItem,
            this.szybciejToolStripMenuItem});
            this.szybkoscGryToolStripMenuItem.Name = "szybkoscGryToolStripMenuItem";
            this.szybkoscGryToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.szybkoscGryToolStripMenuItem.Text = "Szybkosc gry";
            this.szybkoscGryToolStripMenuItem.Click += new System.EventHandler(this.szybkoscGryToolStripMenuItem_Click);
            // 
            // wolniejToolStripMenuItem
            // 
            this.wolniejToolStripMenuItem.Name = "wolniejToolStripMenuItem";
            this.wolniejToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.wolniejToolStripMenuItem.Text = "Wolniej";
            this.wolniejToolStripMenuItem.Click += new System.EventHandler(this.wolniejToolStripMenuItem_Click);
            // 
            // szybciejToolStripMenuItem
            // 
            this.szybciejToolStripMenuItem.Name = "szybciejToolStripMenuItem";
            this.szybciejToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.szybciejToolStripMenuItem.Text = "Szybciej";
            this.szybciejToolStripMenuItem.Click += new System.EventHandler(this.szybciejToolStripMenuItem_Click);
            // 
            // wyniki
            // 
            this.wyniki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zerujToolStripMenuItem});
            this.wyniki.Name = "wyniki";
            this.wyniki.Size = new System.Drawing.Size(65, 24);
            this.wyniki.Text = "Wyniki";
            this.wyniki.Click += new System.EventHandler(this.wyniki_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // zerujToolStripMenuItem
            // 
            this.zerujToolStripMenuItem.Name = "zerujToolStripMenuItem";
            this.zerujToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.zerujToolStripMenuItem.Text = "Zeruj";
            this.zerujToolStripMenuItem.Click += new System.EventHandler(this.zerujToolStripMenuItem_Click);
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pole_gry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Snake";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pole_gry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szybkoscGryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wolniejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szybciejToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem wyniki;
        private System.Windows.Forms.ToolStripMenuItem zerujToolStripMenuItem;
    }
}

