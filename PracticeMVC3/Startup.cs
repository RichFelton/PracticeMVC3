using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeMVC3.Startup))]
namespace PracticeMVC3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
