using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CryptoStore.Web.Startup))]
namespace CryptoStore.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
