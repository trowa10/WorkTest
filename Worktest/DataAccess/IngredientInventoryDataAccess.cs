using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.DataAccess
{
    public class IngredientInventoryDataAccess
    {
        public async Task<List<IngredientInventoryModel>> GetIngredientUnits()
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {

                var IngredientInventories = db.TblIngredientInventory.Select(a => new IngredientInventoryModel
                {
                    Id = a.Id,
                    IngredientName = a.IngredientName,
                    TotalUnit = a.TotalUnit
                }).OrderByDescending(x => x.Id);

                return await IngredientInventories.ToListAsync();

            }
        }


        public async Task<bool> SaveIngredientInventory(IngredientTotalUnitModel model)
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {
                var ingredientTotalUnit = db.TblIngredientInventory.Where
                        (x => x.IngredientName == model.IngredientName).FirstOrDefault();
                if (ingredientTotalUnit == null)
                {
                    ingredientTotalUnit = new TblIngredientInventory()
                    {
                        IngredientName = model.IngredientName,
                        TotalUnit = model.TotalUnit
                    };
                    db.TblIngredientInventory.Add(ingredientTotalUnit);

                }
                else
                {
                    ingredientTotalUnit.IngredientName = model.IngredientName;
                    ingredientTotalUnit.TotalUnit = model.TotalUnit;
                   
                }

                return await db.SaveChangesAsync() >= 1;
            }
        }
    }
}
