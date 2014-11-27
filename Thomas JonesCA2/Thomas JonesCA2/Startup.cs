using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thomas_JonesCA2.Startup))]
namespace Thomas_JonesCA2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
