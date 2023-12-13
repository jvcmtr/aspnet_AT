using library.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library.Models
{
    public class Autor : DbItem
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime birth { get; set; }

        [NotMapped]
        public IFormFile Upload { get; set; }
        public string ImageFile { get; set; }
    }
}
