using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SQL
{
    public partial class Form1 : Form
    {
        string wartosc="";
        MySqlCommand komenda;
        MySqlDataReader czytnik;
        MySqlConnection pol = new MySqlConnection("server=localhost;user=root;database=wypozyczenia");
        string zapytanieSQL = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
            
            zapytanieSQL = "select * from klienci";
            komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();

            if (czytnik.HasRows)
            {

                while (czytnik.Read())
                {
                    listBox1.Items.Add(string.Format("{0} - {1} - {2} - {3} - {4}", czytnik[0].ToString(), czytnik["imie"].ToString(), czytnik["nazwisko"].ToString(), czytnik["pesel"].ToString(), czytnik["numerDowodu"].ToString()));
                }
                    czytnik.Close();
            }

                zapytanieSQL = "select * from samochody";
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();

                if (czytnik.HasRows)
                {

                    while (czytnik.Read())
                    {
                        listBox2.Items.Add(string.Format("{0} - {1} - {2} - {3} - {4} - Id klienta {5} ", czytnik[0].ToString(), czytnik["marka"].ToString(), czytnik["model"].ToString(), czytnik["konieMechaniczne"].ToString(), czytnik["rok"].ToString(),czytnik.GetInt32("klient")));
                    }
                    czytnik.Close();
                }


            }
            pol.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "insert into klienci values(null,'"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
       
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "insert into samochody values(null,'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')";
           
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
 

            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "update klienci set imie  = '" + textBox1.Text + "',nazwisko='" + textBox2.Text + "',pesel='" + textBox3.Text + "',numerDowodu='" + textBox4.Text + "' where klienciid ="+textBox6.Text;
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();

        }

      
        private void button5_Click(object sender, EventArgs e)
        {
            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "update samochody set marka  = '" + textBox1.Text + "',model='" + textBox2.Text + "',konieMechaniczne=" + textBox3.Text + ",rok=" + textBox4.Text + ",klient=" + textBox5.Text + " where samochodyId=" + textBox6.Text;
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "DELETE FROM samochody WHERE samochodyid =" + textBox6.Text;
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (pol.State == ConnectionState.Closed)
            {
                pol.Open();
                zapytanieSQL = "DELETE FROM klienci WHERE klienciid =" + textBox6.Text;
                komenda = new MySqlCommand(zapytanieSQL, pol);
                czytnik = komenda.ExecuteReader();
            }
            czytnik.Close();
            pol.Close();
        }
    }
}
