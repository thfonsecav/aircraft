using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aircraft.Startup))]
namespace Aircraft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
