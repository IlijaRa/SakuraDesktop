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

namespace SakuraDesktop.PresentationTier.MessageBoxes
{

    public partial class IncorrectVLCDestination : Window
    {
        public IncorrectVLCDestination()
        {
            InitializeComponent();
        }

        private void ButtonOK(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
