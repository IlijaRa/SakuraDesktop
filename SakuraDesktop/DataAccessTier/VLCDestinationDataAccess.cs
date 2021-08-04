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
    public class VLCDestinationDataAccess
    {
        List<DestinationPath> destinationPaths = new List<DestinationPath>();
        public VLCDestinationDataAccess()
        {
            readVLCDestinationJson();
        }

        public void readVLCDestinationJson()
        {

            using (StreamReader sr= new StreamReader("VLCDestination.json"))
            {
                string line = sr.ReadToEnd();

                if(line != " ")
                {
                    destinationPaths = JsonConvert.DeserializeObject<List<DestinationPath>>(line);
                }
            }
        }

        public DestinationPath GetVLCDestinationPath()
        {
            return destinationPaths.First();
        }
    }
}
