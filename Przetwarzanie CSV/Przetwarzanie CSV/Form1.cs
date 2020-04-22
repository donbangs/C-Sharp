using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przetwarzanie_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                var cars = GetCars(open.FileName);

                foreach (var car in cars)
                {
                    listBox1.Items.Add(car.Year);
                }
            }
      
           
        }

        private static List<Car> GetCars(string path)
        {
            return
            File.ReadLines(path)
                .Skip(1)
                .Where(l => l.Length > 1)
                .Select(l => Car.TransformToCar(l))
                .ToList();
        }

        
    }
}
