using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestLocalization.Startup))]
namespace TestLocalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
