using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InitialSite.Startup))]
namespace InitialSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
