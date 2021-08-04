using Newtonsoft.Json;
using SakuraDesktop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace SakuraDesktop.DataAccessTier
{
    public class AnimeDataAccess
    {
        List<Anime> animes = new List<Anime>();

        public AnimeDataAccess()
        {
            readAnimeJson();
        }

        public void readAnimeJson()
        {
            using (StreamReader sr = new StreamReader("AnimesAndEpisodes.json"))
            {
                string line= sr.ReadToEnd();
                if (line != null)
                {
                    animes = JsonConvert.DeserializeObject<List<Anime>>(line);
                }
            }
        }

        public Anime GetAnimeByName(string animeName)
        {
            Anime anime = new Anime();
            foreach(var a in animes)
            {
                if (a.AnimeName == animeName)
                    anime = a;
            }

            return anime;
        }
    }
}
