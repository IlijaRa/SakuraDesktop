using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraDesktop.Model
{
    public class Anime
    {
        /// <summary>
        /// Anime identificator
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Anime name
        /// </summary>
        public string AnimeName { get; set; }

        /// <summary>
        /// List of episodes that anime contains
        /// </summary>
        public List<Episode> episodes { get; set; } = new List<Episode>();

        public Anime()
        {

        }

        public Anime(int id, string animeName, List<Episode> episodes)
        {
            this.Id = id;
            this.AnimeName = animeName;
            this.episodes = episodes;
        }
    }
}
