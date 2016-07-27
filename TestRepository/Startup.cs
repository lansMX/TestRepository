using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepository.Startup))]
namespace TestRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
