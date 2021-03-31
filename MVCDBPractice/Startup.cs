using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCDBPractice.Startup))]
namespace MVCDBPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
