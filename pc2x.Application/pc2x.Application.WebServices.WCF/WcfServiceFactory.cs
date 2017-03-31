
using pc2x.Application.Repositories.Repositories;
using pc2x.Application.Services.Services;
using SimpleInjector;
using SimpleInjector.Integration.Wcf;
using System;
using System.Linq;
using System.Reflection;
using System.ServiceModel;

namespace pc2x.Application.WebServices.WCF
{
    public class WcfServiceFactory : SimpleInjectorServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new SimpleInjectorServiceHost(Bootsrapper.Container, serviceType, baseAddresses);
        }
    }

    public static class Bootsrapper
    {
        public static readonly Container Container;

        static Bootsrapper()
        {
            var container = new Container();
            container.Options.DefaultLifestyle = new WcfOperationLifestyle();


            RegisterDependency(typeof(PaisRepository).Assembly,
               "pc2x.Application.Repositories.Repositories", ref container);

            RegisterDependency(typeof(PaisServicio).Assembly,
               "pc2x.Application.Services.Services", ref container);

            container.Register<IPaisContract, ApplicationService>();

            //manual registration
            //container.Register<IPaisRepository, PaisRepository>();
            //container.Register<IPaisService, PaisServicio>();
            //container.Verify();

            Container = container;
        }

        private static void RegisterDependency(Assembly assembly, string classNameSpace, ref Container container)
        {
            var types = assembly.GetExportedTypes().ToList();

            var registrations =
                (from type in types
                 where (!string.IsNullOrEmpty(type.Namespace)) && type.Namespace.Equals(classNameSpace)
                 where type.GetInterfaces().Any()
                 select new
                 {
                     Services = type.GetInterfaces().ToList(),
                     Implementation = type
                 });

            foreach (var reg in registrations)
            {
                if (Convert.ToString(reg.Implementation.Attributes).ToLower()
                    .Contains("abstract")) continue;

                foreach (var service in reg.Services.Where(service => !service.ContainsGenericParameters))
                {
                    container.Register(service, reg.Implementation);
                }
            }
        }
    }
}