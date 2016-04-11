﻿using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web.Http;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using IQ.Platform.Framework.Logging;
using IQ.Platform.Framework.WebApi.AspNet.Handlers;
using IQ.Platform.Framework.WebApi.Formatting;
using IQ.Platform.Framework.WebApi.Handlers;
using IQ.Platform.Framework.WebApi.Security;
using IQ.Platform.Framework.WebApi.Services.Installers;
using IQ.Platform.Framework.WebApi.Services.Security;
using IQ.Platform.Humanity.Integration.ApiServices;
using IQ.Platform.Humanity.Integration.ApiServices.Security;
using IQ.Platform.Humanity.Integration.WebApi.Infrastructure.Installers;
using IQ.Platform.Framework.WebApi.Infrastructure;
using IQ.Platform.HumanResources.ApiServices;
using IQ.Platform.HumanResources.Documentation.Installers;
using IQ.Platform.HumanResources.Model;
using IQ.Platform.HumanResources.WebApi.Handlers;
using IQ.Platform.HumanResources.WebApi.Hypermedia;
using IQ.Platform.HumanResources.WebApi.Infrastructure.Installers;

namespace IQ.Platform.HumanResources.WebApi.Infrastructure
{

    public class DefaultApiContainer : ApiContainer
    {

        readonly IDomainServiceResolver _domainServiceResolver;
        readonly Assembly _apiDomainServicesAssembly = typeof(ISampleApiService).Assembly;
        readonly Assembly _resourceMappersAssembly = typeof(SampleApiService).Assembly;


        public DefaultApiContainer(HttpConfiguration configuration, IWindsorContainer windsorContainer, IDomainServiceResolver domainServiceResolver = null)
            : base(configuration, windsorContainer)
        {
            _domainServiceResolver = domainServiceResolver;
        }

        public override Assembly ResourceAssembly { get { return typeof(LinkRelations).Assembly; } }
        protected override Assembly ResourceSpecsAssembly { get { return typeof(SampleSpec).Assembly; } }
        protected override Assembly ResourceStateProvidersAssembly { get { return typeof(SampleSpec).Assembly; } }
        protected override Assembly ApiAppServicesAssembly { get { return typeof(SampleApiService).Assembly; } }


        protected override void RegisterCustomDependencies()
        {

            _windsorContainer
                .Install(new IWindsorInstaller[]
                         {
                             new DomainServicesInstaller(_domainServiceResolver, _apiDomainServicesAssembly, _apiDomainServicesAssembly),
                             new ResourceMapperInstaller(_resourceMappersAssembly),
                             new HelpControllerInstaller(),
							 //TODO: It requires the "IQ.Auth.OAuth2.ProtectedResource.ZeroMQ.ZeroMQServerAddress" app setting. The AlwaysAuthenticateRequestAuthenticator has to be commented out as well
							 new OAuthProtectedResourceComponentsInstaller(),
                             new SecurityMessageHandlersInstaller(Assembly.GetExecutingAssembly()),
                         })
                         .InstallLogging();

            //_windsorContainer.Register(Component.For<IApiUserFactory<ApiUser<UserAuthData>>>().ImplementedBy<DefaultApiUserFactory<UserAuthData>>());
            _windsorContainer.Register(Component.For<IRequestAuthenticator<UserAuthData>>().ImplementedBy<DefaultSsoBasedRequestAuthenticator>());

        }

        protected override IEnumerable<DelegatingHandler> ResolveMessageHandlersInternal()
        {

            yield return ResolveTraceContextHandler();
            yield return ResolveAuthenticationMessageHandler();
            yield return ResolveSecurityContextMessageHandler();

        }

        DelegatingHandler ResolveAuthenticationMessageHandler()
        {
            return
                //TODO: could it be registered entirely with .IsDefault() and if necessary, overrode in tests by FakeRequestAuthenticator?
                new DefaultAuthenticationMessageHandler<UserAuthData>(
                    _windsorContainer.Resolve<IRequestAuthenticator<UserAuthData>>());
        }

        DelegatingHandler ResolveSecurityContextMessageHandler()
        {
            return
                _windsorContainer.Resolve<ApiSecurityContextProvidingHandler<IntegrationApiUser, NullUserContext>>();
        }

        TraceContextHandler ResolveTraceContextHandler()
        {
            return new TraceContextHandler(_configuration.GetHypermediaConfiguration());
        }

        protected override IEnumerable<MediaTypeFormatter> ResolveMediaTypeFormattersInternal()
        {
            yield return HalJsonFormatter.Create();
            yield return PlainJsonFormatter.Create();
        }


    }
}
