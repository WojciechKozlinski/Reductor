using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reductor.WebPage.Startup))]
namespace Reductor.WebPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
