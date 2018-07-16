using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Worktest.Business;
using Worktest.Models;

namespace Worktest.Controllers
{
    [Route("api/[controller]")]
    public class IngredientInventoryController : Controller
    {    

        private readonly IIngredientInventory _ingredientInventoryRepo;

        public IngredientInventoryController(IIngredientInventory ingredientInventoryRepo)
        {
            this._ingredientInventoryRepo = ingredientInventoryRepo;
        }


        [HttpGet("[action]")]
        public async Task<IEnumerable<IngredientInventoryModel>> GetIngredientInventory()
        {
            var data = await this._ingredientInventoryRepo.GetAllIngredientInventory();
            return data;
        }


    }
}
