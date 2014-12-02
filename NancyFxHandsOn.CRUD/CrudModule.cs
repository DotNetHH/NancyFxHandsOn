
using Nancy;

namespace NancyFxHandsOn.CRUD
{
    public class CrudModule : NancyModule
    {
        private readonly ICrudRepository _repository;

        /// <summary>
        /// Your CRUD Module with empty methods:
        /// 
        /// </summary>
        public CrudModule(ICrudRepository repository/* try adding an ICrudRepository parameter here */) // look up the Nancy TinyIoC
            : base("crud")
        {
            _repository = repository;
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