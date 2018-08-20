using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Farra.Startup))]
namespace Farra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
