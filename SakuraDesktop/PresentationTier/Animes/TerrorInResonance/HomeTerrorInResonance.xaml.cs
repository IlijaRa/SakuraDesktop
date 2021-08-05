using SakuraDesktop.BusinessLogicTier;
using SakuraDesktop.Model;
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

namespace SakuraDesktop.PresentationTier.Animes.TerrorInResonance
{

    public partial class HomeTerrorInResonance : Window
    {
        EpisodeBusinessLogic episodeBusinessLogic = new EpisodeBusinessLogic();
        AnimeBusinessLogic animeBusinessLogic = new AnimeBusinessLogic();

        public HomeTerrorInResonance()
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
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 1);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E2_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 2);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E3_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 3);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E4_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 4);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E5_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 5);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }
        private void E6_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 6);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E7_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 7);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E8_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 8);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E9_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 9);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E10_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 10);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        private void E11_Click(object sender, RoutedEventArgs e)
        {
            Anime anime = animeBusinessLogic.GetAnimeByName(Textbox_title.Text);
            Episode episode = episodeBusinessLogic.GetEpisodeByNumber(Textbox_title.Text, 11);
            EpisodeStreamer streamer = new EpisodeStreamer();
            streamer.TransferInfo(anime, episode);
            streamer.Show();
        }

        public void TransferTitle(string title)
        {
            Textbox_title.Text = title;
        }
    }
}
