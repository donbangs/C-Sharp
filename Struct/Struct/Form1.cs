using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> lista = new List<Point>();
        List<Point3C> lista2 = new List<Point3C>();

        private void button1_Click(object sender, EventArgs e)
        {
            
       
            Point pointK;
            Random rand = new Random();
            int ilosc = int.Parse(textBox1.Text);
            DateTime startTime = DateTime.Now;
            for (int x = 0; x < ilosc; x++)
            {
                pointK = new Point(rand.Next(0,ilosc), rand.Next(0,ilosc), rand.Next(0,ilosc));
                lista.Add(pointK);

            }
            DateTime stopTime = DateTime.Now;
            TimeSpan roznica = stopTime - startTime;
            label2.Text = "Zapisano przy uzyciu klasy " + ilosc + "  w czasie  " + roznica+" \n";



            Point3C str;
           

            startTime = DateTime.Now;
            for (int x = 0; x < ilosc; x++)
            {
                str = new Point3C(rand.Next(0, ilosc), rand.Next(0, ilosc), rand.Next(0, ilosc));
                lista2.Add(str);

            }
            stopTime = DateTime.Now;
            roznica = stopTime - startTime;
            label3.Text = "Zapisano przy uzyciu struktury   " + ilosc + "   w czasie   " + roznica + " \n";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            for (int x = int.Parse(textBox2.Text); x < int.Parse(textBox3.Text); x++)
            {
                listBox1.Items.Add(lista[x]);
                listBox2.Items.Add(lista2[x]);
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;

            lista.OrderBy(n=> n);
           
            DateTime stopTime = DateTime.Now;
            TimeSpan roznica = stopTime - startTime;
            label2.Text += "Posortowano  w czasie  " + roznica;

             startTime = DateTime.Now;

            lista2.OrderBy(n => n);

            stopTime = DateTime.Now;
            roznica = stopTime - startTime;
            label3.Text += "Posortowano  w czasie  " + roznica;

        }
    }
}
