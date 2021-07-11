
namespace ImperialScoutLibrary
{
    /*
     * Data for a Numeric Input to a Scouting Report
     */
    public class NumericRecord: IRecord
    {
        #region NumericRecord Properties
        //Name of the Record
        public string Name { get; set; }
        //Describtion of the Record, if required
        public string Description { get; set; }
        //The actual count of the Record
        public int Count { get; set; }
        #endregion

        #region NumericRecord Methods
        public NumericRecord()
        {
            
        }
        #endregion
    }
}
