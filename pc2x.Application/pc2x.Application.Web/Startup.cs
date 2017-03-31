using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pc2x.Application.Web.Startup))]
namespace pc2x.Application.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
