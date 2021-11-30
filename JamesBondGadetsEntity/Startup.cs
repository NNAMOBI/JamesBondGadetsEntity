using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamesBondGadetsEntity.Startup))]
namespace JamesBondGadetsEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
