using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class ScoutReport
    {
        #region ScoutReport Properties
        [DataMember(Name = "battleObserved")]
        public Battle BattleObserved { get; set; }
        [DataMember(Name = "regiment")]
        public Regiments Regiment { get; set; }
        [DataMember(Name = "stages")]
        public List<BattleStage> Stages { get; set; }
        #endregion

        #region ScoutReport Methods
        public ScoutReport()
        {
            
        }

        public ScoutReport(ScoutReport template)
        {
            
            Stages = new List<BattleStage>(template.Stages);
        }
        #endregion
    }
}
