using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Apk : Form
    {
        Slownik slownik = new Slownik();
        Stos<string> st = new Stos<string>();
        Label[] historia = new Label[20];
        public Apk()
        {
          
            InitializeComponent();
            slownik.WpisaneSlowa();

            int positionTop = 50;
            int positionLeft = 385;


            for (int i = 0; i < 20; i++)
            {

                historia[i] = new Label();

                historia[i].Left = positionLeft;
                historia[i].Top = positionTop;

                positionTop += 25;


                this.Controls.Add(historia[i]);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            slownik.Dodaj(t1.Text, t2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t1.Text = slownik.Test();
            st.Połóż(t1.Text);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            t2.Text = slownik.Wyszukaj(t1.Text);
            slownik.Historia(t1.Text);
            slownik.Ilosc();
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1.Text = slownik.Sprawdz(t1.Text,t2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t1.Text = st.Zdejmij();
        }

        private void b2_Click(object sender, EventArgs e)
        {
          
            label.Text = "Historia: ";
           


            for (int i = 0; i < slownik.wyszukiwanie; i++)
            {
                 historia[i].Text = slownik.zwroc(i);
            }
       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

    
            label.Text = "Historia: ";
       

            for (int i = 0; i < slownik.wyszukiwanie; i++)
            {
                historia[i].Text = " ";
            
            }
            slownik.czysc();
        }

      
    }
}
