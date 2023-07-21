using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLRelations.Data;
using SQLRelations.Models;

namespace SQLRelations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Product>>> Get(int categoryId)
        //{
        //    var products=await _dataContext.products.Where(c=>c.CategoryID==categoryId).ToListAsync();
        //    return products;
        //}

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct(int categoryId)
        {
            var products=await _dataContext.products.Where(c=>c.CategoryID==categoryId).Include(s=>s.Size).ToListAsync();
            return products;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>>Get(int categoryId)
        {
            var product = await _dataContext.products.Where(c => c.CategoryID == categoryId).ToListAsync();
            return product;
        }

        //[HttpGet("{productId:int")]
        //public async Task<ActionResult<Size>> GetProductSize(int productId)
        //{
        //    var size=await _dataContext.sizes.FirstOrDefaultAsync((p=>p.ProductId==productId));
        //    return size;

        //}
    }
}
