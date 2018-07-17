using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Controllers
{
    public class ProdIngredientUnitController : Controller
    {    
        private readonly IProductIngredientUnit _prodIngredirntRepo;

        public ProdIngredientUnitController(IProductIngredientUnit prodIngredirntRepo)
        {
            this._prodIngredirntRepo = prodIngredirntRepo;
        }     

        [HttpGet("api/product-ingredient-units")]
        public async Task<IEnumerable<ProductIngredientUnitModel>> GetProdIngredientUnits()
        {
            var data = await this._prodIngredirntRepo.GetProductIngredientUnit();
            return data;
        }


    }
}
