using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        MyGenericList<double> NumList = new MyGenericList<double>();
        MyGenericList<string> StringList = new MyGenericList<string>();
        MyGenericList<Point3D> PointList = new MyGenericList<Point3D>();
        MyGenericList<Person> PersonList = new MyGenericList<Person>();
        private void ButtonInt_Click(object sender, EventArgs e)
        {
            double n = double.Parse(textBoxInt.Text);
         //   NumList.Add(4.5);
            NumList.Add(n);
            listBox1.Items.Clear();
            for(int i=0;i<NumList.Count;i++)
            {
                listBox1.Items.Add(NumList[i]);
            }
           // NumList[0] = 5;
            label1.Text = NumList.Count.ToString();
        }

        private void ButtonString_Click(object sender, EventArgs e)
        {
            StringList.Add(textBoxString.Text);
            listBox2.Items.Clear();
            for (int i = 0; i < StringList.Count; i++)
            {
                listBox2.Items.Add(StringList[i]);
            }
            label2.Text = StringList.Count.ToString();
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBoxX.Text);
            double y = double.Parse(textBoxY.Text);
            double z = double.Parse(textBoxZ.Text);
            PointList.Add(new Point3D(x, y, z));
            listBox3.Items.Clear();
            for (int i = 0; i < PointList.Count; i++)
            {
                listBox3.Items.Add(PointList[i]);
            }
            label3.Text = PointList.Count.ToString();
        }

        private void ButtonPerson_Click(object sender, EventArgs e)
        {
            PersonList.Add(new Person(textBoxName.Text, textBoxSurname.Text));
            listBox4.Items.Clear();
            for (int i = 0; i < PersonList.Count; i++)
            {
                listBox4.Items.Add(PersonList[i]);
            }
            label4.Text = PersonList.Count.ToString();
        }

        private void ButtonIntDel_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {
                NumList.Delete(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                for (int i = 0; i < NumList.Count; i++)
                {
                    listBox1.Items.Add(NumList[i]);
                }
                label1.Text = NumList.Count.ToString();
            }
        }

        private void ButtonStringDel_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                StringList.Delete(listBox2.SelectedIndex);
                listBox2.Items.Clear();
                for (int i = 0; i < StringList.Count; i++)
                {
                    listBox2.Items.Add(StringList[i]);
                }
                label2.Text = StringList.Count.ToString();
            }
        }

        private void ButtonPointDel_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem != null)
            {
                PointList.Delete(listBox3.SelectedIndex);
                listBox3.Items.Clear();
                for (int i = 0; i < PointList.Count; i++)
                {
                    listBox3.Items.Add(PointList[i]);
                }
                label3.Text = PointList.Count.ToString();
            }
        }

        private void ButtonPersonDel_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem != null)
            {
                PersonList.Delete(listBox4.SelectedIndex);
                listBox4.Items.Clear();
                for (int i = 0; i < PersonList.Count; i++)
                {
                    listBox4.Items.Add(PersonList[i]);
                }
                label4.Text = PersonList.Count.ToString();
            }
        }
        private void ButtonRand_Click(object sender, EventArgs e)
        {
            double x = rand.NextDouble();
            textBoxX.Text = Math.Round(x, 4).ToString();
            double y = rand.NextDouble();
            textBoxY.Text = Math.Round(y, 4).ToString();
            double z = rand.NextDouble();
            textBoxZ.Text = Math.Round(z, 4).ToString();
        }
    }
}
