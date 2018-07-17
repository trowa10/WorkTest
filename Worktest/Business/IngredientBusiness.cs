using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.DataAccess;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Business
{
    public class IngredientBusiness : IIngredient
    {
        public Task<bool> DeleteIngredientByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<IngredientModel>> GetIngredients()
        {
            return await new IngredientDataAccess().GetIngredients();
        }

        public Task<bool> SaveIngredient(IngredientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
