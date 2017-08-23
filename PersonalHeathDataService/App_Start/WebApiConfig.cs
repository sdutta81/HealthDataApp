using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;

namespace PersonalHeathDataService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            //builder.RegisterType<AuthorizationOwinMiddleware>();

            // Register your Web API controllers.            
            builder.RegisterModule(new PHDSBootstrapper());
            builder.RegisterApiControllers(PHDSBootstrapper.Assembly);

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/profile",
                defaults: new { id = RouteParameter.Optional }
            );

            PHDSBootstrapper.Container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(PHDSBootstrapper.Container);
        }
    }
}
