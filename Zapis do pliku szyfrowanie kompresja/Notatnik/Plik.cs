using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
namespace Notatnik
{
    class Plik
    {
        string sciezka;

        string tekst;

        public Plik(string sciezka)
        {
            this.sciezka = sciezka;
            
        }
        public void zapis(string text)
        {
            using (StreamWriter writer = new StreamWriter(sciezka))
            {
                writer.Write(text);
            }
           
        }
        public string odczyt()
        {
            using (StreamReader reader = new StreamReader(sciezka))
            {
                tekst = reader.ReadToEnd();
            }
            return tekst;
        }

        public void kompres(string text)
        {
            FileStream fsOutput = new FileStream(sciezka, FileMode.Create);
            GZipStream gZip = new GZipStream(fsOutput, CompressionMode.Compress);
            StreamWriter writer = new StreamWriter(gZip);
            writer.Write(text);
            writer.Close();
            gZip.Close();
            fsOutput.Close();
        }


        public string dekompres()
        {
            FileStream fsInput = new FileStream(sciezka, FileMode.Open);
            GZipStream gZip = new GZipStream(fsInput, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(gZip);
            tekst = reader.ReadToEnd();
            gZip.Close();
            fsInput.Close();
            return tekst;
        }

        public void szyfruj(string text)
        {
            RijndaelManaged Crypto = new RijndaelManaged();
            byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            FileStream sr = new FileStream(sciezka, FileMode.Open);
            CryptoStream cs = new CryptoStream(sr, Crypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(text);
            sw.Close();
            cs.Close();

        }

        public string deszyfruj()
        {
            RijndaelManaged Crypto = new RijndaelManaged();
            byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            FileStream fs=new FileStream(sciezka, FileMode.Open);
            CryptoStream cs = new CryptoStream(fs, Crypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            tekst = sr.ReadToEnd();
            sr.Close();
            cs.Close();
            return tekst;
        }
        public void SzyfKomp(string tekst)
        {
            RijndaelManaged Crypto = new RijndaelManaged();
            byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            FileStream sr = new FileStream(sciezka, FileMode.Open);
            CryptoStream cs = new CryptoStream(sr, Crypto.CreateEncryptor(Key, IV), CryptoStreamMode.Write);
            GZipStream gZip = new GZipStream(cs, CompressionMode.Compress);
            StreamWriter sw = new StreamWriter(gZip);
            sw.Write(tekst);
            sw.Close();
            gZip.Close();
            cs.Close();

        }
        public  string DeszyfDekomp()
        {

            RijndaelManaged Crypto = new RijndaelManaged();
            byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            FileStream fs = new FileStream(sciezka, FileMode.Open);
            CryptoStream cs = new CryptoStream(fs, Crypto.CreateDecryptor(Key, IV), CryptoStreamMode.Read);
            GZipStream gZip = new GZipStream(cs, CompressionMode.Decompress);
            StreamReader sr = new StreamReader(gZip);
            tekst = sr.ReadToEnd();
            sr.Close();
            gZip.Close();
            cs.Close();
            return tekst;
        }

    }
}
