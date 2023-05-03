using System.ComponentModel.DataAnnotations;

namespace Pustok_04._05._23.Models
{
    public class BooksImage
    {
        public int Id { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public int BookId { get; set; }
        public Books Books { get; set; }
    }
}
