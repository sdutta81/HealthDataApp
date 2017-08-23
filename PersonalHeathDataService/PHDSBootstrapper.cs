using Autofac;
using System;
using System.Reflection;

namespace PersonalHeathDataService
{
    public class PHDSBootstrapper : Autofac.Module
    {
        private static IContainer container;
        private static object lockObj = new object();

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OwinContextMiddleware>();
        }

        public static Assembly Assembly
        {
            get
            {
                return Assembly.GetExecutingAssembly();
            }
        }

        public static IContainer Container
        {
            get
            {
                lock (lockObj)
                {
                    if (container == null)
                    {
                        ContainerBuilder builder = new ContainerBuilder();
                        builder.RegisterModule(new PHDSBootstrapper());
                        container = builder.Build();
                    }
                }

                return container;
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "IoC container cannot be null");
                lock (lockObj)
                {
                    container = value;
                }
            }
        }
    }
}