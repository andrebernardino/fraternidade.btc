using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fraternidade.btc.Startup))]
namespace fraternidade.btc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
