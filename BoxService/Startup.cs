using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoxService.Startup))]
namespace BoxService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
