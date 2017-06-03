using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AboveThePin.Startup))]
namespace AboveThePin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
