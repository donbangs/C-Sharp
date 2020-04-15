using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Binary
{
    class Binary
    {

        public long x{ get; set; }
        public string imie { get; set; }
        public DateTime data { get; set; }
        public double waga { get; set; }
        public char plec { get; set; }

        public Binary() { }

        public Binary(string imie, DateTime data, double waga, char plec)
        {
            this.imie = imie;
            this.data = data;
            this.waga = waga;
            this.plec = plec;
        }


    public override string ToString()
        {
            return "Imie "+imie+" Data "+data.ToString("dd-MM-yyyy")+" Waga "+waga.ToString()+ " Plec "+plec;
        }

      


        public void Zapis(string sciezka)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(sciezka, FileMode.Append)))
            {
                // writer.Write(list.ToString()); 
                writer.Write(imie);
                writer.Write(data.ToString());
                writer.Write(waga);
                writer.Write(plec);
            }
               
            
        }

        public void Odczyt(string sciezka)
        {
           

            if (File.Exists(sciezka))
            {

                using (BinaryReader reader = new BinaryReader(File.Open(sciezka, FileMode.Open)))
                {
                    reader.BaseStream.Position = x;
                    imie = reader.ReadString();
                    data = DateTime.Parse(reader.ReadString());
                    waga = reader.ReadDouble();
                    plec = reader.ReadChar();
                    x = reader.BaseStream.Seek(0, SeekOrigin.Current);


                }
            }
           
            

        }
    }
}
