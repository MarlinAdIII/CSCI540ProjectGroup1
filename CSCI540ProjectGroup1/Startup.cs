using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSCI540ProjectGroup1.Startup))]
namespace CSCI540ProjectGroup1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
