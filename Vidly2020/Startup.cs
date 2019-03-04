using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly2020.Startup))]
namespace Vidly2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
