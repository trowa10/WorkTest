using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public  interface IIngredientInventory
    {
        Task<List<IngredientInventoryModel>> GetAllIngredientInventory();
        Task<bool> SaveIngredientInventory(TblIngredientInventory model);
        Task<bool> DeleteIngredientInventoryByID(int id);
    }
}
