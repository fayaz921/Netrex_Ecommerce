using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Service.Entities.ProductAndCategoryModule
{
    public class ProductImage
    {
        [Key]
        public Guid ProductImageId { get; set; }
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
