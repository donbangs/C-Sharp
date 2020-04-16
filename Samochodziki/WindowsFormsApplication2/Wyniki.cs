using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Wyniki
    {
        int[] wyniki = new int[10];

        public void zeruj()
        {
            for (int x = 0; x < 10; x++)
            {
                wyniki[x] = 0;
            }
        }

        public void dodaj(int wyn)
        {

            for (int x = 9; x >= 0; x--)
            {
                if (wyn > wyniki[x])
                {
                    wyniki[x] = wyn;
                    break;
                }

            }

            Array.Sort(wyniki);
            Array.Reverse(wyniki);

        }
        public int zwroc(int x)
        {
            return wyniki[x];
        }

    }
}
