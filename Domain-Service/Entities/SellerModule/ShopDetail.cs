using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.SellerModule
{
    public class ShopDetail
    {
        [Key]
        public Guid ShopId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
