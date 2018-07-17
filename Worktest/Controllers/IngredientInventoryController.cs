using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Controllers
{

    public class IngredientInventoryController : Controller
    {

        private readonly IIngredientInventory _ingredientInventoryRepo;

        public IngredientInventoryController(IIngredientInventory ingredientInventoryRepo)
        {
            this._ingredientInventoryRepo = ingredientInventoryRepo;
        }


        [HttpGet("api/ingredient-inventory")]
        public async Task<IEnumerable<IngredientInventoryModel>> GetIngredientInventory()
        {
            var data = await this._ingredientInventoryRepo.GetAllIngredientInventory();
            return data;
        }



        [HttpPost("api/save-ingredient")]
        public async Task<bool> SaveIngredientUnit([FromBody] IngredientTotalUnitModel model)
        {
            return await this._ingredientInventoryRepo.SaveIngredientInventory(model);
        }


    }
}
