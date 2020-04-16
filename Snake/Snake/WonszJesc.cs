using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Snake
{
    class WonszJesc
    {
        public int x;
        public int y;
        public int segment;

        public void jedzenie()
        {
            Random r = new Random();
            x = r.Next(0,20) * segment;
            y = r.Next(0, 20) * segment;

        }

        public WonszJesc(int segment)
        {
            this.segment = segment;
            jedzenie();
        }
        public bool czy_WonszJesc(int glowaX,int glowaY)
        {
            if (x == glowaX && y == glowaY)
            {
                jedzenie();
                return true;
            }

            else {
                return false;
            }

        }
        public void rysujJedzenie(Graphics g, Brush b)

        {
            g.FillRectangle(b, x, y, segment,segment);
        }
    }
}
