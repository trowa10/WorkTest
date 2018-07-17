using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Interface
{
    public interface IIngredient
    {
        Task<List<IngredientModel>> GetIngredients();
        Task<bool> SaveIngredient(IngredientModel model);
        Task<bool> DeleteIngredientByID(int id);
    }
}
