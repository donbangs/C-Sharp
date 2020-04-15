using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Karaoke
{
    public partial class Form1 : Form
    {


      
        public string lin;
        public int liczba;
        public int x = 0;
        Karaoke sing;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            timer1.Start();
            sing = new Karaoke(openFileDialog1.FileName);
            sing.PlayMp3UsingWinmm();
            sing.odczytaj();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // lin = sing.odczytaj();
          //  liczba = int.Parse(sing.odczytaj());

            timer1.Interval =int.Parse(sing.zwroc(x)) ;
            x++;
            textBox1.Text = sing.zwroc(x);
            x++;
            if ((x/2) == (sing.x/2))
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
