using System;

namespace ModInfo.Diplomacy
{
    public abstract class Relationship
    {
        /// <summary>
        /// the first country in the relationship
        /// </summary>
        public Country First { get; set; }
        /// <summary>
        /// the second country in the relationship
        /// </summary>
        public Country Second { get; set; }
        /// <summary>
        /// the start of the relationship
        /// </summary>
        public DateTime Start { get; set; }
        /// <summary>
        /// the end of the relationship
        /// </summary>
        public DateTime End { get; set; }
    }
}
