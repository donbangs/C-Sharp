using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zdarzenia
{
    public partial class Form1 : Form
    {
   
        MyForm form = new MyForm("liczba 1");
        MyForm form2 = new MyForm("liczba 2");

        Button but = new Button();
  
   
        public Form1()
        {
            InitializeComponent();
        }


      

        public void button1_Click( object sender,   EventArgs e)
        {
       
           
            form.Show();
            form.MyEvent += new EventHandler<TextEventArgs>(button1_Click);
          button1.Text = form.ValueChanged(sender,e);


        }
   
        

        public void button2_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.MyEvent += new EventHandler<TextEventArgs>(button2_Click);
            button2.Text = form2.ValueChanged(sender,e);

        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(button1.Text) + int.Parse(button2.Text)).ToString();


        }


        
    }

}

    

