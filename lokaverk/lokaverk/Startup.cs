using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lokaverk.Startup))]
namespace lokaverk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
