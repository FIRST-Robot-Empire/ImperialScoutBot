using System.Collections.Generic;

namespace ImperialScoutLibrary
{
    /*
     * The Period during a Match
     * Ex: Auto, TeleOp ...
     */
    public class Phase
    {
        #region Phase Properties
        //The Title of the Period: TeleOp, Auto ...
        public string Name { get; set; }
        //Description of the Period
        public string Description { get; set; }
        //List of Attributes to be recorded during this Period
        public List<IRecord> Activities { get; set; }
        #endregion

        #region Phase Methods
        public Phase()
        {

        }
        #endregion
    }
}
