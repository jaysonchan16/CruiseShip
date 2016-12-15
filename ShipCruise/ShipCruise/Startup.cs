using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShipCruise.Startup))]
namespace ShipCruise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
