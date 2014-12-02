using Nancy.Conventions;

namespace NancyFxHandsOn.CRUD
{
    using Nancy;

    public class ApplicationBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("scripts", @"scripts"));
            base.ConfigureConventions(nancyConventions);
        }
    }
}