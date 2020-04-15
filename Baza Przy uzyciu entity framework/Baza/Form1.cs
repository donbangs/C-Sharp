using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Wypozyczenia())
            {
                Samochody s = new Samochody { Marka = textBox1.Text, Model = textBox2.Text, KonieMechaniczne = int.Parse(textBox3.Text), Rok = textBox4.Text };
                db.Cars.Add(s);
                listBox1.Items.Add(s);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (var db = new Wypozyczenia())
            {
                foreach (var car in db.Cars)
                {
                    listBox1.Items.Add(car);
                }
            

            listBox2.Items.Clear();
            
                foreach (var klienci in db.Posts)
                {
                    listBox2.Items.Add(klienci);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked )
            {
 
                using (var db = new Wypozyczenia())
                { 
                    Samochody dep = (Samochody)listBox1.SelectedItem;
                    // kasujemy wpis z tabeli
                    db.Cars.Remove(dep);
                    // zapisujemy zmiany
                    db.SaveChanges();
                }
            }
            if ( radioButton2.Checked)
            {
              
                using (var db = new Wypozyczenia())
                {
                    Klienci dep = (Klienci)listBox2.SelectedItem;
                    // kasujemy wpis z tabeli
                    db.Posts.Remove(dep);
                    // zapisujemy zmiany
                    db.SaveChanges();
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
       
                
                using (var db = new Wypozyczenia())
                {
                Samochody dep = (Samochody)listBox1.SelectedItem;
                int index = dep.SamochodyId;
                dep = db.Cars.Single(a => a.SamochodyId == index);
                Klienci s = new Klienci { Imie = textBox5.Text, Nazwisko = textBox6.Text, Pesel = textBox7.Text, NumerDowodu = textBox8.Text, SamochodyId = index,Samochody=dep};
                    db.Posts.Add(s);
                    listBox2.Items.Add(s);
                    db.SaveChanges();
                }
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var db = new Wypozyczenia())
            {
                var result = db.Cars;
                var query = result.Where(a => a.Marka == textBox1.Text);
                foreach (var b in query)
                {
                    listBox3.Items.Add(b);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var db = new Wypozyczenia())
            {
                Samochody dep = (Samochody)listBox1.SelectedItem;
                int index = dep.SamochodyId;
                dep = db.Cars.Single(a => a.SamochodyId == index);
              
                dep.Marka = textBox1.Text;
                dep.Model = textBox2.Text;
                dep.Rok = textBox4.Text;
                dep.KonieMechaniczne = int.Parse(textBox3.Text);
                db.SaveChanges();
            }
        }
    }
}
