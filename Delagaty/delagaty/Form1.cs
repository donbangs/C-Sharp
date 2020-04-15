using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delagaty
{

    public partial class Form1 : Form
    {


   

        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                liczby[i] = new Label();
            }
        }

        public double[] listaLiczb = { 1, 2, 4, 5, 6, 7, 8, 9, 10,11 };
        public static Label[] liczby = new Label[10];
       
        public delegate double Działanie(double x, double y);
        Działanie dzialanie;

        Delegaty.DelOperacja dod = new Delegaty.DelOperacja(Delegaty.x2);
        Delegaty delegaty = new Delegaty();

        public delegate double potega(double a);

       
        public static double x2(double liczba)
        {
            return liczba * liczba;
        }
        public static double x3(double liczba)
        {
            return liczba * liczba * liczba;
        }

        public static double x4(double liczba)
        {
            return liczba * liczba * liczba * liczba;
        }

    
     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r1.Checked)
            {
                dzialanie = new Działanie(Delegaty.Dodawanie);
            }
            else if (r2.Checked)
            {
                dzialanie = new Działanie(Delegaty.odejmowanie);
            }

            else if (r3.Checked)
            {
                dzialanie = new Działanie(Delegaty.mnozenie);
            }

            else if (r4.Checked)
            {
                dzialanie = new Działanie(Delegaty.dzielenie);

            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {

            t3.Text = dzialanie(double.Parse(t1.Text), double.Parse(t2.Text)).ToString();

        }

        private void Potega_Click(object sender, EventArgs e)
        {
            if (r5.Checked)
            {
              
                Delegaty.potega dod = new Delegaty.potega(delegaty.zwroc(2));
                t3.Text = dod(double.Parse(t1.Text)).ToString();



            }
            else if (r6.Checked)
            {
                Delegaty.potega dod = new Delegaty.potega(delegaty.zwroc(3));
                t3.Text = dod(double.Parse(t1.Text)).ToString();


            }
            else if (r7.Checked)
            {
                Delegaty.potega dod = new Delegaty.potega(delegaty.zwroc(4));
                t3.Text = dod(double.Parse(t1.Text)).ToString();


            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

            t3.Text = delegaty.Operacja(dod,listaLiczb).ToString();

          


            int positionTop = 50;
            int positionLeft = 700;


            for (int i = 0; i < listaLiczb.Length; i++)
            {

                liczby[i].Text = (i + 1) + ". " + listaLiczb[i].ToString();
                liczby[i].Left = positionLeft;
                liczby[i].Top = positionTop;

                positionTop += 22;


                this.Controls.Add(liczby[i]);
            }



        }
    }
}
