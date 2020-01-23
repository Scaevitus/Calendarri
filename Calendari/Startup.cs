using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Calendari.Startup))]
namespace Calendari
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
