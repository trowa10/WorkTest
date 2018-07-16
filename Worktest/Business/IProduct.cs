using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Business
{
    public  interface IProduct
    {
        Task<List<TblProduct>> GetAllProduct();
        Task<bool> SaveProduct(TblProduct model);
        Task<bool> DeleteProductByID(int id);
    }
}
