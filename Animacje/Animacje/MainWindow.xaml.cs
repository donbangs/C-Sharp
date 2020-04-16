using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Animacje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           BitmapImage image = new BitmapImage(new Uri(@"D:\Wpf\Animacje\1.jpg"));
            Image1.Source = image;
            animacja2();
        }
        

        public void animacja() {
            DoubleAnimation a = new DoubleAnimation();
            a.RepeatBehavior = RepeatBehavior.Forever;
            a.AutoReverse = true;
            a.From = 50;
            a.To =200;
            a.Duration = new Duration(TimeSpan.Parse("0:0:5"));
            Button1.BeginAnimation(Button.WidthProperty, a);
        }

        public void animacja2()
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 1.0;
            myDoubleAnimation.To = 0.0;
            myDoubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(5));
            myDoubleAnimation.AutoReverse = true;
            myDoubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            Image1.BeginAnimation(Image.OpacityProperty, myDoubleAnimation);

        }
        public void RenderTransform()
        {
            ColorAnimation color = new ColorAnimation();

            myButton.RenderTransformOrigin = new Point(0.5, 0.5);
            
            ScaleTransform myScaleTransform = new ScaleTransform();
            myScaleTransform.ScaleY = 3;
            RotateTransform myRotateTransform = new RotateTransform();
            myRotateTransform.Angle = 45;
            TransformGroup myTransformGroup = new TransformGroup();
            myTransformGroup.Children.Add(myScaleTransform);
            myTransformGroup.Children.Add(myRotateTransform);
   
            myButton.RenderTransform = myTransformGroup;

         
          
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            animacja();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            RenderTransform();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform myRotateTransform = new RotateTransform(10);
            Button3.LayoutTransform = myRotateTransform;

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            RotateTransform myRotateTransform = new RotateTransform(10);
            Button2.RenderTransform = myRotateTransform;


        }
    }
}
