using System;
using System.Collections.Generic;

namespace Worktest.Models
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblProductIngredientUnit = new HashSet<TblProductIngredientUnit>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public ICollection<TblProductIngredientUnit> TblProductIngredientUnit { get; set; }
    }
}
