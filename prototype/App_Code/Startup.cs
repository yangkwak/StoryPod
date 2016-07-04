using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prototype.Startup))]
namespace prototype
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
