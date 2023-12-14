using System.ComponentModel.DataAnnotations;

namespace library.Models.Abstract
{
    public abstract class DbItem
    {
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }
    }
}
