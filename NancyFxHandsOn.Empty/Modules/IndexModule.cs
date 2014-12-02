using System.Security.Cryptography.X509Certificates;
using Nancy;

namespace NancyFxHandsOn.Empty.Modules
{
    // No need to configure anything. Not even a bootstrapper is required!
    // Just add a reference to Nancy and add the modules!
    public class IndexModule : NancyModule
    {
        // Even with dependency injection without any configuration.
        public IndexModule(IInjectee injectee)
        {
            Get["/"] = _ => "Hallo Nancy!";
            Get["/hello/{name}"] = _ => injectee.Greeter(_.name);
            Get["/{rest*}"] = _ => "You accessed: " + _.rest;
        }
    }

    public interface IInjectee
    {
        string Greeter(string name);
    }

    public class Injectee : IInjectee
    {
        public string Greeter(string name)
        {
            return string.Format("Hallo {0}!!", name);
        }
    }
}