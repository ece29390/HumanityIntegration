using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ.Platform.Framework.WebApi.Hypermedia;
using IQ.Platform.Framework.WebApi.Hypermedia.Specs;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;
using IQ.Platform.HumanResources.Model;
using IQ.Platform.HumanResources.Model.SupportResources;

namespace IQ.Platform.HumanResources.WebApi.Hypermedia
{
    public class EmployeeSpec: SingleStateResourceSpec<Employee,int>
    {
        public static ResourceUriTemplate Uri = ResourceUriTemplate.Create("Employees({id})");

        public override string EntrypointRelation
        {
            get { return LinkRelations.Employee; }
        }


      
    }
}