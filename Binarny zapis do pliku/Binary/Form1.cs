using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Binary
{
    public partial class Form1 : Form
    {
        public long x;
        Binary note;
        public int iloscOsob;
        Binary zapisz;
        public string sciezka;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

        }

        private void otworzToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
          
            openFileDialog1.ShowDialog();
            sciezka = openFileDialog1.FileName;


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            note = new Binary(t1.Text, Convert.ToDateTime(dateTimePicker1.Text), double.Parse(t3.Text), char.Parse(t4.Text));
            lb1.Items.Add(note);


        }

        private void zapisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(sciezka, FileMode.Append)))
            {
                writer.Write( lb1.Items.Count);
            }

            foreach (var item in lb1.Items)
            {
                 zapisz = (Binary)item;
                 zapisz.Zapis(sciezka);
                 
            }

            
        }

        private void odczytToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(sciezka, FileMode.Open)))
            {
                
                iloscOsob = reader.ReadInt32();
                x = reader.BaseStream.Seek(0, SeekOrigin.Current);
            }
            
            Binary odczyt = new Binary();
            odczyt.x = x;
            for (int x = 0; x <iloscOsob; x++)
            {
                odczyt.Odczyt(sciezka);
                lb1.Items.Add(odczyt);
            }
            odczyt.x = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }
    }
}
