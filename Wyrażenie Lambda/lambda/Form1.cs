using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
namespace lambda
{
   
    public partial class Lambda : Form
    {
        delegate double operacja1(double x);
        operacja1 potroj = (x) => Math.Pow(x,3);
        delegate double operacja2(double x, double y);
        operacja2 doN = (x,y) => Math.Pow(x, y);
        Func<double, double, bool> mniejsza = (x, y) => x > y;
        Func<string,string> mala = (x) => x.ToUpper();
        Func<string, string> wsz = (x) => x.ToLower();




        public Lambda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
               
                label1.Text += textBox1.Text + " Do 3 potegi = ";
                label1.Text +=potroj(double .Parse(textBox1.Text)).ToString();
                label1.Text += "\n";
            }
            if (radioButton2.Checked)
            {

                label1.Text +=  textBox1.Text +" Do potegi "+ textBox2.Text+"= ";
                label1.Text += doN(double.Parse(textBox1.Text), double.Parse(textBox2.Text)).ToString();
                label1.Text += "\n";
            }
            if (radioButton3.Checked)
            {

                if (mniejsza(double.Parse(textBox1.Text), double.Parse(textBox2.Text)) == true)
                {
                    label1.Text += "Pierwsza liczba jest wieksza";
                }
                else { label1.Text += "Druga liczba jest wieksza"; }
                label1.Text += "\n";


            }
            if (radioButton4.Checked)
            {
                label1.Text += mala(textBox1.Text);
                label1.Text += "\n";

            }
            if (radioButton5.Checked)
            {
                
                label1.Text += wsz(textBox1.Text);
                label1.Text += "\n";

            }



        }
    }
}
