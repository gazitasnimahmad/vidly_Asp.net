using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_Asp.net.Startup))]
namespace vidly_Asp.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
