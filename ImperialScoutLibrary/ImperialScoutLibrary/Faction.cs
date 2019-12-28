using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class Faction
    {
        #region Faction Properties
        [DataMember(Name = "id")]
        public int ID { get; set; }
        #endregion

        #region Faction Methods
        public Faction()
        {

        }
        #endregion
    }
}
