using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public class ProductIngredientUnit : IProductIngredientUnit
    {
        public Task<bool> DeleteProductIngredientUnitByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductIngredientUnitModel>> GetAllProductIngredientUnit()
        {
                return await this.GetProductIngredientUnitModel();            
        }

        public Task<bool> SaveProductIngredientUnit(TblProductIngredientUnit model)
        {
            throw new NotImplementedException();
        }


        private async Task<List<ProductIngredientUnitModel>> GetProductIngredientUnitModel()
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {
                var queryProductIngredientUnit =
                        from main in db.TblProductIngredientUnit
                        join prod in db.TblProduct on main.ProductId equals prod.Id
                        join ingredient in db.TblIngredientInventory on main.IngredientId equals ingredient.Id
                        select new { Main = main, Prod = prod, Ingredient = ingredient };

                var productIngredientUnits = queryProductIngredientUnit.Select(a => new ProductIngredientUnitModel
                {
                    Id = a.Main.Id,
                    IngredientName = a.Ingredient.IngredientName,
                    ProductName = a.Prod.ProductName,
                    Unit = a.Main.Unit
                });

                return await productIngredientUnits.ToListAsync();


            }
        }
    }
}
