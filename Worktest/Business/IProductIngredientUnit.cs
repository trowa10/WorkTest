using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public interface IProductIngredientUnit
    {
        Task<List<ProductIngredientUnitModel>> GetAllProductIngredientUnit();
        Task<bool> SaveProductIngredientUnit(TblProductIngredientUnit model);
        Task<bool> DeleteProductIngredientUnitByID(int id);
    }
}
