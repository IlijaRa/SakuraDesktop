using Newtonsoft.Json;
using SakuraDesktop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraDesktop.DataAccessTier
{
    public class EpisodeDataAccess
    {
        List<Anime> animes = new List<Anime>();
        public EpisodeDataAccess()
        {
            readAnimeJson();
        }

        public void readAnimeJson()
        {
            using (StreamReader sr= new StreamReader("AnimesAndEpisodes.json"))
            {
                string line = sr.ReadToEnd();

                if(line != " ")
                {
                    animes = JsonConvert.DeserializeObject<List<Anime>>(line);
                }
            }
        }

        public Episode GetEpisodeByNumber(string animeName, double episodeNumber)
        {
            Episode episode = new Episode();
            
            int animeIndex = animes.FindIndex(obj=> obj.AnimeName == animeName);
            int episodeIndex = animes[animeIndex].episodes.FindIndex(obj => obj.EpisodeNumber == episodeNumber);
            episode = animes[animeIndex].episodes[episodeIndex];

            return episode;
        }
    }
}
