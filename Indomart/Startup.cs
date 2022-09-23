using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Indomart.Startup))]
namespace Indomart
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
