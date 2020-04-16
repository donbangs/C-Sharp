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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Osooba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  ObservableCollection<Osoba> People { get; set; }
        public MainWindow()
        {
            People = new ObservableCollection<Osoba>() { new Osoba("Maks", "Hunteer", "Meksyk", 1994) };
            InitializeComponent();
            DataContext = this; 
        }
       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dodawanie dodawnaie = new Dodawanie(People);
            dodawnaie.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            People.Remove((Osoba)listBox.SelectedItem);
        }

     
    }
}
