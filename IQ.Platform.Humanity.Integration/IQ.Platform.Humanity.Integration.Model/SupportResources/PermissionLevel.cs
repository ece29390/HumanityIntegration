using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ.Platform.HumanResources.Model.SupportResources
{
    /// <summary>
    /// class that represents permission level, this object is intended to map to security role of RQ
    /// </summary>
    public class PermissionLevel
    {
        /// <summary>
        /// gets or sets the permission id
        /// </summary>
        public int PermissionId { get; set; }

        /// <summary>
        /// gets or sets the description of the level
        /// </summary>
        public string Name { get; set; }
    }
}
