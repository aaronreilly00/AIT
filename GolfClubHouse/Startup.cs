using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfClubHouse.Startup))]
namespace GolfClubHouse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
