using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class BattleStage
    {
        #region BattleStage Properties
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "activities")]
        public List<ArmamentActivity> Activities { get; set; }
        #endregion

        #region BattleStage Methods
        public BattleStage()
        {

        }
        #endregion
    }
}
