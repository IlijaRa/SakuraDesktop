using SakuraDesktop.BusinessLogicTier;
using SakuraDesktop.PresentationTier.MessageBoxes;
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

namespace SakuraDesktop
{
    public partial class ChangeVLCDestination : Window
    {
        VLCDestinationBusinessLogic destinationBusinessLogic = new VLCDestinationBusinessLogic();
        public ChangeVLCDestination()
        {
            InitializeComponent();
            destinationPath.Text = @"C:\Program Files (x86)\VideoLAN\VLC";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ButtonAccept(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(destinationPath.Text))
            {
                if (destinationBusinessLogic.ChangeDestinationPath(destinationPath.Text))
                {
                    SUCCESS success = new SUCCESS();
                    success.ShowDialog();
                    this.Hide();
                }
                else
                {
                    ERROR error = new ERROR();
                    error.ShowDialog();
                }
            }
            else
            {
                WARNING warning = new WARNING();
                warning.ShowDialog();
            }
        }

        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
