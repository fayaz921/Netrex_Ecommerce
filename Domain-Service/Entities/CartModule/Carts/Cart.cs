using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.CartModule.Carts
{
    public class Cart
    {
        [Key]
        public Guid CartId { get; set; }
        public Guid CustomerId { get; set; }
    }
}
