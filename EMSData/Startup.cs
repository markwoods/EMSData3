using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EMSData.Startup))]
namespace EMSData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
