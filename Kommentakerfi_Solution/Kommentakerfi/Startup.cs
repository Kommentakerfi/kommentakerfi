using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kommentakerfi.Startup))]
namespace Kommentakerfi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
