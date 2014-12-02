using Nancy.ErrorHandling;
using Nancy.Responses;

namespace Nancy.DemoApplication1
{
    // No need to register this file, Nancy will find all IStatusCodeHandler instances
    public class NotFoundStatusCodeHandler : IStatusCodeHandler
    {
        public bool HandlesStatusCode(HttpStatusCode statusCode, NancyContext context)
        {
            return statusCode == HttpStatusCode.NotFound;
        }

        public void Handle(HttpStatusCode statusCode, NancyContext context)
        {
            context.Response = new TextResponse("Whoops, could not find the page!");
        }
    }
}