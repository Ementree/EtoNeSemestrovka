using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class UploadFileController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(IFormFile file)
        {
            return Ok();
        }
    }
}