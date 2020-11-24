using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital.Web.Startup))]
namespace Hospital.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
