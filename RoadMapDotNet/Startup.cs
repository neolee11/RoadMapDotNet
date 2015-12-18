using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoadMapDotNet.Startup))]
namespace RoadMapDotNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
