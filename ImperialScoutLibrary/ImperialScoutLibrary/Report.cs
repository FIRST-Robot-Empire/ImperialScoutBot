using System.Collections.Generic;

namespace ImperialScoutLibrary
{
    /*
     * The Scouting Report
     */
    public class Report
    {
        #region Report Properties
        //The current Match
        public Match Match { get; set; }
        //The Driver Station
        public DriverStation Station { get; set; }
        //The Stages of the Match
        public List<Phase> Stages { get; set; }
        #endregion

        #region Report Methods
        public Report()
        {
            
        }

        //Copy Constructor from the TEMPLATE of the Scouting Report
        public Report(Report template)
        {
            
            Stages = new List<Phase>(template.Stages);
        }
        #endregion
    }
}
