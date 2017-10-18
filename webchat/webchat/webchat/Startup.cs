using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webchat.Startup))]
namespace webchat
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
