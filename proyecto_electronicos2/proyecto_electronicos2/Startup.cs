using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_electronicos2.Startup))]
namespace proyecto_electronicos2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
