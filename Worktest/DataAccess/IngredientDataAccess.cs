using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.DataAccess
{
    public class IngredientDataAccess
    {
        public async Task<List<IngredientModel>> GetIngredients()
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {

                var ingredients = db.TblIngredientInventory.Select(a => new IngredientModel
                {
                    Id = a.Id,
                    IngredientName = a.IngredientName
                });

                return await ingredients.ToListAsync();

            }
        }

       
    }
}
