using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SakuraDesktop.Model
{
    public class DestinationPath
    {
        /// <summary>
        /// Path that shows where VLC is installed
        /// </summary>
        private string path;


        //property Path
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        public DestinationPath()
        {

        }
    }
}
