using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        FileStream fs;
        RijndaelManaged Crypto = new RijndaelManaged();
        byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        private void buttonPrzeg_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void buttonOtw_Click(object sender, EventArgs e)
        {
            try
            {
                using (fs = new FileStream(textBoxSciezka.Text, FileMode.Open))
                {
                    StreamReader sr;
                    if (checkBoxSzyfr.Checked == true || checkBoxKompresja.Checked == true)
                    {
                        if (checkBoxSzyfr.Checked == true)
                        {

                            CryptoStream cs = new CryptoStream(fs, Crypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);
                            if(checkBoxKompresja.Checked == true)
                            {
                                GZipStream gZip = new GZipStream(cs, CompressionMode.Decompress);
                                sr = new StreamReader(gZip);
                                textBoxNotepad.Text = sr.ReadToEnd();
                                sr.Close();
                                gZip.Close();
                            }
                            else
                            {
                                sr = new StreamReader(cs);
                                textBoxNotepad.Text = sr.ReadToEnd();
                                sr.Close();
                            }
                            cs.Close();
                        }
                        else 
                        {
                            GZipStream gZip = new GZipStream(fs, CompressionMode.Decompress);
                            sr = new StreamReader(gZip);
                            textBoxNotepad.Text = sr.ReadToEnd();
                            sr.Close();
                            gZip.Close();
                        }

                    }
                    else
                    {
                        sr = new StreamReader(fs);
                        textBoxNotepad.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Niepoprawna ścieżka");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Pusta ścieżka");
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("Taki plik nie istnieje");
            }
            catch (InvalidDataException)
            {
                MessageBox.Show("Ten plik nie jest skompresowany");
            }
          catch (System.Security.Cryptography.CryptographicException)
            {
                MessageBox.Show("Ten plik nie jest zaszyfrowany");
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            try
            {
                using (fs = new FileStream(textBoxSciezka.Text, FileMode.Create))
                {
                    StreamWriter sw;

                    if (checkBoxSzyfr.Checked == true || checkBoxKompresja.Checked == true)
                    {
                        if (checkBoxSzyfr.Checked == true)
                        {
                            CryptoStream cs = new CryptoStream(fs, Crypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);
                            if (checkBoxKompresja.Checked == true)
                            {
                                GZipStream gZip = new GZipStream(cs, CompressionMode.Compress);
                                sw = new StreamWriter(gZip);
                                sw.Write(textBoxNotepad.Text);
                                sw.Close();
                                gZip.Close();
                            }
                            else
                            {
                                sw = new StreamWriter(cs);
                                sw.Write(textBoxNotepad.Text);
                                sw.Close();
                            }
                            cs.Close();
                        }
                        else
                        {
                            GZipStream gZip = new GZipStream(fs, CompressionMode.Compress);
                            sw = new StreamWriter(gZip);
                            sw.Write(textBoxNotepad.Text);
                            sw.Close();
                            gZip.Close();
                        }
                    }             
                    else
                    {
                        sw = new StreamWriter(fs);
                        sw.Write(textBoxNotepad.Text);
                        sw.Close();
                    }
                }

            }
            catch(System.ArgumentException)
            {
                MessageBox.Show("Pusta ścieżka");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Niepoprawna ścieżka");
            }
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBoxSciezka.Text = openFileDialog1.FileName;
        }

    }
}
