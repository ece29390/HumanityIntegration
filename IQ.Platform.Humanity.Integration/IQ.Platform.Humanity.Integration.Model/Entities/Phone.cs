using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.Entities
{
    /// <summary>
    /// gets or sets the Phone
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// gets or sets the number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// gets or sets the extension number
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// gets or sets the type of phone, it could be work, home, etc.
        /// </summary>
        public string Type { get; set; }

    }
}
