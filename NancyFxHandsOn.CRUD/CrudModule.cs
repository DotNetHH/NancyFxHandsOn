
using Nancy;

namespace NancyFxHandsOn.CRUD
{
    public class CrudModule : NancyModule
    {
        private readonly ICrudRepository _repository;

        public CrudModule(/* try adding an ICrudRepository parameter here */) // google "Nancy TinyIoC", it will inject your dependency ;)
            : base("crud")
        {
            // Create
            Post["/"] = _ => View["Views/crud"];
            // Read
            Get["/"] = _ => View["Views/crud", new Person { Id = 0, FirstName = "Kjellski", LastName = "Otto" }];
            // Update
            Put["/"] = _ => View["Views/crud"];
            // Delete
            Delete["/"] = _ => View["Views/crud"];
        }
    }
}