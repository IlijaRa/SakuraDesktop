using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System;
using System.IO;
using SakuraDesktop.PresentationTier.Animes.DecaDence;
using SakuraDesktop.PresentationTier.Animes.DeadmanWonderland;

namespace SakuraDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ButtonDecaDence(object sender, RoutedEventArgs e)
        {
            HomeDecaDence decadence = new HomeDecaDence();
            decadence.Show();
            decadence.TransferTitle("Deca-Dence");
            this.Hide();
        }

        private void ButtonGOHS(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeathParade(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonKabaneriOfTheIronFortress(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonGangsta(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeadmanWonderland(object sender, RoutedEventArgs e)
        {
            HomeDeadmanWonderland deadman = new HomeDeadmanWonderland();
            deadman.Show();
            deadman.TransferTitle("Deadman Wonderland");
            this.Hide();
        }

        private void ButtonErased(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHighRiseInvasion(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonChangeVLCDestionation(object sender, RoutedEventArgs e)
        {
            ChangeVLCDestination destination = new ChangeVLCDestination();
            destination.ShowDialog();
        }

        private void ButtonCheckMobileVersion(object sender, RoutedEventArgs e)
        {

        }
    }
}
