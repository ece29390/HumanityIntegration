using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.HumanResources.Model.Enums;

namespace IQ.Platform.HumanResources.Model.Operations
{
    /// <summary>
    /// class that represents operating hour shift
    /// </summary>
    public class OperatingHourShift
    {
        /// <summary>
        /// gets or sets the hour
        /// </summary>
        public int Hour { get; set; }

        /// <summary>
        /// gets or sets the minute
        /// </summary>
        public int Minute { get; set; }

        /// <summary>
        /// gets or sets the mode, either AM or PM
        /// </summary>
        public TimeMode Mode { get; set; }
    }
}
