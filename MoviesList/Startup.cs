using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesList.Startup))]
namespace MoviesList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
