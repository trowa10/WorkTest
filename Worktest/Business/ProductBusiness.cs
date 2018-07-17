using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.DataAccess;
using Worktest.Interface;
using Worktest.Models;

namespace Worktest.Business
{
    public class ProductBusiness : IProduct
    {
        public Task<bool> DeleteProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TblProduct>> GetProducts()
        {
            return await new ProductDataAccess().GetProducts();        }

        public Task<bool> SaveProduct(TblProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
