using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alfa.Web.Startup))]
namespace Alfa.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
