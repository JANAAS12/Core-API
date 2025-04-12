using CoreApi.Server.IDataService;
using CoreApi.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IDataservice _data;
        public ProductController(IDataservice data)
        {
            _data = data;
        }


        [HttpGet]
        public IActionResult GetProducts()
        {
            var product = _data.GetProducts();
            return Ok(product);
        }
     
        [HttpGet("id")]
        public IActionResult GetProduct(int id)
        {
            var product = _data.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("ByName")]
        public IActionResult GetProductByName(string name)
        {
            var product = _data.GetProductByName(name);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet("FirstCategory")]
        public IActionResult GetFirstProduct()
        {
            var product = _data.GetFirstProduct();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }









    }
}
