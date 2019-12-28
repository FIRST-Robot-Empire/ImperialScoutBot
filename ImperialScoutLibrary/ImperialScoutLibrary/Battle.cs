using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class Battle
    {
        #region Battle Properties
        [DataMember(Name = "campaign")]
        public Campaigns Campaign { get; set; }
        [DataMember(Name = "id")]
        public int ID { get; set; }
        [DataMember(Name = "armies")]
        public Dictionary<Alliances, Army> Armies { get; set; }
        #endregion

        #region Battle Methods
        public Battle()
        {

        }
        #endregion
    }
}
