using Microsoft.AspNetCore.Mvc;

namespace isguvenli.Controllers
{
    public class isguvenliController : Controller
    {
        public IActionResult isguvenli()
        {
            return View();
        }

        



        [Route("isguvenli/Liste/{id}")]
        public string Liste(int id) {
            return $"parametrenin gsterdiği değer:{id}";
        }
    }
}
