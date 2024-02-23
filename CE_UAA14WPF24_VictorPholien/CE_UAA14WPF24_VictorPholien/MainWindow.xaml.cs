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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Image = System.Windows.Controls.Image;

namespace CE_UAA14WPF24_VictorPholien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button[,] buttons = new Button[1,1];
        }

        private void Image(object sender, RoutedEventArgs e)
        {
            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.UriSource = new Uri("assets/petitCercleRouge.png", UriKind.Relative);
            imageBouton.EndInit();
            Image imBouton = new Image();
            imBouton.Source = imageBouton;
            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
        }

        private void Image2(object sender, RoutedEventArgs e)
        {
            BitmapImage imageBouton = new BitmapImage();
            imageBouton.BeginInit();
            imageBouton.UriSource = new Uri("assets/volvik.png", UriKind.Relative);
            imageBouton.EndInit();
            Image imBouton = new Image();
            imBouton.Source = imageBouton;
            imBouton.Stretch = System.Windows.Media.Stretch.Fill;
        }

        private void Marelle(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CheckBoxA))
            {
                for (int i = 24; ; i++)
                {
                    Console.WriteLine(Image);
                }
            }
        }

        private void Solitaire(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(CheckBoxB))
            {
                for (int i = 45; ; i++)
                {
                    Console.WriteLine(Image);
                }
            }
            else
            {
                Console.WriteLine(Image2);
            }
        }

        private void Error(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Veuillez encoder des dimensions valides comprises entre 1 et 12");
        }
    }
}
