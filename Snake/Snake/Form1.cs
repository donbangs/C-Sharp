using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{

    public partial class Snake : Form
    {
        private Wonsz snake;
        private Wyniki wyn = new Wyniki();
        private WonszJesc jedzenie;
        private bool czy_gra_aktywna;
        Label[] liczby = new Label[10];
        /// </summary>
        public Snake()
        {
            
            for (int i = 0; i < 10; i++)
            {
                liczby[i] = new Label();
            }
            InitializeComponent();
            czy_gra_aktywna = false;
            timer1.Enabled=true;
            pauzaToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black);
                snake.move();
      
                snake.rysuj(pole_gry.CreateGraphics(), new SolidBrush(Color.Red));
                jedzenie.rysujJedzenie(pole_gry.CreateGraphics(), new SolidBrush(Color.Green));
                label1.Text = "Ilosc Punktow: " + snake.punkty().ToString();
                if (jedzenie.czy_WonszJesc(snake.x[0], snake.y[0]))
                {
                    snake.dodaj();
                }
                if (snake.czyWonsz_zyje() == false)
                {
                    int punkty = snake.punkty();
                    wyn.dodaj(punkty);
                    czy_gra_aktywna = false;
                }

            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Verdana");
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Red);
                pole_gry.CreateGraphics().DrawString("Nacisnij Start", f, b, 40, 100);
            }

            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            snake = new Wonsz(pole_gry.Width, pole_gry.Height);
            jedzenie = new WonszJesc(snake.segment);
            pauzaToolStripMenuItem.Enabled = true;
            
          
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) snake.ruch = "gora";
            if (e.KeyCode == Keys.Down) snake.ruch = "dol";
            if (e.KeyCode == Keys.Left) snake.ruch = "lewo";
            if (e.KeyCode == Keys.Right) snake.ruch = "prawo";
        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pauzaToolStripMenuItem.Text = "Wznow";
                pole_gry.CreateGraphics().Clear(Color.Black);
            }
            else
            {
                czy_gra_aktywna = true;
                pauzaToolStripMenuItem.Text = "Pauza";
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                snake = new Wonsz(pole_gry.Width, pole_gry.Height);
                jedzenie = new WonszJesc(snake.segment);
            }
        }

        private void wolniejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }

        private void szybciejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 10)
            {
                timer1.Interval -= 10;
            }
        }

        private void szybkoscGryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void wyniki_Click(object sender, EventArgs e)
        {

          
            int positionTop = 50;
            int positionLeft = 250;


            for (int i = 0; i < 10; i++)
            {
               
                liczby[i].Text = (i+1)+". "+ wyn.zwroc(i).ToString();
                liczby[i].Left = positionLeft;
                liczby[i].Top = positionTop;

                positionTop += 22;


                this.Controls.Add(liczby[i]);
            }


        }

        private void zerujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wyn.zeruj();
        }
    }
}
