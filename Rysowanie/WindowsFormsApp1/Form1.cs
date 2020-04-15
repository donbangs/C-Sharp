using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int y;


        public Form1()
        {
            InitializeComponent();
        }


        public static void kwadrat(Graphics g, Brush b)
        {
            g.FillRectangle(new SolidBrush(Color.Brown), 110, 280, 50, 50);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] tab = { "Red", "Blue", "Purple", "Yellow", "Black", "Gold", "GhostWhite" };
            SolidBrush brushGreen = new SolidBrush(Color.Green);

            PointF point1 = new PointF(20, 300);
            PointF point2 = new PointF(260, 300);
            PointF point3 = new PointF(140, 240);


            PointF[] point =
                     {
                 point1,
                 point2,
                 point3,
             };


            point1 = new PointF(40, 270);
            point2 = new PointF(240, 270);
            point3 = new PointF(140, 220);

            PointF[] poin =
                     {
                 point1,
                 point2,
                 point3,
            };

            point1 = new PointF(60, 240);
            point2 = new PointF(220, 240);
            point3 = new PointF(140, 200);

            PointF[] poi =
                     {
                 point1,
                 point2,
                 point3,
             };
            point1 = new PointF(80, 220);
            point2 = new PointF(200, 220);
            point3 = new PointF(140, 180);

            PointF[] po =
                     {
                 point1,
                 point2,
                 point3,
             };

            point1 = new PointF(100, 200);
            point2 = new PointF(180, 200);
            point3 = new PointF(140, 160);

            PointF[] p =
                  {
                 point1,
                 point2,
                 point3,
             };

            point1 = new PointF(115, 180);
            point2 = new PointF(165, 180);
            point3 = new PointF(140, 150);


            PointF[] a =
                     {
                 point1,
                 point2,
                 point3,
             };






            pole.CreateGraphics().Clear(Color.White);
            Pen zielony = new Pen(Brushes.Green, 20);
            kwadrat(pole.CreateGraphics(), new SolidBrush(Color.Green));
            pole.CreateGraphics().FillPolygon(brushGreen, point);
            pole.CreateGraphics().FillPolygon(brushGreen, poin);
            pole.CreateGraphics().FillPolygon(brushGreen, poi);
            pole.CreateGraphics().FillPolygon(brushGreen, po);
            pole.CreateGraphics().FillPolygon(brushGreen, p);
            pole.CreateGraphics().FillPolygon(brushGreen, a);



            int b;
            int n;
           
            if (Bombki.Checked)
            {





                for (int x = 0; x < 15; x++)
                {
                    b = rand.Next(60, 200);
                    n = rand.Next(200, 280);
                    SolidBrush solid = new SolidBrush(Color.FromName(tab[rand.Next(0, tab.Length)]));
                    pole.CreateGraphics().FillEllipse(solid, b, n, 14, 14);

                }


            }

            if (Swiatełka.Checked)
            {
                timer1.Start();

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Interval = 2000;

            int b = 20;
            int n = 290;
            y++;
            if (y % 2 != 0)
            {
               
                for (int x = 0; x < 22; x++)
                {
                    SolidBrush solid = new SolidBrush(Color.Red);
                    pole.CreateGraphics().FillEllipse(solid, b, n, 10, 10);


                    if (x <= 8 && x >= 0)
                    {
                        b += 20;

                        n -= 5;
                    }
                    else if (x <= 14 && x >= 8)
                    {

                        b -= 20;
                        n -= 5;
                    }
                    else if (x <= 18 && x >= 14)
                    {

                        n -= 5;
                        b += 20;
                    }
                    else if (x <= 21 && x >= 18)
                    {
                        n -= 8;
                        b -= 20;
                    }



                }

            }


            if (y % 2 == 0)
            {

                for (int x = 0; x < 22; x++)
                {
                    SolidBrush solid = new SolidBrush(Color.Black);
                    pole.CreateGraphics().FillEllipse(solid, b, n, 10, 10);


                    if (x <= 8 && x >= 0)
                    {
                        b += 20;

                        n -= 5;
                    }
                    else if (x <= 14 && x >= 8)
                    {

                        b -= 20;
                        n -= 5;
                    }
                    else if (x <= 18 && x >= 14)
                    {

                        n -= 5;
                        b += 20;
                    }
                    else if (x <= 21 && x >= 18)
                    {
                        n -= 8;
                        b -= 20;
                    }
                }
            }
            
        }
    }
}
