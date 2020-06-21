using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A_Market.Startup))]
namespace A_Market
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
