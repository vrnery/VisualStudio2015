using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testando.Startup))]
namespace Testando
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
