using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreApi.Server.IDataService;

namespace CoreApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IDataservice _data;
        public CategoryController(IDataservice data)
        {
            _data = data;
        }

        // GET: api/Category
        [HttpGet]
        public IActionResult GetCategories()
        {
           var category= _data.GetCategories();
            return Ok(category);

        }
        // GET: api/Category/5
        [HttpGet("id")]
        public IActionResult GetCategory(int id)
        {
            var category = _data.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("ByName")]
        public IActionResult GetCategoryByName(string name)
        {
            var category = _data.GetCategoryByName(name);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpGet("FirstCategory")]
        public IActionResult GetFirstCategory()
        {
            var category = _data.GetFirstCategory();
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }






    }
}
