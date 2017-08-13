using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector.Integration.WebApi;
using System;
using System.Web.Http;

namespace Kasbaah.Injetor
{
	public class Injetor
    {
		private static Container container = new Container();

		public static Container GetContainer
		{
			get
			{
				return container;
			}
		}

		public static void Iniciar()
		{
			Iniciar(IniciarContainer);
		}

		public static void Iniciar(HttpConfiguration global)
		{
			Iniciar(global, IniciarContainer);
		}

		public static void Iniciar(HttpConfiguration global, Action<Container> DelegateIniciarContainer)
		{
			container = new Container();
			DelegateIniciarContainer(container);
			global.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
		}

		public static void Iniciar(Action<Container> DelegateIniciarContainer)
		{
			container = new Container();
			DelegateIniciarContainer(container);
			System.Web.Mvc.DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
		}

		private static void IniciarContainer(Container container)
		{
			
		}

		public static T ObterInstanciaDe<T>()
		{
			return (T)container.GetInstance(typeof(T));
		}
	}
}
