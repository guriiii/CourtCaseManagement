using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourtCaseManagement.Startup))]
namespace CourtCaseManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
