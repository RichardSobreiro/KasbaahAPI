using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace Kasbaah.API
{
	public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
			var config = new HttpConfiguration();

			config.SuppressDefaultHostAuthentication();
									  
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

			Injetor.Injetor.Iniciar();

			config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Injetor.Injetor.GetContainer);

			return config;
		}
    }
}
