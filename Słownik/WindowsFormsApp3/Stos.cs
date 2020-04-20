using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class Stos<T>
    {
        Element el;
        class Element
        {
            T wartosc;
            Element el;
            public T Wartość
            {
                get { return wartosc; }
            }
            public Element El
            {
                get { return el; }
            }
            public Element(T wartosc, Element el)
            {
                this.wartosc = wartosc;
                this.el = el;
            }
        }

        public Stos()
        {
            el = null;
        }

        public bool czyPusty()
        {
            return el == null;
        }

        public void Połóż(T wartosc)
        {
            el = new Element(wartosc, el);
        }

        public T Zdejmij()
        {
            T wartosc;
            if (czyPusty())
                return default(T);
            wartosc = el.Wartość;
            el = el.El;
            return wartosc;
        }

    }
}
