namespace Nancy.DemoApplication1.Modules
{
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
            : base("")
        {
            Get["/"] = _ => View["index"];
        }
    }
}