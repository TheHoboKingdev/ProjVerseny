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
        Random rnd = new Random();
        byte verseny = 0;
        int elso = 0;
        int masodik = 0;
        int harmadik = 0;

        List<int> l1E = new List<int>();
        List<int> l2E = new List<int>();
        List<int> l3E = new List<int>();

        bool l1_kesz = false;
        bool l2_kesz = false;
        bool l3_kesz = false;

        

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

            nr.IsEnabled = false;
            nc.IsEnabled = false;
            sr.IsEnabled = false;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Start();
            timer.Tick += timer_tick;
        }

        private void timer_tick(object sender, EventArgs e)
        {
            double l1_pos = Lo1.Margin.Right;
            double l2_pos = Lo2.Margin.Right;
            double l3_pos = Lo3.Margin.Right;
            int l1_mov = rnd.Next(10, 30);
            int l2_mov = rnd.Next(10, 30);
            int l3_mov = rnd.Next(10, 30);

            if (l1_pos >= -550)
            {
                Lo1.Margin = new Thickness(l1_mov, 14, l1_pos - l1_mov, 338);
                l1_pos += l1_mov;
            }
            else
                if (elso == 0)
            {
                elso = 1;
                l1E.Add(1);
                l1_kesz = true;
            }
            else
                if (masodik == 0)
                {
                    masodik = 1;
                    l1E.Add(2);
                    l1_kesz = true;
                }
            
            else 
                if (harmadik == 0)
                {
                    harmadik = 1;
                    l1E.Add(3);
                    l1_kesz = true;
                }
        

            if (l2_pos >= -550)
            {
                Lo2.Margin = new Thickness(l2_mov, 112, l2_pos - l2_mov, 264);
                l2_pos += l2_mov;
            }
            else
 
                if (elso == 0)
                {
                    elso = 2;
                    l2E.Add(1);
                    l2_kesz = true;
                }
                else
                if (masodik == 0)
                {
                    masodik = 2;
                    l2E.Add(2);
                    l2_kesz = true;
                }
                else
                if (harmadik == 0)
                {
                    harmadik = 2;
                    l2E.Add(3);
                    l2_kesz = true;
                }

            if (l3_pos >= -550)
            {
                Lo3.Margin = new Thickness(l3_mov, 200, l3_pos - l3_mov, 175);
                l3_pos += l3_mov;
            }
            else if (elso == 0)
            {
                l3E.Add(1);
                elso = 3;
                l3_kesz = true;
            }
            else
                if (masodik == 0)
            {
                l3E.Add(2);
                masodik = 3;
                l3_kesz = true;
            }
            else
                if (harmadik == 0)
            {
                l3E.Add(3);
                harmadik = 3;
                l3_kesz = true;
            }

            if (l1_kesz == true && l2_kesz == true && l3_kesz == true)
            {
                Jegyzes();
            }
        }

        private void Jegyzes() 
        {
            switch (verseny) 
            {
                case 1:
                    cs11.Content = l1E[0]; 
                    cs21.Content = l2E[0];
                    cs31.Content = l3E[0];
                break;
                case 2:
                    cs12.Content = l1E[1];
                    cs22.Content = l2E[1];
                    cs32.Content = l3E[1];
                    break;
                case 3:
                    cs13.Content = l1E[2];
                    cs23.Content = l2E[2];
                    cs33.Content = l3E[2];
                    break;
                case 4:
                break;
                default:

                break;
            }

            nr.IsEnabled = true;
            nc.IsEnabled = true;
            sr.IsEnabled = true;

        }

        private void sr_Click(object sender, RoutedEventArgs e)
        {
            verseny = 4;
            Jegyzes();
        }
    }
}
