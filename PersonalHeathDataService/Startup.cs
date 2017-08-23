using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Cors;

[assembly: OwinStartup(typeof(PersonalHeathDataService.Startup))]

namespace PersonalHeathDataService
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.UseAutofacMiddleware(PHDSBootstrapper.Container);
        }
    }
}