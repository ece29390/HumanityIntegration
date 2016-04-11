using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.SupportResources
{
    /// <summary>
    /// gets or sets the address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// gets or sets the address
        /// </summary>
        public string AddressLine { get; set; }

        /// <summary>
        /// gets or sets the name of the city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// gets or sets the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// gets or sets the zip
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// gets or sets the country
        /// </summary>
        public string Country { get; set; }

    }
}
