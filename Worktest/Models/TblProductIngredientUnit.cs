using System;
using System.Collections.Generic;

namespace Worktest.Models
{
    public partial class TblProductIngredientUnit
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? IngredientId { get; set; }
        public int Unit { get; set; }

        public TblIngredientInventory Ingredient { get; set; }
        public TblProduct Product { get; set; }
    }
}
