using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProductManagemnt.Model
{
    public class ProductImage
    {
        [Key]public int ImageId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]public Product Product { get; set; }
        public string ImageUrl { get; set; }
    }
}
