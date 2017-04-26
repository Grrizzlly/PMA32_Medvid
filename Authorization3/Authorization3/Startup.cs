using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authorization3.Startup))]
namespace Authorization3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
