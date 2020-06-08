using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiscussionForumMVC.Startup))]
namespace DiscussionForumMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
