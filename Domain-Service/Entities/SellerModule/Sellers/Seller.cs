using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.SellerModule.Sellers
{
    public class Seller
    {
        [Key]
        public Guid SellerId { get; set; }
        public Guid UserId { get; set; }
        public Guid ShopId { get; set; }
        public string StoreName { get; set; } = string.Empty;
        public string StoreDescription { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int GstNumber { get; set; } 
    }
}
