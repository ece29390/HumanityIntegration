using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.Operations
{
    /// <summary>
    /// class that represents operating day shift
    /// </summary>
    public class OperatingDayShift
    {
        /// <summary>
        /// gets or sets the opening shift
        /// </summary>
        public OperatingHourShift Open { get; set; }

        /// <summary>
        /// gets or sets the close shift
        /// </summary>
        public OperatingHourShift Close { get; set; }
    }
}
