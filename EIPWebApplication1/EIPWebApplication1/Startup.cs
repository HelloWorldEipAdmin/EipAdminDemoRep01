using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EIPWebApplication1.Startup))]
namespace EIPWebApplication1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
