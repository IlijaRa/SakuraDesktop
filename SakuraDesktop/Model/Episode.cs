using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraPlayer.Model
{
    public class Episode
    {
        /// <summary>
        /// Episode identificator
        /// </summary>
        public int Id { get; set; }

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

        public Episode(int id, string episodeName, string link, string description)
        {
            this.Id = id;
            this.EpisodeName = episodeName;
            this.Link = link;
            this.Description = description;
        }
    }
}
