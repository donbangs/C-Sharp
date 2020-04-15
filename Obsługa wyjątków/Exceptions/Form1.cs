using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exceptions
{
    public partial class Form1 : Form
    {
        Licz licz = new Licz();
        SaveExceptions exceptions = new SaveExceptions();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = licz.obwod_trojkata(textBox1.Text, textBox2.Text, textBox3.Text).ToString();
            }
            catch (FormatException ex)
            {
                exceptions.Save(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = licz.pole_kwadratu(textBox1.Text, textBox2.Text).ToString();
            }
            catch (FormatException ex)
            {
                exceptions.Save(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = licz.dzielenie(textBox1.Text, textBox2.Text).ToString();
            }
            catch (FormatException ex)
            {
                exceptions.Save(ex);
                MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                exceptions.Save(ex);
                MessageBox.Show("Nie mozna dzielic przez zero");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = licz.mnozenie(textBox1.Text, textBox2.Text).ToString();
            }
            catch (FormatException ex)
            {
                exceptions.Save(ex);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
