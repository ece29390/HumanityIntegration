using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.Operations
{
    /// <summary>
    /// class that represents the operating day
    /// </summary>
    public class OperatingDay
    {
        /// <summary>
        /// gets or sets opening hour
        /// </summary>
        public OperatingHour Open { get; set; }

        /// <summary>
        /// gets or sets the closing hour
        /// </summary>
        public OperatingHour Close { get; set; }
    }
}
