using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaInventory.Web.ViewModel
{
    public class SalesOrderViewModel
    {
        public string ProductSku { get; set; } = "1112256";
        public string ClientId { get; set; } = "1";
        public int Quantity { get; set; } = 2;
        public decimal UnitPrice = 99.99M;
        public decimal GrossPrice => UnitPrice * Quantity ;
        public decimal NetPrice => GrossPrice + TaxAmount;
        public decimal TaxAmount => GrossPrice * TaxRate;
        public decimal DiscountAmount => (NetPrice + TaxAmount) * DiscountRate;
        public decimal TotalAmountAfterDiscount => NetPrice - DiscountAmount;
        public const decimal TaxRate = 0.24M;
        public const decimal DiscountRate = 0.5M;

    }
}
