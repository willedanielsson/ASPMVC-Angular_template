using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularApplicationTest.Startup))]
namespace AngularApplicationTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
