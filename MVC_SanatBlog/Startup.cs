using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_SanatBlog.Startup))]
namespace MVC_SanatBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
