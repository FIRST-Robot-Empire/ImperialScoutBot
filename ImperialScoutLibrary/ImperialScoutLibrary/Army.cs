using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class Army
    {
        #region Army Properties
        [DataMember(Name = "factions")]
        public Dictionary<Regiments, Faction> Factions { get; set; }
        #endregion

        #region Army Methods
        public Army()
        {

        }
        #endregion
    }
}
