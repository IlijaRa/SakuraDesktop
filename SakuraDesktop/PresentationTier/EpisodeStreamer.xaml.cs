using SakuraDesktop.DataAccessTier;
using SakuraDesktop.Model;
using SakuraDesktop.PresentationTier.MessageBoxes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace SakuraDesktop.PresentationTier
{
    
    public partial class EpisodeStreamer : Window
    {
        VLCDestinationDataAccess destinationDataAccess = new VLCDestinationDataAccess();
        VlcControl control = new VlcControl();
        public EpisodeStreamer()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        public void TransferInfo(Anime anime, Episode episode)
        {
            try
            {
                Title.Text = episode.EpisodeName;
                DestinationPath destination = destinationDataAccess.GetVLCDestinationPath();
                //var control = new VlcControl();
                this.hostE1.Child = control;
                string path = System.IO.Path.GetFullPath(destination.Path);

                control.BeginInit();
                control.VlcLibDirectory = new DirectoryInfo(path);
                control.EndInit();

                control.Play(new Uri(episode.Link));
            }
            catch (Exception ex)
            {
                SystemSounds.Asterisk.Play();
                IncorrectVLCDestination incorrect = new IncorrectVLCDestination();
                incorrect.ShowDialog();
            }

        }

        public void ButtonExit(object sender, RoutedEventArgs e)
        {
            control.Stop();
            this.Hide();
        }

        private void ButtonMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
