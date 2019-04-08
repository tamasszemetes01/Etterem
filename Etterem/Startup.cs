using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Etterem.Startup))]
namespace Etterem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
