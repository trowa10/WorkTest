using System;
using System.Collections.Generic;

namespace Worktest.Models
{
    public partial class TblIngredientInventory
    {
        public TblIngredientInventory()
        {
            TblProductIngredientUnit = new HashSet<TblProductIngredientUnit>();
        }

        public int Id { get; set; }
        public string IngredientName { get; set; }
        public int TotalUnit { get; set; }

        public ICollection<TblProductIngredientUnit> TblProductIngredientUnit { get; set; }
    }
}
