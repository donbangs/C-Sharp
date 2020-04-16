using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Osooba
{
    /// <summary>
    /// Interaction logic for Dodawanie.xaml
    /// </summary>
    public partial class Dodawanie : Window
    {
        public Dodawanie(ObservableCollection<Osoba> list)
        {
            People = list;
            InitializeComponent();
            DataContext = this;

        }
        public ObservableCollection<Osoba> People { get; set; }
        public Uri Photo { get; set; }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Osoba p = (Osoba)listBox.SelectedItem;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() ?? false)
                {
                    p.Photo = new Uri(openFileDialog.FileName);
                }
                else p.Photo = null;
                p.Name = imie.Text;
                p.Surname = nazwisko.Text;
                p.City = miasto.Text;
                p.Year = int.Parse(rok.Text);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(rok.Text, out int year))
            {
                Osoba p = new Osoba(imie.Text, nazwisko.Text, miasto.Text, year);
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() ?? false)
                {
                    p.Photo = new Uri(openFileDialog.FileName);
                }
                else p.Photo = null;
                People.Add(p);
            }
            else
                MessageBox.Show("Niepoprawne dane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    
    }
}
