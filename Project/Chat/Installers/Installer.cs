using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Chat.ViewModels;
using Chat.Views;


namespace Chat.Installers
{
	public class Installer : IWindsorInstaller
	{
		public void Install(IWindsorContainer container, IConfigurationStore store)
		{
			container.Register(Component.For<MainWindowView>().LifestyleSingleton());
			container.Register(Component.For<MainWindowViewModel>().LifestyleSingleton());
		}
	}
}