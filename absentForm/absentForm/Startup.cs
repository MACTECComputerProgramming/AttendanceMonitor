using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(absentForm.Startup))]
namespace absentForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
