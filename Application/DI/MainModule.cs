using Autofac;

namespace DAS.Application.DI
{
    public class MainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.Load("DAS.Infrastructure"))
                   .Where(t => t.Name.EndsWith("Repository") || t.Name.EndsWith("Manager"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}
