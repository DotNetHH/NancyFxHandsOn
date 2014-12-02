using Nancy.Responses;

namespace Nancy.DemoApplication1.Modules
{
    public class SecureModule : NancyModule
    {
        public SecureModule()
        {
            Before += OnBefore;

            Get["/secure"] = _ => View["secure"];
        }

        private Response OnBefore(NancyContext ctx)
        {
            if (ctx.Request.Query.password != "geheim")
            {
                return new HtmlResponse(HttpStatusCode.Unauthorized);
            }

            return null; // Not handled
        }
    }
}