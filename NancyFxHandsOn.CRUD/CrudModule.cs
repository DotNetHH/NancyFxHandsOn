
using Nancy;

namespace NancyFxHandsOn.CRUD
{
    public class CrudModule : NancyModule
    {
        /// <summary>
        /// Your CRUD Module with empty methods:
        /// 
        /// </summary>
        public CrudModule()
            : base("crud")
        {
            // Create
            Post["/"] = _ => View["Views/crud"];
            // Read
            Get["/"] = _ => View["Views/crud"];
            // Update
            Put["/"] = _ => View["Views/crud"];
            // Delete
            Delete["/"] = _ => View["Views/crud"];
        }
    }
}