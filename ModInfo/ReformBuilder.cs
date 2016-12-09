using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModInfo
{
    public class ReformBuilder
    {
        /// <summary>
        /// all the reform builders that get read in from the file
        /// </summary>
        public static List<ReformBuilder> ReformBuilders { get; set; }

        /// <summary>
        /// the name of the reform
        /// </summary>
        public string ReformName { get; set; }

        /// <summary>
        /// the different levels of the reform
        /// </summary>
        public List<string> ReformLevels { get; set; }
    }
}
