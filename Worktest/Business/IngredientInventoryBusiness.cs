using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.DataAccess;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Business
{
    public class IngredientInventoryBusiness : IIngredientInventory
    {
        public Task<bool> DeleteIngredientInventoryByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IngredientInventoryModel>> GetAllIngredientInventory()
        {         
            return await new IngredientInventoryDataAccess().GetIngredientUnits();
        }

        public async Task<bool> SaveIngredientInventory(IngredientTotalUnitModel model)
        {
            return await new IngredientInventoryDataAccess().SaveIngredientInventory(model);
        }



      
    }
}
