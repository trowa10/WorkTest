using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Interface
{
    public  interface IIngredientInventory
    {
        Task<List<IngredientInventoryModel>> GetAllIngredientInventory();
        Task<bool> SaveIngredientInventory(IngredientTotalUnitModel model);
        Task<bool> DeleteIngredientInventoryByID(int id);
    }
}
