using Nancy.DemoApplication1.Model;
using Nancy.ModelBinding;
using System;

namespace Nancy.DemoApplication1.Modules
{
    public class NestedRouteModule : NancyModule
    {
        public NestedRouteModule()
            : base("nested")
        {
            Get["/array"] = _ => "[" + String.Join(", ", new[] { 1, 2, 3, 4, 5 }) + "]";
            Post["/log"] = parameter =>
            {
                var logEntry = this.Bind<LogEntry>();
                Console.WriteLine(logEntry);
                return "logged " + logEntry.Title;
            };
        }
    }
}