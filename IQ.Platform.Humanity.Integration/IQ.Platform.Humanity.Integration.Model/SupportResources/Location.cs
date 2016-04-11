using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;
using IQ.Platform.HumanResources.Model.Configurations;
using IQ.Platform.HumanResources.Model.Operations;

namespace IQ.Platform.HumanResources.Model.SupportResources
{
    /// <summary>
    /// class that represents the location of a retail store/company
    /// </summary>
    public class Location: IStatelessResource, IIdentifiable<int>
    {
        /// <summary>
        /// gets or sets the identifier where this location is mapped to
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// gets or sets the name of the company
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// gets or sets the employees on this location
        /// </summary>
        public int NumberOfEmployees { get; set; }

        /// <summary>
        /// gets or sets the address of the company
        /// </summary>
        public string CompanyAddress { get; set; }

        /// <summary>
        /// gets or sets the timezone, example 
        /// </summary>
        public string CompanyTimezone { get; set; }

        /// <summary>
        /// gets or sets the location id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// gets or sets the name of the location
        /// </summary>
        public string LocationName { get; set; }

        /// <summary>
        /// gets or sets 
        /// </summary>
        public string LocationTimezone { get; set; }

        /// <summary>
        /// gets or sets the address
        /// </summary>
        public string LocationAddress { get; set; }

        /// <summary>
        /// gets or sets the default location
        /// </summary>
        public string LocationDefault { get; set; }

        /// <summary>
        /// gets or sets the positions
        /// </summary>
        public string[] LocationPositions { get; set; }

        /// <summary>
        /// gets or sets when the location is created
        /// </summary>
        public DateTime LocationCreated { get; set; }

        /// <summary>
        /// gets or sets the store hours
        /// </summary>
        public StoreHours LocationHours { get; set; }

        /// <summary>
        /// gets or sets the Location shifts
        /// </summary>
        public StoreShifts LocationShifts { get; set; }
    }
}
