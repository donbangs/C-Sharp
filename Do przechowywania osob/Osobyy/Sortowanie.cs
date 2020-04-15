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
    public partial class Sortowanie : Form
    {
        DateTime dzis = DateTime.Today;
        List<Osoba> listaOsob; 
        IEnumerable<Osoba> result;
        public Sortowanie(List<Osoba> list)
        {
            InitializeComponent();
            listaOsob = list;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = listaOsob;
            lb1.Items.Clear();
            if (checkBox1.Checked)
            {
                result = result.Where(osoba => osoba.Imie == Parametr.Text);
            }
            if (checkBox2.Checked)
            {
                result = result.Where(osoba => osoba.Nazwisko == Parametr2.Text);
            }
            if (checkBox3.Checked)
            {
                result = result.Where(osoba => osoba.Miejsce == Parametr3.Text);
            }
            if (checkBox4.Checked)
            {
                result = result.Where(osoba => (osoba.Date.Year - dzis.Year) == int.Parse(Parametr4.Text));
            }
            if (checkBox5.Checked)
            {
                result = result.Where(osoba => osoba.Date.Year  == int.Parse(Parametr5.Text));
            }

            if (result != null)
            {
                foreach (var get in result)
                {
                    lb1.Items.Add(get.ToString());
                }

            }

        }
    }
}
