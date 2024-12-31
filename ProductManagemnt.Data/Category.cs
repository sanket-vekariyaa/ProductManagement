using System.ComponentModel.DataAnnotations;

namespace ProductManagemnt.Model
{
    public class Category : TransectionKeys
    {
        [Key]public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
