using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quanlinhahang1.Startup))]
namespace Quanlinhahang1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
