using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IQ.Platform.Framework.WebApi;
using IQ.Platform.HumanResources.Model.SupportResources;

namespace IQ.Platform.HumanResources.ApiServices
{
    public class LocationApiService : ILocationApiService
    {
        public Task<ResourceCreationResult<Location, int>> CreateAsync(Location resource, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ResourceOrIdentifier<Location, int> input, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Location> GetAsync(int id, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Location>> GetManyAsync(IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Location> UpdateAsync(Location resource, IRequestContext context, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
