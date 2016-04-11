using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.HumanResources.Model.Operations;

namespace IQ.Platform.HumanResources.Model.Operations
{
    /// <summary>
    /// class that represents store shifts
    /// </summary>
    public class StoreShifts
    {
        /// <summary>
        /// gets or sets the shift for monday
        /// </summary>
        public OperatingDayShift Monday { get; set; }

        /// <summary>
        /// gets or sets the shift for tueday
        /// </summary>
        public OperatingDayShift Tuesday { get; set; }

        /// <summary>
        /// gets or sets the shift for wednesday
        /// </summary>
        public OperatingDayShift Wednesday { get; set; }

        /// <summary>
        /// gets or sets the shift for thursday
        /// </summary>
        public OperatingDayShift Thursday { get; set; }

        /// <summary>
        /// gets or sets the shift for friday
        /// </summary>
        public OperatingDayShift Friday { get; set; }

        /// <summary>
        /// gets or sets the shift for saturday
        /// </summary>
        public OperatingDayShift Saturday { get; set; }

        /// <summary>
        /// gets or sets the shift for sunday
        /// </summary>
        public OperatingDayShift Sunday { get; set; }
    }
}
