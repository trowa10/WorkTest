using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Controllers
{
  //  [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        private readonly IIngredient _ingredientRepo;

        public IngredientController(IIngredient ingredientRepo)
        {
            this._ingredientRepo = ingredientRepo;
        }

        [HttpGet("api/ingredients")]
        public async Task<IEnumerable<IngredientModel>> Get()
        {
            var data = await this._ingredientRepo.GetIngredients();
            return data;
        }
    }
}