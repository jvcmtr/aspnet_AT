using library.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace library.Models
{
    public class Autor : DbItem
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime? birth { get; set; }

        [NotMapped]
        public IFormFile? Upload { get; set; }
        
        [Required]
        public string ImageFile { get; set; }
    }
}
