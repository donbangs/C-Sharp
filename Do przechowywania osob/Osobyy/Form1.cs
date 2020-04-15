using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osobyy
{
    public partial class Form1 : Form
    {
        Sortowanie sort;
        Osoba osoba;
        List<Osoba> listaOsob = new List<Osoba>();
       


        public Form1()
        {
            
            InitializeComponent();
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "dd-MM-yyyy";
            ojciec.Enabled = false;
            matka.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                osoba = new Osoba(imie.Text, nazwisko.Text, DateTime.Parse(date.Text), miejsce.Text);
                osoba.Matka = (Osoba)matka.Tag;
                osoba.Ojciec = (Osoba)ojciec.Tag;
                listaOsob.Add(osoba);
                lb1.Items.Add(osoba);
                matka.Tag = null;
                ojciec.Tag = null;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                Osoba x = (Osoba)lb1.SelectedItem;
                imie.Text = x.Imie;
                nazwisko.Text = x.Nazwisko;
                if (x.Matka != null)
                {
                    matka.Text = x.Matka.ToString();
                }
                else
                {
                    matka.Text = "";
                }
                if (x.Ojciec != null)
                {
                    ojciec.Text = x.Ojciec.ToString();
                }
                else
                {
                    ojciec.Text = "";
                }
                date.Text = x.Date.ToString();
                miejsce.Text = x.Miejsce;
            }







        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = lb1.SelectedIndex;
            if (lb1.SelectedItem != null)
            {
                lb1.Items.RemoveAt(index);
                listaOsob.RemoveAt(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            int index = lb1.SelectedIndex;
            if (lb1.SelectedItem != null)
            {
                
                    Osoba x = (Osoba)lb1.SelectedItem;
                    x.Imie = imie.Text;
                    x.Nazwisko = nazwisko.Text;
                    x.Matka = (Osoba)matka.Tag;
                    x.Ojciec = (Osoba)ojciec.Tag;
                    x.Date = DateTime.Parse(date.Text);
                    x.Miejsce = miejsce.Text;
                    lb1.Items.RemoveAt(index);
                    lb1.Items.Insert(index, x);
                    listaOsob[index] = x;


                

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = lb1.SelectedIndex;
            if (lb1.SelectedItem != null)
            {
                Osoba x = (Osoba)lb1.SelectedItem;
                ojciec.Tag =x;
                ojciec.Text = x.ToString();
                

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lb1.SelectedItem != null)
            {
                Osoba x = (Osoba)lb1.SelectedItem;
                matka.Tag = x;
                matka.Text = x.ToString();

            }
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb2.Items.Clear();
            Osoba x = (Osoba)lb1.SelectedItem;
           
            var getMother = listaOsob.Where(person => person.Matka == x); 
            var getFather = listaOsob.Where(person => person.Ojciec == x);
            if (getMother != null)
            {
                foreach (var get in getMother)
                {
                    
                  lb2.Items.Add( get.ToString());
                   
                }

            }

            if (getFather != null)
            {
                foreach (var get in getFather)
                {
                    lb2.Items.Add(get.ToString());
                }

            }






        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            sort = new Sortowanie(listaOsob);
            sort.Show();

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matka.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ojciec.Text = "";
        }
    }
}
