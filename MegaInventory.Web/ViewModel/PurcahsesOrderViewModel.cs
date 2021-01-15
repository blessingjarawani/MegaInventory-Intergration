using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaInventory.Web.ViewModel
{
    public class PurcahsesOrderViewModel
    {
        [Required]
        public long PurchaseOrderSupplierId { get; set; }

        [Required]
        public long PurchaseOrderTypeId { get; set; }
        [Required]

        public long PurchaseOrderInventoryLocationID { get; set; }

        [Required]

        public long PurchaseOrderStatus { get; set; }

        [Required]
        public long PurchaseOrderNo { get; set; }

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
