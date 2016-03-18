using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(efStuffs1.Startup))]
namespace efStuffs1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
