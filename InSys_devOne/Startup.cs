using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InSys_devOne.Startup))]
namespace InSys_devOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
