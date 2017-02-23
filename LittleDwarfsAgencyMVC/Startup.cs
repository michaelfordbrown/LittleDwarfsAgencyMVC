using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LittleDwarfsAgencyMVC.Startup))]
namespace LittleDwarfsAgencyMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
