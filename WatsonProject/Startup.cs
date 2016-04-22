using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WatsonProject.Startup))]
namespace WatsonProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
