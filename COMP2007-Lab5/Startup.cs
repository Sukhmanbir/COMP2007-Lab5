using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COMP2007_Lab5.Startup))]
namespace COMP2007_Lab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
