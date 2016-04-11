using System;

namespace IQ.Platform.HumanResources.WebApi.Handlers
{
    public class NullUserContext : IDisposable
    {
        public void Dispose() { }
    }
}