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
using System.Windows.Threading;

namespace Lover
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[,] eredmeny = new string[4, 3];
        Random rnd = new Random();
        byte verseny = 0;

        public MainWindow()
        {
            InitializeComponent();

             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Lo1.Margin = new Thickness(start.Margin.Left, 14, 668, 338);
            Lo2.Margin = new Thickness(start.Margin.Left, 112, 666, 264);
            Lo3.Margin = new Thickness(start.Margin.Left, 200, 667, 175);
            verseny += 1;

            for (int i = 0; i < eredmeny.Length; i++) 
            {
                for (int j = 0; j < eredmeny.Length; j++)
                {
                    eredmeny[i, j] = "";
                }
            }

            nr.IsEnabled = false;
            nc.IsEnabled = false;
            sr.IsEnabled = false;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Start();
            timer.Tick += timer_tick;
        }

        private void timer_tick(object sender, EventArgs e) 
        { 
            
        }

    }
}
