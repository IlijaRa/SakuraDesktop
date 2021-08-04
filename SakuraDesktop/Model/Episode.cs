using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraDesktop.Model
{
    public class Episode
    {
        /// <summary>
        /// Episode identificator
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Episode number
        /// </summary>
        public double EpisodeNumber { get; set; }

        /// <summary>
        /// Episode name
        /// </summary>
        public string EpisodeName { get; set; }

        /// <summary>
        /// Link that connects application with a chosen episode from the internet and enables wpf to show it
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Describes what is happening in the episode. Just a short overview.
        /// </summary>
        public string Description { get; set; }

        public Episode()
        {

        }

        public Episode(int id, double episodeNumber, string episodeName, string link, string description)
        {
            this.Id = id;
            this.EpisodeNumber = episodeNumber;
            this.EpisodeName = episodeName;
            this.Link = link;
            this.Description = description;
        }
    }
}
