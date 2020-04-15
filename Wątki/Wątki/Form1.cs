using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wątki
{
    
    public partial class Form1 : Form
    {
        bool sortowane = false;
        static List<int> liczby = new List<int>();
        static List<int> wylosowane = new List<int>();
        List<int> liczby2 = new List<int>();
        static int ilosc = 0;
        private static readonly object _lock = new object();
        public Form1()
        {
        InitializeComponent();
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {    int g = 0;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            label1.Text = "Wylosowane";
            label2.Text = "Zapisane";
            liczby.Clear();
            wylosowane.Clear();
            ilosc = int.Parse(textBox1.Text);
            Thread t = new Thread(Zapis1);
            Thread t2 = new Thread(Zapis1);
            Thread t3 = new Thread(Usun1);
            Thread t4 = new Thread(Usun1);
            t.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t.Join();
            t2.Join();
            t3.Join();
            t4.Join();


                wylosowane.Sort();
         
                for (int i = 0; i < wylosowane.Count; i++)
                {
                    listBox1.Items.Add(wylosowane[i]);
                }
         

                for (int i = 0; i < liczby.Count; i++)
                {
               
                try
                {
                    if (liczby[i] <= liczby[i + 1] && g == 0)
                    {
                        sortowane = true;
                    }
                    else {
                          g = 1; 
                         sortowane = false;
                    } 
                }
                catch { }
                    listBox2.Items.Add(liczby[i]);
                }
            


            var result = liczby.Where(n => n % 2 == 0);
            if (result.Count() != 0)
            {
                checkBox5.Checked = true;
            }



            if (sortowane==true)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox4.Checked = true;
            }

            result = liczby.Where(n => n % 2 != 0)
                      .OrderBy(n => n);

            var result2 = wylosowane.Where(n => n % 2 != 0)
                      .OrderBy(n => n);

            if (result.Count() != result2.Count())
            {
                checkBox2.Checked = true;
            }


            label1.Text = "Wylosowane " + wylosowane.Count();
            label2.Text = "Zapisane " + liczby.Count();

            MessageBox.Show("Zakonczono");


        }

        static void Zapis1()
        {
            
            int y = ilosc;
            Random rand = new Random();


            for (int x = 0; x < ilosc; x++)
            {
                int losowanie = rand.Next(1, ilosc);
                wylosowane.Add(losowanie);

                bool dodanie = false;

                try
                {
                    for (int i = 0; i < liczby.Count; i++)
                {
                    if (losowanie <= liczby[i])
                    {
                       
                            liczby.Insert(i, losowanie);
                            dodanie = true;
                            break;
                    }
                      
                }



              

                if (!dodanie)
                {
                    liczby.Add(losowanie);
                }

                if (liczby.Count == 0)
                {
                    liczby.Add(losowanie);

                }
                }

                catch { }



            }


        }
       
        static void Usun1()
        {
            for (int x = 0; x < ilosc; x++)
            {
                for (int i = 0; i < liczby.Count; i++)
                {
                    try
                    {
                        if (liczby[i] % 2 == 0)
                        {
                            liczby.RemoveAt(i);
                        }
                    }
                    catch
                    {

                    }

                }
            }

        }
     
        static void Zapis1_Lock()
        {
        
                int y = ilosc;
                Random rand = new Random();


                for (int x = 0; x < ilosc; x++)
                {
                    int losowanie = rand.Next(1, ilosc);
                    wylosowane.Add(losowanie);

                    bool dodanie = false;

                lock (_lock)
                {
                    for (int i = 0; i < liczby.Count; i++)
                    {
                   
                        if (losowanie <= liczby[i])
                        {
                       
                            liczby.Insert(i, losowanie);
                            dodanie = true;
                            break;
                        }
                    }

                 

                    if (!dodanie)
                    {
                        liczby.Add(losowanie);
                    }

                    if (liczby.Count == 0)
                    {
                        liczby.Add(losowanie);

                    }
                }


            }

            }
       
      
        static void Usun1_Lock()
        {
           
                for (int x = 0; x < ilosc; x++)
                {
                    for (int i = 0; i < liczby.Count; i++)
                    {
                    lock (_lock)
                    {
                        if (liczby[i] % 2 == 0)
                        {
                       
                            liczby.RemoveAt(i);
                        }

                    }


                    }
                }
            }
        

        private void button2_Click(object sender, EventArgs e)
        {
            int g = 0;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            liczby.Clear();
            wylosowane.Clear();
            label1.Text = "Wylosowane";
            label2.Text = "Zapisane";
            ilosc = int.Parse(textBox1.Text);
            Thread t = new Thread(Zapis1_Lock);
            Thread t2 = new Thread(Zapis1_Lock);
            Thread t3 = new Thread(Usun1_Lock);
            Thread t4 = new Thread(Usun1_Lock);

            t.Start();
            t2.Start();
            t3.Start();
            t4.Start();


          
         
            wylosowane.Sort();
           
                for (int i = 0; i < wylosowane.Count; i++)
                {
                    listBox1.Items.Add(wylosowane[i]);
                }
            
                
           

                for (int i = 0; i < liczby.Count; i++)
                {

                try
                {
                    if (liczby[i] <= liczby[i + 1] && g == 0)
                    {
                        sortowane = true;
                    }
                    else
                    {
                        g = 1;
                        sortowane = false;
                    }
                }
                catch { }

                listBox2.Items.Add(liczby[i]);

                }
            


            var result = liczby.Where(n => n % 2 == 0);
            if (result.Count() != 0)
            {
                checkBox5.Checked = true;
            }


            liczby2 = liczby;
            liczby2.Sort();

            if (liczby2 == liczby)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox4.Checked = true;
            }

            result = liczby.Where(n => n % 2 != 0)
                      .OrderBy(n => n);

            var result2 = wylosowane.Where(n => n % 2 != 0)
                      .OrderBy(n => n);

            if (result.Count() != result2.Count())
            {
                checkBox2.Checked = true;
            }


            label1.Text = "Wylosowane "+wylosowane.Count();
            label2.Text = "Zapisane " + liczby.Count();
            MessageBox.Show("Zakonczono");











        }
    }
}
