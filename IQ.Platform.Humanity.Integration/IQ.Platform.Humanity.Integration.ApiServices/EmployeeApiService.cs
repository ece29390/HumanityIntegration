using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IQ.Platform.Framework.WebApi;
using IQ.Platform.Framework.WebApi.Services.Security;
using IQ.Platform.Humanity.Integration.ApiServices.Security;
using IQ.Platform.HumanResources.Model.SupportResources;

namespace IQ.Platform.HumanResources.ApiServices
{
    public class EmployeeApiService : IEmployeeApiService
    {
        private IApiUserProvider<IntegrationApiUser> _userProvider;

        public EmployeeApiService(IApiUserProvider<IntegrationApiUser> userProvider)
        {
            if (userProvider == null)
                throw new ArgumentNullException("userProvider");
            _userProvider = userProvider;
        }

        public Task<ResourceCreationResult<Employee, int>> CreateAsync(Employee resource, IRequestContext context, CancellationToken cancellation)
        {

            throw new NotImplementedException();
        }

        public Task DeleteAsync(ResourceOrIdentifier<Employee, int> input, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetAsync(int id, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Employee>> GetManyAsync(IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateAsync(Employee resource, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
