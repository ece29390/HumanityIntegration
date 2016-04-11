using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.WebApi;
using IQ.Platform.HumanResources.Model.SupportResources;

namespace IQ.Platform.HumanResources.ApiServices
{
    public interface IEmployeeApiService:
        ICreateAResourceAsync<Employee,int>,
        IUpdateAResourceAsync<Employee,int>,
        IDeleteResourceAsync<Employee,int>,
        IGetAResourceAsync<Employee, int>,
        IGetManyOfAResourceAsync<Employee, int>
    {
    }
}
