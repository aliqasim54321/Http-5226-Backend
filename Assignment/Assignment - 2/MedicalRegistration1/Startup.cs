using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedicalRegistration1.Startup))]
namespace MedicalRegistration1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
