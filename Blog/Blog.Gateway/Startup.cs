using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog.Gateway.Startup))]
namespace Blog.Gateway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
