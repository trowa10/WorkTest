using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.DataAccess;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Business
{
    public class ProductIngredientUnitBusiness : IProductIngredientUnit
    {
        public Task<bool> DeleteProductIngredientUnitByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductIngredientUnitModel>> GetProductIngredientUnit()
        {
                return await new ProductIngredientUnitDataAccess().GetProductIngredientUnits();            
        }

        public Task<bool> SaveProductIngredientUnit(TblProductIngredientUnit model)
        {
            throw new NotImplementedException();
        }


      
    }
}
