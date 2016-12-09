using System.Collections.Generic;

namespace ModInfo.Political
{
    /// <summary>
    /// defines a country
    /// </summary>
    public class Country
    {

        /// <summary>
        /// the country tag
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// the country's name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// whether or not the country is civilized
        /// </summary>
        public bool Civilized { get; set; }
        /// <summary>
        /// the country's primary culture
        /// </summary>
        public Culture PrimaryCulture { get; set; }

        /// <summary>
        /// the country's accepted cultures
        /// </summary>
        public List<Culture> AcceptedCultures { get; set; }
        /// <summary>
        /// the political parties for the country
        /// </summary>
        public List<Party> Parties { get; set; }

        /// <summary>
        /// A country's ruling party
        /// </summary>
        public Party RulingParty { get; set; }

        /// <summary>
        /// the country's upper house
        /// </summary>
        public UpperHouse UpperHouse { get; set; }
        /// <summary>
        /// the country's order of battle
        /// </summary>
        public OrderOfBattle OOB { get; set; }

        /// <summary>
        /// the country's national value
        /// </summary>
        public NationalValue NationalValue { get; set; }

        /// <summary>
        /// the country's capital province
        /// </summary>
        public Province Capital { get; set; }

        /// <summary>
        /// the country's conciousness
        /// </summary>
        public double Conciousness { get; set; }

        /// <summary>
        /// the non state conciousness
        /// </summary>
        public double NonStateConciousness { get; set; }

        /// <summary>
        /// the technologies a country has mapped to their completion percentage
        /// </summary>
        public Dictionary<Technology, double> Technologies { get; set; }

        /// <summary>
        /// all the inventions a country has
        /// </summary>
        public List<Invention> Inventions { get; set; }


    }
}