using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(www_ROCholet.Startup))]
namespace www_ROCholet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
