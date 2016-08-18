using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenWebII.Startup))]
namespace ExamenWebII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
