using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace MVC_Auth_5._0.Controllers
{
    public class RoutesController : Controller
    {
        public object Index([FromServices] IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            return null;
        }
    }
}