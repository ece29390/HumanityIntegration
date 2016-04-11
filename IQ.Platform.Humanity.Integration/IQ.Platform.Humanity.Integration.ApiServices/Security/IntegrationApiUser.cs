using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.AspNet;
using IQ.Platform.Framework.WebApi.Services.Security;

namespace IQ.Platform.Humanity.Integration.ApiServices.Security
{

    public class IntegrationApiUser : ApiUser<UserAuthData>
    {
        public IntegrationApiUser(string name, Option<UserAuthData> authData)
            : base(authData)
        {
            Name = name;
        }

        public string Name { get; private set; }

    }

    public class IntegrationUserFactory : ApiUserFactory<IntegrationApiUser, UserAuthData>
    {
        public IntegrationUserFactory() :
            base(new HttpRequestDataStore<UserAuthData>())
        {
        }

        protected override IntegrationApiUser CreateUser(Option<UserAuthData> auth)
        {
            return new IntegrationApiUser("Integration user", auth);
        }
    }

}
