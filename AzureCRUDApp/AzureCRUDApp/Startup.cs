using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureCRUDApp.Startup))]
namespace AzureCRUDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
