using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;
using MyFirstWebAPI.Services;
using System.Runtime.CompilerServices;

namespace MyFirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMyService _myService;

        public ProductsController(IMyService myService) {

            _myService=myService;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var products = _myService.GetAll(); 
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var products = _myService.GetAll();
            var product = products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
