using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(speedtrainVives.Startup))]
namespace speedtrainVives
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
