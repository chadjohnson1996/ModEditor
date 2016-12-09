using System.Collections.Generic;

namespace ModInfo.Political
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
