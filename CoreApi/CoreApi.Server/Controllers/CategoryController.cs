using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly MyDbContext _context;
        public CategoryController(MyDbContext context)
        {
            _context = context;
        }

        // GET: api/Category
        [HttpGet]
        public IActionResult GetCategories()
        {
           var category= _context.Categories.ToList();
            return Ok(category);
        }
        // GET: api/Category/5
        [HttpGet("id")]
        public IActionResult GetCategory(int id)
        {
            var category =  _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("ByName")]
        public IActionResult GetCategoryByName(string name)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryName == name);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("FirstCategory")]
        public IActionResult GetFirstCategory()
        {
            var category = _context.Categories.FirstOrDefault();
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }






    }
}
