using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.HumanResources.Model.Operations;

namespace IQ.Platform.HumanResources.Model.Configurations
{
    /// <summary>
    /// class that represent the store hours
    /// </summary>
    public class StoreHours
    {
        /// <summary>
        /// gets or sets the operating hours for monday
        /// </summary>
        public OperatingDay Monday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for tuesday
        /// </summary>
        public OperatingDay Tuesday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for wednesday
        /// </summary>
        public OperatingDay Wednesday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for thursday
        /// </summary>
        public OperatingDay Thursday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for friday
        /// </summary>
        public OperatingDay Friday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for saturday
        /// </summary>
        public OperatingDay Saturday { get; set; }

        /// <summary>
        /// gets or sets the operating hours for sunday
        /// </summary>
        public OperatingDay Sunday { get; set; }
    }
}
