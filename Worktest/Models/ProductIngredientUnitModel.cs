using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Worktest.Models
{
    public class ProductIngredientUnitModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string IngredientName { get; set; }
        public int Unit { get; set; }
    }
}
