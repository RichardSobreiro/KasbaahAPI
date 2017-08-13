using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Kasbaah.API.Startup))]

namespace Kasbaah.API
{
	public partial class Startup
    {
		public void Configuration(IAppBuilder app)
		{
			app.UseWebApi(WebApiConfig.Register());
		}
    }
}
