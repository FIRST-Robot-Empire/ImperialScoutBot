using System.Collections.Generic;

namespace ImperialScoutLibrary
{
    public class Alliance
    {
        #region Alliance Properties
        public Dictionary<DriverStation, Team> Teams { get; set; }
        #endregion

        #region Alliance Methods
        public Alliance()
        {

        }
        #endregion
    }
}
