using System.Collections.Generic;

namespace ImperialScoutLibrary
{
    public class Match
    {
        #region Match Properties
        public MatchType Campaign { get; set; }
        public int ID { get; set; }
        public Dictionary<Alliances, Alliance> Armies { get; set; }
        #endregion

        #region Battle Methods
        public Match()
        {

        }
        #endregion
    }
}
