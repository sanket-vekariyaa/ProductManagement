using System.ComponentModel.DataAnnotations;

namespace ProductManagemnt.Data
{
    public class Category : AuditableEntity
    {
        [Key]public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
