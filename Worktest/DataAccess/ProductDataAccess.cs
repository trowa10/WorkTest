using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.DataAccess
{
    public class ProductDataAccess
    {
        public async Task<List<TblProduct>> GetProducts()
        {
            using (CircleCoffeeContext db = new CircleCoffeeContext())
            {

                var products = db.TblProduct.Select(a => new TblProduct
                {
                    Id = a.Id,
                    ProductName = a.ProductName
                });

                return await products.ToListAsync();

            }
        }
    }
}
