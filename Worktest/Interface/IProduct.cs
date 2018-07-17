using System.Collections.Generic;
using System.Threading.Tasks;
using Worktest.Models;

namespace Worktest.Interface
{
    public  interface IProduct
    {
        Task<List<TblProduct>> GetProducts();
        Task<bool> SaveProduct(TblProduct model);
        Task<bool> DeleteProductByID(int id);
    }
}
