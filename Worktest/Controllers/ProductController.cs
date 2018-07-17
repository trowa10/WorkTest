using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Controllers
{
 
    public class ProductController : Controller
    {
        private readonly IProduct _productRepo;

        public ProductController(IProduct productRepo)
        {
            this._productRepo = productRepo;
        }

        [HttpGet("api/products")]
        public async Task<IEnumerable<TblProduct>> Get()
        {
            var data = await this._productRepo.GetProducts();
            return data;
        }
    }
}