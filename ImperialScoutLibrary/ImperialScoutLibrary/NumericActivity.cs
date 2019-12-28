using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ImperialScoutLibrary
{
    [DataContract]
    public class NumericActivity: ArmamentActivity
    {
        #region NumericActivity Properties
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "count")]
         public int Count { get; set; }
        #endregion

        #region NumericActivity Methods
        public NumericActivity()
        {

        }
        #endregion
    }
}
