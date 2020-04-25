using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Strumienie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        CancellationTokenSource cancellationTokenSource = null;


 


        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            StockProgress.Visibility = Visibility.Visible;
            StockProgress.IsIndeterminate = true;
            Search.Content = "Cancel";
            var watch = new Stopwatch();
            watch.Start();
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource = null;
                return;
            }

            cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.Token.Register(() =>
            {
                Notes.Text += "Cancellation requested" + Environment.NewLine;
            });

            // var symbols = Ticker.Text.Split(' ');

            try
            {
                await Task.Factory.StartNew(() =>
                     {
                         var line = File.ReadAllLines(@"CompanyData.csv");
                         var l = line
                         .Skip(1)
                         .Select(l => CompanyData.LineToData(l));

                         foreach (var d in l)
                         {
                             Dispatcher.Invoke(()=>
                             {
                                 Stocks.Items.Add(d.ToString());
                             });
                             
                         }
                     },
                   CancellationToken.None,
                   TaskCreationOptions.DenyChildAttach,
                   TaskScheduler.Default
                   );
            }
            catch (Exception ex)
            {
                Notes.Text += ex.Message + Environment.NewLine;
            }
            finally {
                cancellationTokenSource = null;
            }

            watch.Stop();
            StocksStatus.Text = $"Loaded date in {watch.ElapsedMilliseconds}ms";
            StockProgress.Visibility = Visibility.Hidden;
            Search.Content = "Search";
        }
        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NewTask_Click(object sender, RoutedEventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource = null;
                return;
            }

            var loadLinesTask = Task.Run(() =>
            {
                var lines = File.ReadAllLines(@"CompanyData.csv");
                return lines;
            });

            loadLinesTask.ContinueWith(t =>
            {
                var datas = t.Result.Select(l => CompanyData.LineToData(l));
               
                foreach (var data in datas)
                {
                    Dispatcher.Invoke(() =>
                    {
                        Stocks.Items.Add(data.ToString());
                    });
                }
            }, cancellationTokenSource.Token, 
            TaskContinuationOptions.OnlyOnRanToCompletion,
            TaskScheduler.Current);


            loadLinesTask.ContinueWith(t =>
            {
                Dispatcher.Invoke(() =>
                {
                    Stocks.Items.Add(t.Exception.InnerException.Message);
                });
            });
        }
    }
}
