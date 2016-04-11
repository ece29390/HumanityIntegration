using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ.Platform.Framework.WebApi.Hypermedia.Specs;
using IQ.Platform.HumanResources.Model.SupportResources;
using IQ.Platform.Framework.WebApi.Hypermedia;
using IQ.Platform.HumanResources.Model;

namespace IQ.Platform.HumanResources.WebApi.Hypermedia
{
    public class LocationSpec: SingleStateResourceSpec<Location, int>
    {
        public static ResourceUriTemplate Uri = ResourceUriTemplate.Create("Locations({id})");

        public override string EntrypointRelation
        {
            get { return LinkRelations.Location; }
        }
    }
}