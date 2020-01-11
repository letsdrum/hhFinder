using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hhFinder.Web.Startup))]
namespace hhFinder.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
