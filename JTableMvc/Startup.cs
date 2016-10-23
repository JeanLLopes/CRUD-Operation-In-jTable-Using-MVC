using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JTableMvc.Startup))]
namespace JTableMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
