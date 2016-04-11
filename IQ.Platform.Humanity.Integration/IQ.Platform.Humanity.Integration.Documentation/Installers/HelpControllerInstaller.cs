using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IQ.Platform.Framework.WebApi.HelpGen;
using IQ.Platform.HumanResources.Documentation.Controllers;

namespace IQ.Platform.HumanResources.Documentation.Installers
{
    public class HelpControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IiQApiExplorer>().ImplementedBy<iQApiExplorer>().LifestyleTransient(),
                Component.For<IController>().ImplementedBy<HelpController>().LifestyleTransient()
                );
        }
    }
}
