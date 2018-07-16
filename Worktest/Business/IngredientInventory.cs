using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public class IngredientInventory : IIngredientInventory
    {
        public Task<bool> DeleteIngredientInventoryByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IngredientInventoryModel>> GetAllIngredientInventory()
        {
            return await this.GetProductIngredientUnitModel();
        }

        public Task<bool> SaveIngredientInventory(TblIngredientInventory model)
        {
            throw new NotImplementedException();
        }

        private async Task<List<IngredientInventoryModel>> GetProductIngredientUnitModel()
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {             

                var IngredientInventories = db.TblIngredientInventory.Select(a => new IngredientInventoryModel
                {
                    Id = a.Id,
                    IngredientName = a.IngredientName,
                    TotalUnit = a.TotalUnit
                });

                return await IngredientInventories.ToListAsync();


            }
        }
    }
}
