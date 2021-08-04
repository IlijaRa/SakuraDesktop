using SakuraDesktop.DataAccessTier;
using SakuraDesktop.Model;
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
    public partial class DecaDenceStreamer : Window
    {
        VLCDestinationDataAccess destinationDataAccess = new VLCDestinationDataAccess();

        public DecaDenceStreamer()
        {
            InitializeComponent();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        public void ButtonExit(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ButtonMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void TransferInfo(Anime anime, Episode episode)
        {
            Title.Text = episode.EpisodeName;
            DestinationPath destination = destinationDataAccess.GetVLCDestinationPath();
            var control = new VlcControl();
            this.hostE1.Child = control;
            string path = System.IO.Path.GetFullPath(destination.Path);

            control.BeginInit();
            control.VlcLibDirectory = new DirectoryInfo(path);
            //control.VlcLibDirectory = new DirectoryInfo(@"C:\Program Files (x86)\VideoLAN\VLC");
            control.EndInit();

            control.Play(new Uri(episode.Link));
        }
    }
}
