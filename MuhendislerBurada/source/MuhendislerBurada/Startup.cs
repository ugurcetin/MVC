using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MuhendislerBurada.Startup))]
namespace MuhendislerBurada
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
