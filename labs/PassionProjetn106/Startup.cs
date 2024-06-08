using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PassionProjetn106.Startup))]
namespace PassionProjetn106
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
