using System.Web.Http;
using IQ.Platform.HumanResources.WebApi.Infrastructure;

namespace IQ.Platform.Humanity.Integration.WebApi
{

    public class HttpServerFactory
    {
        public HttpServer Create()
        {
            return new HttpServer(GetHttpConfiguration());
        }

        private static HttpConfiguration GetHttpConfiguration()
        {
            var config = new HttpConfiguration();
            BootStrapper.Initialize(config);
            return config;
        }
    }
}