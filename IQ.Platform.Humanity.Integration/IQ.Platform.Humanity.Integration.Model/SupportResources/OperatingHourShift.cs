using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.SupportResources
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
