using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        Plik note;
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


            Tprzegladaj.Text = openFileDialog1.FileName;
            note = new Plik(openFileDialog1.FileName);

        }

        private void Bprzegladaj_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void Botworz_Click(object sender, EventArgs e)
        {
            if (ch1.Checked && !ch2.Checked)
            {

                Ttext.Text=note.dekompres();
            }
            else if (ch2.Checked && !ch1.Checked)
            {
                Ttext.Text=note.deszyfruj();
                
            }
            else if (ch2.Checked && ch1.Checked)
            {
                Ttext.Text = note.DeszyfDekomp();
            }
            else
            {
                Ttext.Text= note.odczyt();

            }

            





        }


        private void Bzapis_Click(object sender, EventArgs e)
        {

            if (ch1.Checked && !ch2.Checked)
            {
                note.kompres(Ttext.Text);
            }
            else if (ch2.Checked && !ch1.Checked)
            {
                
                note.szyfruj(Ttext.Text);
            }
            else if (ch2.Checked && ch1.Checked)
            {
                note.SzyfKomp(Ttext.Text);
             }
            else
            {
                note.zapis(Ttext.Text);

            }

        }
    }
}







    
