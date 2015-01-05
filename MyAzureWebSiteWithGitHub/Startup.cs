using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAzureWebSiteWithGitHub.Startup))]
namespace MyAzureWebSiteWithGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
