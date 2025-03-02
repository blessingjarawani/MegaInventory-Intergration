﻿using System;
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

        [Required]
        public string PurchaseOrderRowProductSKU { get; set; }
        [Required]
        public string PurchaseOrderRowQuantity { get; set; }
        [Required]
        public string PurchaseOrderRowReceivedQuantity { get; set; }
        [Required]
        public string PurchaseOrderRowInvoicedQuantity { get; set; }
        [Required]
        public string PurchaseOrderRowUnitPriceWithoutTaxOrDiscount { get; set; }

    }
}
