using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;

namespace IQ.Platform.HumanResources.Model.SupportResources
{
    /// <summary>
    /// class that represents employee object for employee updates
    /// </summary>
    public class Employee: IStatelessResource, IIdentifiable<int>
    {
        /// <summary>
        /// class constructor
        /// </summary>
        public Employee()
        {
            PaidDaysOff = 10;
            PaidHoursOff = 80;
            MinimumTimeBetweenShifts = 0;
            MaximumDaysRowWorked = 5;
            MinimumShift = 0;
            MaximumShift = 10;
        }
        /// <summary>
        /// gets or sets the first name of the employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// gets or sets the last name of the employee
        /// </summary>
        public string LastName { get; set; }
      
        /// <summary>
        /// gets or sets the levels for this employee
        /// </summary>
        public PermissionLevel[] PermissionLevels { get; set; }

        /// <summary>
        /// gets or sets the position, this will be mapped to JobTitle of UserManager
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// gets or sets the primary location
        /// </summary>
        public  string PrimaryLocation { get; set; }

        /// <summary>
        /// gets or sets the userid for this employee
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// gets or sets the locations, the item is mapped to the ParentEntityId
        /// </summary>
        public int[] Locations { get; set; }

        /// <summary>
        /// gets or sets the email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// gets or sets the phone
        /// </summary>
        public Phone Phone { get; set; }

        /// <summary>
        /// gets or sets the address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// gets or sets the job type
        /// </summary>
        public string JobType { get; set; }

        /// <summary>
        /// gets or sets the duration of the employee
        /// </summary>
        public int EmploymentDuration { get; set; }

        /// <summary>
        /// gets or sets the paid days off
        /// </summary>
        public int PaidDaysOff { get; set; }

        /// <summary>
        /// gets or sets the paid hours off
        /// </summary>
        public int PaidHoursOff { get; set; }

        /// <summary>
        /// gets or sets the name of approver
        /// </summary>
        public string Approver { get; set; }

        /// <summary>
        /// gets or sets the time between shifts
        /// </summary>
        public int MinimumTimeBetweenShifts { get; set; }

        /// <summary>
        /// gets or sets the days row worked
        /// </summary>
        public int MaximumDaysRowWorked { get; set; }

        /// <summary>
        /// gets or sets the overtime setting
        /// </summary>
        public OverTimeSetting OverTimeSetting { get; set; }

        /// <summary>
        /// gets or sets the minimum shift length in hours
        /// </summary>
        public int MinimumShift { get; set; }

        /// <summary>
        /// gets or sets the maximum shift length in hours
        /// </summary>
        public int MaximumShift { get; set; }

        //TODO:look for an Asset object in RQ, to be verified first
        /// <summary>
        /// gets or sets the image of an employee
        /// </summary>
        public object Avatar { get; set; }

        /// <summary>
        /// gets or sets the employee id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// gets or sets the availability of the employee
        /// </summary>
        public Availability Availability { get; set; }
    }
}
