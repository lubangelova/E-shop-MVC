using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_shop_MVC.Web.Startup))]
namespace E_shop_MVC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
