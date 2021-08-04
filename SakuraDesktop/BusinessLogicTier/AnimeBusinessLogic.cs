using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SakuraDesktop.DataAccessTier;
using SakuraDesktop.Model;

namespace SakuraDesktop.BusinessLogicTier
{
    public class AnimeBusinessLogic
    {
        AnimeDataAccess animeDataAccess = new AnimeDataAccess();

        public Anime GetAnimeByName(string animeName)
        {
            return animeDataAccess.GetAnimeByName(animeName);
        }
    }
}
