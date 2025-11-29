using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.ProductAndCategoryModule.ProductCategories
{
    public class ProductCategory
    {
        [Key]
        public Guid ProductCategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
