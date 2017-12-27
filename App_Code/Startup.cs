using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocuSignSample.Startup))]
namespace DocuSignSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
