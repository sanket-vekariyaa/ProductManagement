using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductManagemnt.Data
{
    public class Product : AuditableEntity
    {
        [Key]public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]public Category Category { get; set; }
        public string ProductCode { get; set; }
        public bool IsActive { get; set; }
    }
}
