using System.ComponentModel.DataAnnotations;

namespace Pustok_04._05._23.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public int SalePrice { get; set; }
        [Required]
        public int CostPrice { get; set; }
        public int DiscountPercent { get; set; }

    }
}
