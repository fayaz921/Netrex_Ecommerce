using Application_Service.Enums;
using System.ComponentModel.DataAnnotations;

namespace Application_Service.Entities.ProductAndCategoryModule.Products
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        public Guid SellerId { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int StockQuantity { get; set; }
        public ProductStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
