using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.WebApi;
using IQ.Platform.HumanResources.Model.SupportResources;

namespace IQ.Platform.HumanResources.ApiServices
{
    public interface ILocationApiService:
        ICreateAResourceAsync<Location,int>,
        IUpdateAResourceAsync<Location,int>,
        IDeleteResourceAsync<Location,int>,
        IGetAResourceAsync<Location, int>, 
        IGetManyOfAResourceAsync<Location, int>
    {
    }
}
