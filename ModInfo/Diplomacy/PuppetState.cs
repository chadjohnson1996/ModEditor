namespace ModInfo.Diplomacy
{
    public class PuppetState : Relationship
    {
        /// <summary>
        /// whether it is a vassal or a substate
        /// </summary>
        public PuppetStateTypeEnum Type { get; set; }
    }
}