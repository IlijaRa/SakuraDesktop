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
using System.Windows.Shapes;

namespace SakuraDesktop.Animes.DecaDence
{
    public partial class HomeDecaDence : Window
    {
        public HomeDecaDence()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonGoBack(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void E1_Click(object sender, RoutedEventArgs e)
        {
            DecaDenceE1 e1 = new DecaDenceE1();
            e1.Show();

        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
