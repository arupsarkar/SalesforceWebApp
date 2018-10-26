using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesforceWebApp.Startup))]
namespace SalesforceWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
