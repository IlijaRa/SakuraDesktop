using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SakuraDesktop.DataAccessTier;
using SakuraDesktop.Model;

namespace SakuraDesktop.BusinessLogicTier
{
    public class EpisodeBusinessLogic
    {
        EpisodeDataAccess episodeDataAccess = new EpisodeDataAccess();

        public Episode GetEpisodeByNumber(string animeName, double episodeNumber)
        {
            return episodeDataAccess.GetEpisodeByNumber(animeName, episodeNumber);
        }
    }
}
