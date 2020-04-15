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

namespace obrazek
{
    public partial class Form1 : Form
    {
        Bitmap image1;
       
       

        int r = 0;
        int g = 0;
        int b = 0;

        private BackgroundWorker m_oBackgroundWorker = null;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 100;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
      
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            trackBar1.Value = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if (null == m_oBackgroundWorker)
            {
                m_oBackgroundWorker = new BackgroundWorker();
                m_oBackgroundWorker.DoWork += new DoWorkEventHandler(m_oBackgroundWorker_DoWork);
                m_oBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(m_oBackgroundWorker_RunWorkerCompleted);
                m_oBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(m_oBackgroundWorker_ProgressChanged);
                m_oBackgroundWorker.WorkerReportsProgress = true;
                m_oBackgroundWorker.WorkerSupportsCancellation = true;
               
            }
            pbProgress.Value = 0;
            label1.Text = "Uruchomiono zadanie.\n";
            image1 = new Bitmap(openFileDialog1.FileName);
            pbProgress.Maximum = (image1.Width);
            m_oBackgroundWorker.RunWorkerAsync();
  

        }

       


        void m_oBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            for (int x = 0; x < image1.Width; x++)
            {
                if (m_oBackgroundWorker.CancellationPending)
                     {
                            e.Cancel = true;
                          break;
                     }

                    for (int y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);

                    r = pixelColor.R;
                    g = pixelColor.G;
                    b = pixelColor.B;

                    r = (r * int.Parse(textBox1.Text) / 100);
                    g = (g * int.Parse(textBox1.Text) / 100);
                    b = (b * int.Parse(textBox1.Text) / 100);




                    Color newColor = Color.FromArgb(r, g, b);
                    image1.SetPixel(x, y, newColor);



                }
                pictureBox1.Image = image1;
                m_oBackgroundWorker.ReportProgress(x);


            }

            pictureBox1.Image = image1;

       
        }
        void m_oBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            label1.Text = (e.ProgressPercentage/5).ToString() + "%\n";
            pbProgress.Value = e.ProgressPercentage;


        }
        void m_oBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label1.Text = "Przerwano";
            }
            else
            {
                label1.Text="Zakończono.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((null != m_oBackgroundWorker) && m_oBackgroundWorker.IsBusy)
            {
                m_oBackgroundWorker.CancelAsync();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"D:\c sharp\obrazek\fotolia2.jpeg");
        }

        
    }
}
