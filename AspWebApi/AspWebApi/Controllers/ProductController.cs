using AspWebApi.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace AspWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductEntity>>> Get()
        {
            return Ok(await _dataContext.Products.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductEntity>> Get(int id)
        {
            var product = await _dataContext.Products.FindAsync(id);
            if (product == null)
            {
                return BadRequest("Ürün Bulunamadı");
            }
            else
            {
                return Ok(product);
            }
        }
        [HttpPost]
        public async Task<ActionResult<List<ProductEntity>>> AddProduct(ProductEntity product)
        {
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Products.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<ProductEntity>>> UpdateProduct(ProductEntity reqx)
        {
            var product = await _dataContext.Products.FindAsync(reqx.Id);
            if (product == null) 
            {
                return BadRequest("Değiştirilecek Ürün Bulunamadı");
            }
            else
            {
                product.Name = reqx.Name;
                product.Price = reqx.Price;
                await _dataContext.SaveChangesAsync();
                return Ok(await _dataContext.Products.ToListAsync());
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ProductEntity>>> DeleteProd(int id)
        {
            var product = await _dataContext.Products.FindAsync(id);
            if (product == null)
                return BadRequest("Ürün Bulunamadı");
            _dataContext.Products.Remove(product);
            await _dataContext.SaveChangesAsync();
            return Ok(await _dataContext.Products.ToListAsync());
        }

    }
}
