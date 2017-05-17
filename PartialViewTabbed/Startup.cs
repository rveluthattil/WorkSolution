using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialViewTabbed.Startup))]
namespace PartialViewTabbed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
