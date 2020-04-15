namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pole = new System.Windows.Forms.Panel();
            this.Bombki = new System.Windows.Forms.CheckBox();
            this.Swiatełka = new System.Windows.Forms.CheckBox();
            this.Prezenty = new System.Windows.Forms.CheckBox();
            this.Gwiazda = new System.Windows.Forms.CheckBox();
            this.Łancuchy = new System.Windows.Forms.CheckBox();
            this.Melodyjka = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rysuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pole
            // 
            this.pole.Location = new System.Drawing.Point(12, 17);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(376, 421);
            this.pole.TabIndex = 1;
            // 
            // Bombki
            // 
            this.Bombki.AutoSize = true;
            this.Bombki.Location = new System.Drawing.Point(433, 77);
            this.Bombki.Name = "Bombki";
            this.Bombki.Size = new System.Drawing.Size(76, 21);
            this.Bombki.TabIndex = 2;
            this.Bombki.Text = "Bombki";
            this.Bombki.UseVisualStyleBackColor = true;
            // 
            // Swiatełka
            // 
            this.Swiatełka.AutoSize = true;
            this.Swiatełka.Location = new System.Drawing.Point(433, 111);
            this.Swiatełka.Name = "Swiatełka";
            this.Swiatełka.Size = new System.Drawing.Size(89, 21);
            this.Swiatełka.TabIndex = 3;
            this.Swiatełka.Text = "Swiatełka";
            this.Swiatełka.UseVisualStyleBackColor = true;
            // 
            // Prezenty
            // 
            this.Prezenty.AutoSize = true;
            this.Prezenty.Location = new System.Drawing.Point(433, 198);
            this.Prezenty.Name = "Prezenty";
            this.Prezenty.Size = new System.Drawing.Size(86, 21);
            this.Prezenty.TabIndex = 4;
            this.Prezenty.Text = "Prezenty";
            this.Prezenty.UseVisualStyleBackColor = true;
            // 
            // Gwiazda
            // 
            this.Gwiazda.AutoSize = true;
            this.Gwiazda.Location = new System.Drawing.Point(433, 152);
            this.Gwiazda.Name = "Gwiazda";
            this.Gwiazda.Size = new System.Drawing.Size(84, 21);
            this.Gwiazda.TabIndex = 4;
            this.Gwiazda.Text = "Gwiazda";
            this.Gwiazda.UseVisualStyleBackColor = true;
            // 
            // Łancuchy
            // 
            this.Łancuchy.AutoSize = true;
            this.Łancuchy.Location = new System.Drawing.Point(433, 242);
            this.Łancuchy.Name = "Łancuchy";
            this.Łancuchy.Size = new System.Drawing.Size(91, 21);
            this.Łancuchy.TabIndex = 5;
            this.Łancuchy.Text = "Łancuchy";
            this.Łancuchy.UseVisualStyleBackColor = true;
            // 
            // Melodyjka
            // 
            this.Melodyjka.AutoSize = true;
            this.Melodyjka.Location = new System.Drawing.Point(433, 269);
            this.Melodyjka.Name = "Melodyjka";
            this.Melodyjka.Size = new System.Drawing.Size(93, 21);
            this.Melodyjka.TabIndex = 6;
            this.Melodyjka.Text = "Melodyjka";
            this.Melodyjka.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Melodyjka);
            this.Controls.Add(this.Łancuchy);
            this.Controls.Add(this.Gwiazda);
            this.Controls.Add(this.Prezenty);
            this.Controls.Add(this.Swiatełka);
            this.Controls.Add(this.Bombki);
            this.Controls.Add(this.pole);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Choinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pole;
        private System.Windows.Forms.CheckBox Bombki;
        private System.Windows.Forms.CheckBox Swiatełka;
        private System.Windows.Forms.CheckBox Prezenty;
        private System.Windows.Forms.CheckBox Gwiazda;
        private System.Windows.Forms.CheckBox Łancuchy;
        private System.Windows.Forms.CheckBox Melodyjka;
        private System.Windows.Forms.Timer timer1;
    }
}

