using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureAspMVC01.Startup))]
namespace AzureAspMVC01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
