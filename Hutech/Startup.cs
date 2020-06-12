using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hutech.Startup))]
namespace Hutech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
