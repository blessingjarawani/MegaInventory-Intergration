using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaInventory.Web.ViewModel
{
    public class ClientViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ShippingAddress { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
