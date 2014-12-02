using System.Diagnostics;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Nancy.DemoApplication1
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper
        public Bootstrapper()
        {
        }

        protected override void RequestStartup(TinyIoCContainer container, IPipelines pipelines, NancyContext context)
        {
            Trace.WriteLine(string.Format("Nancy request: {0} {1}", context.Request.Method, context.Request.Url));
        }
    }
}