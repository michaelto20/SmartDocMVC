using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartDocMVC.Startup))]
namespace SmartDocMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
