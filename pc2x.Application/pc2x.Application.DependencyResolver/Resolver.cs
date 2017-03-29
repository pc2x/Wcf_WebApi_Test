
using SimpleInjector;

namespace pc2x.Application.DependencyResolution
{
    public class Resolver
    {
        public static void Resolve()
        {
            var container = new Container();

            container.Verify();

            //new SimpleInjectorDependencyResolver(container)



            //DependencyResolver.SetResolver();
            // This is an extension method from the integration package.
            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            //container.Options.DefaultLifestyle
        }
    }
}
