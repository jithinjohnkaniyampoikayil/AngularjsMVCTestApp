using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnjularMVCTestApp.Startup))]
namespace AnjularMVCTestApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
