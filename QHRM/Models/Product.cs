using System.ComponentModel.DataAnnotations;

namespace QHRM.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product ID is required.")]
        public string? Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public string? Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
