using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Wyniki wyniki = new Wyniki();
        int zakres = 100;
        int punkty=0;
        int poziom = 1;
        Przeciwnik p1;
        Przeciwnik p2;
        Przeciwnik p3;
        Samochod gracz;
        bool czy_gra_aktywna = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 100;
            label4.Text = "1";
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            p1 = new Przeciwnik(panel1.Width, panel1.Height, panel1.Height / 10);
            p2 = new Przeciwnik(panel1.Width, panel1.Height, (panel1.Height / 10) * 3);
            p3 = new Przeciwnik(panel1.Width, panel1.Height, (panel1.Height / 10) * 6);
            gracz = new Samochod(panel1.Width, panel1.Height);
            czy_gra_aktywna = true;
            zakres = 100;
            punkty = 0;
            poziom = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                timer1.Interval = 100;
                panel1.CreateGraphics().Clear(Color.Black);
                p1.rysuj(panel1.CreateGraphics(), new SolidBrush(Color.White));
                p2.rysuj(panel1.CreateGraphics(), new SolidBrush(Color.White));
                p3.rysuj(panel1.CreateGraphics(), new SolidBrush(Color.White));
                gracz.rysuj(panel1.CreateGraphics(), new SolidBrush(Color.Green));
                p1.przesun();
                p2.przesun();
                p3.przesun();
                punkty++;
                if (p1.kolizja(gracz.x) || p2.kolizja(gracz.x) || p3.kolizja(gracz.x))
                {
                    wyniki.dodaj(punkty);
                    czy_gra_aktywna = false;
                }
                panel1.CreateGraphics().DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(panel1.Width / 4, 0), new Point(panel1.Width / 4, panel1.Height));
                panel1.CreateGraphics().DrawLine(new Pen(new SolidBrush(Color.Red)), new Point(panel1.Width / 2, 0), new Point(panel1.Width / 2, panel1.Height));
                panel1.CreateGraphics().DrawLine(new Pen(new SolidBrush(Color.Red)), new Point((panel1.Width / 4) * 3, 0), new Point((panel1.Width / 4) * 3, panel1.Height));
                label2.Text = punkty.ToString();
                if (punkty > zakres)
                {
                    poziom++;
                    zakres *=poziom;
                    label4.Text = poziom.ToString();
                    if (timer1.Interval > 10)
                    {
                        timer1.Interval -= 10;
                    }
                }
               
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Aqua);
                panel1.CreateGraphics().DrawString("Kliknij, aby rozpocząć", f, b, 120, 135);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) gracz.przesun("prawa");
            if (e.KeyCode == Keys.Left) gracz.przesun("lewa");
        }

      

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pauzaToolStripMenuItem.Text = "Wznow";
                panel1.CreateGraphics().Clear(Color.Red);
            
            }
            else
            {
                czy_gra_aktywna = true;
                pauzaToolStripMenuItem.Text = "Pauza";
            }
        }

        private void wynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label5.Text = "Wyniki";
            for (int x = 0; x < 10; x++)
            {
                label5.Text += "\n" + wyniki.zwroc(x);
            }
            }

        private void zerujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wyniki.zeruj();
        }
    }
}
