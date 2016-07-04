using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoryPod.Startup))]
namespace StoryPod
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
