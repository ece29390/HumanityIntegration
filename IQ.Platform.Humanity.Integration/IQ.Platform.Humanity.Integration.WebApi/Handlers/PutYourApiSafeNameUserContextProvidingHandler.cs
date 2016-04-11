using IQ.Platform.Framework.WebApi.AspNet;
using IQ.Platform.Framework.WebApi.AspNet.Handlers;
using IQ.Platform.Framework.WebApi.Services.Security;
using IQ.Platform.Humanity.Integration.ApiServices.Security;

namespace IQ.Platform.HumanResources.WebApi.Handlers
{
    public class PutYourApiSafeNameUserContextProvidingHandler
            : ApiSecurityContextProvidingHandler<IntegrationApiUser, NullUserContext>
    {

        public PutYourApiSafeNameUserContextProvidingHandler(
            IStoreDataInHttpRequest<IntegrationApiUser> apiUserInRequestStore)
            : base(new IntegrationUserFactory(), CreateContextProvider(), apiUserInRequestStore)
        {
        }

        static ApiUserContextProvider<IntegrationApiUser, NullUserContext> CreateContextProvider()
        {
            return
                new ApiUserContextProvider<IntegrationApiUser, NullUserContext>(_ => new NullUserContext());
        }
    }
}