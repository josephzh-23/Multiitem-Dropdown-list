using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChoseninMvc.Startup))]
namespace ChoseninMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
