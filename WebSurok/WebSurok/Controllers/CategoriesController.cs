using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSurok.Data;

namespace WebSurok.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MyAppContext _appContext;

        public CategoriesController(MyAppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _appContext.Categories.ToList();
            return Ok(list);
        }
    }
}
