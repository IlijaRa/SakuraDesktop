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

        public bool ChangeDestinationPath(string path)
        {
            return destinationDataAccess.ChangeDestinationPath(path);
        }

        public string FormatPath(string path)
        {
            string completePath = "";
            string[] pathElements= path.Split('\\');
            for(int i=0; i< pathElements.Count(); i++)
            {
                if (i == pathElements.Count() - 1)
                    completePath += pathElements[i];
                else
                    completePath += pathElements[i] + "\\" + "\\";
            }

            return completePath;
        }
    }
}
