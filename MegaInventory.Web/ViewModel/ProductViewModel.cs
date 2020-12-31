using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaInventory.Web.ViewModel
{
    public class ProductViewModel
    {
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double SalePrice { get; set; }
        [Required]
        public double PurchasePrice { get; set; }

    }
}
