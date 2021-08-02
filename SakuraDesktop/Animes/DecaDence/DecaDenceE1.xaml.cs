using System;
using System.Collections.Generic;
using System.IO;
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
using Vlc.DotNet.Forms;

namespace SakuraDesktop.Animes.DecaDence
{
    public partial class DecaDenceE1 : Window
    {
        public DecaDenceE1()
        {
            InitializeComponent();
            var control = new VlcControl();
            this.hostE1.Child = control;
            string path = @"C:\Program Files (x86)\VideoLAN\VLC";
            control.BeginInit();
            control.VlcLibDirectory = new DirectoryInfo(path);
            control.EndInit();

            control.Play(new Uri("https://storage.googleapis.com/disco-name-320620/FOZO21A6AHN7/st23_deca-dence-episode-1.1627867712.mp4?vip=178.221.54.10"));

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ButtonMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
