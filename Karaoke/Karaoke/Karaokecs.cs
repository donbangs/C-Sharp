using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;

namespace Karaoke
{
    class Karaoke
    {
        public string[] tab = new string[30];
        private readonly string MP3_PATH;
        
        public string tekst;
        public int x { get; set; }
      
        public Karaoke(string MP3_PATH)
        {
            this.MP3_PATH = MP3_PATH;
            tekst = Path.ChangeExtension(MP3_PATH,"txt");
            x = -1;

        }




        [DllImport("winmm.dll")]
        private static extern long mciSendString(string sCommand,
            StringBuilder sReturn, int nReturnLength, IntPtr oCallback);

        public void PlayMp3UsingWinmm()
        {
            mciSendString("open \"" + MP3_PATH +
                "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
            // ...
            //  Console.ReadKey();
            //mciSendString("close MediaFile", null, 0, IntPtr.Zero);
        }

        public void odczytaj()
        {
            
            using (StreamReader reader = new StreamReader(tekst))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }
                    x++;

                    tab[x] = line;
               
                    
                }
            }
        }

        


        

        public string zwroc(int x)
        {
            return tab[x];

        }






    }
}
