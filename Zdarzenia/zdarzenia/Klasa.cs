using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zdarzenia
{
    public class MyForm : Form
    {

        public event EventHandler<TextEventArgs> MyEvent;

        private Button but;
        private Button ExitBtn;
        public string liczba = "";
        TextBox box = new TextBox();
        TrackBar bar;



        protected virtual void OnMyEvent(TextEventArgs e)
        {
            // Create a copy of the event to work with
            EventHandler<TextEventArgs> handler = MyEvent;
            /* If there are no subscribers, eh will be null so we need to check
             * to avoid a NullReferenceException. */
            if (handler != null)
                handler(this, e);
        }

        public string ValueChanged(object sender,EventArgs e)

        {
            return liczba;
           
       }
  

        public void Zmiana(object sender, EventArgs e)
        {

          
            liczba = box.Text;
            bar.Value =int.Parse(liczba);

            OnMyEvent(new TextEventArgs(box.Text));
        }




        private void trackBar1_Scroll(object sender, System.EventArgs e)
        {
        
            box.Text = "" + bar.Value;
        }


        private void OnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public MyForm(string text)
        {
            this.Text = Application.StartupPath;

            box.Top = 30;
            box.Left = 120;
            box.Parent = this;
            box.Text = "podaj liczbe";
          
            but = new Button();
            but.Parent = this;
            but.Top = 10;
            but.Left = 10;
            but.Text = "Zatwierdz";
            but.Click += new System.EventHandler(Zmiana);
            

            ExitBtn = new Button();
            ExitBtn.Parent = this;
            ExitBtn.Top = 10;
            ExitBtn.Left = 120;
            ExitBtn.Text = "Zamknij";
            ExitBtn.Click += new System.EventHandler(OnExitClick);
            bar = new TrackBar();
            bar.Parent = FindForm();
            bar.Top = 30;
            bar.Left = 10;
            this.bar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            bar.Maximum = 100;
            bar.TickFrequency = 1;
            Label label = new Label();
            label.Parent = this;
            label.Top = 90;
            label.Left = 10;
            label.Text = text;


        }
     

    
 
    }
}
  
       
    

