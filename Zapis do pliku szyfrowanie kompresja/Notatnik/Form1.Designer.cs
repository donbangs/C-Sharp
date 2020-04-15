namespace Notatnik
{
    partial class Form1
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
            this.Tprzegladaj = new System.Windows.Forms.TextBox();
            this.Ttext = new System.Windows.Forms.TextBox();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.Bprzegladaj = new System.Windows.Forms.Button();
            this.Botworz = new System.Windows.Forms.Button();
            this.Bzapis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Tprzegladaj
            // 
            this.Tprzegladaj.Location = new System.Drawing.Point(16, 15);
            this.Tprzegladaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tprzegladaj.Name = "Tprzegladaj";
            this.Tprzegladaj.Size = new System.Drawing.Size(285, 22);
            this.Tprzegladaj.TabIndex = 0;
            // 
            // Ttext
            // 
            this.Ttext.Location = new System.Drawing.Point(16, 75);
            this.Ttext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ttext.Multiline = true;
            this.Ttext.Name = "Ttext";
            this.Ttext.Size = new System.Drawing.Size(623, 339);
            this.Ttext.TabIndex = 1;
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(16, 47);
            this.ch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(97, 21);
            this.ch1.TabIndex = 2;
            this.ch1.Text = "Kompresja";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Location = new System.Drawing.Point(196, 47);
            this.ch2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(106, 21);
            this.ch2.TabIndex = 3;
            this.ch2.Text = "Szyfrowanie";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // Bprzegladaj
            // 
            this.Bprzegladaj.Location = new System.Drawing.Point(324, 15);
            this.Bprzegladaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bprzegladaj.Name = "Bprzegladaj";
            this.Bprzegladaj.Size = new System.Drawing.Size(100, 28);
            this.Bprzegladaj.TabIndex = 4;
            this.Bprzegladaj.Text = "Przeglądaj";
            this.Bprzegladaj.UseVisualStyleBackColor = true;
            this.Bprzegladaj.Click += new System.EventHandler(this.Bprzegladaj_Click);
            // 
            // Botworz
            // 
            this.Botworz.Location = new System.Drawing.Point(432, 15);
            this.Botworz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Botworz.Name = "Botworz";
            this.Botworz.Size = new System.Drawing.Size(100, 28);
            this.Botworz.TabIndex = 5;
            this.Botworz.Text = "Otwórz";
            this.Botworz.UseVisualStyleBackColor = true;
            this.Botworz.Click += new System.EventHandler(this.Botworz_Click);
            // 
            // Bzapis
            // 
            this.Bzapis.Location = new System.Drawing.Point(540, 15);
            this.Bzapis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bzapis.Name = "Bzapis";
            this.Bzapis.Size = new System.Drawing.Size(100, 28);
            this.Bzapis.TabIndex = 6;
            this.Bzapis.Text = "Zapisz";
            this.Bzapis.UseVisualStyleBackColor = true;
            this.Bzapis.Click += new System.EventHandler(this.Bzapis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Bzapis);
            this.Controls.Add(this.Botworz);
            this.Controls.Add(this.Bprzegladaj);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.Ttext);
            this.Controls.Add(this.Tprzegladaj);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Super Notepad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tprzegladaj;
        private System.Windows.Forms.TextBox Ttext;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.Button Bprzegladaj;
        private System.Windows.Forms.Button Botworz;
        private System.Windows.Forms.Button Bzapis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

