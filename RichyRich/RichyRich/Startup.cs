using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RichyRich.Startup))]
namespace RichyRich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
