using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public class Product : IProduct
    {
        public Task<bool> DeleteProductByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TblProduct>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveProduct(TblProduct model)
        {
            throw new NotImplementedException();
        }
    }
}
