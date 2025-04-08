using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly MyDbContext _context;
        public ProductController(MyDbContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public IActionResult GetProducts()
        {
            var product = _context.Products.ToList();
            return Ok(product);
        }
     
        [HttpGet("id")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("ByName")]
        public IActionResult GetProductByName(string name)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductsName == name);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("FirstCategory")]
        public IActionResult GetFirstProduct()
        {
            var product = _context.Products.FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }









    }
}
