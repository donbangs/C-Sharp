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

namespace taski
{
    public partial class Form1 : Form
    {
        Task task1;
        CancellationTokenSource cancelSource = new CancellationTokenSource();
        static ProgressBar bar;
        static int od;
        static int doo;
        static List<int> lista = new List<int>();
        public Form1()
        {
            InitializeComponent(); bar = new ProgressBar();
            bar.Width = 400;
            bar.Height = 50;
            bar.Top = 100;
            bar.Left = 10;
            bar.Parent = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Clear();
            od = int.Parse(textBox1.Text);
            doo = int.Parse(textBox2.Text);
            bar.Maximum = (doo - od) + 1;
            CancellationToken token = cancelSource.Token;
            task1 = Task.Factory.StartNew(() => liczbyParzyste(token), token);


            /*
            Task task = Task.Factory.StartNew(() =>
            {
                int g = 0;
                int x = 0;
                doo = doo + 1;
                for (int o = od; o < doo; o++)
                {
                    x = 0;
                    for (int c = 2; c < o; c++)
                    {
                        if (o % c == 0)
                        {
                            x++;
                        }
                    }
                    if (x == 0)
                    {
                        lista.Add(o);
                    }
                    g++;
                    if (cancelSource.IsCancellationRequested == false)
                    {
                        bar.Invoke((MethodInvoker)delegate
                        {
                            bar.Value = g;
                        });
                    }
                    token.ThrowIfCancellationRequested();
                   
                       
                }

            },token);
            */

        }


        static void liczbyParzyste(CancellationToken token)
        {
            int g = 0;
            int x = 0;
            doo = doo + 1;

            for (int o = od; o < doo; o++)
            {
                x = 0;
                for (int c = 2; c < o; c++)
                {
                    if (o % c == 0)
                    {
                        x++;
                    }


                }
                if (x == 0)
                {
                    lista.Add(o);
                }
                g++;

                if (token.IsCancellationRequested == false)
                {
                    bar.Invoke((MethodInvoker)delegate
                    {
                        bar.Value = g;
                    });
                }
                token.ThrowIfCancellationRequested();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count(); i++)
            {
                listBox1.Items.Add(lista[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cancelSource.Cancel();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {

            label3.Text = "";
            try
            {
                task1.Wait();
            }
            catch (AggregateException ae)
            {
                MessageBox.Show("Anulowano");
                foreach (var c in ae.Flatten().InnerExceptions)
                {
                    label3.Text += c.ToString();
                }

            }

        }

    }

}
