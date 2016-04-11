using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.SupportResources
{
    /// <summary>
    /// object that represents Availability
    /// </summary>
    public class Availability
    {
        /// <summary>
        /// gets or sets the DayOfWeek enum
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// gets or sets the availability start
        /// </summary>
        public int AvailabilityStart { get; set; }

        /// <summary>
        /// gets or sets the availability end
        /// </summary>
        public int AvailabilityEnd { get; set; }
    }
}
