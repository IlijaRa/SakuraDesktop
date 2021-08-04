using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SakuraDesktop.DataAccessTier;
using SakuraDesktop.Model;

namespace SakuraDesktop.BusinessLogicTier
{
    public class VLCDestinationBusinessLogic
    {
        VLCDestinationDataAccess destinationDataAccess = new VLCDestinationDataAccess();

        public DestinationPath GetVLCDestinationPath()
        {
            return destinationDataAccess.GetVLCDestinationPath();
        }
    }
}
