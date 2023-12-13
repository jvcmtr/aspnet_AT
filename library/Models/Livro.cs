﻿using library.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library.Models
{
    public class Livro : DbItem
    {
        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "max length is 30")]
        public string Sinopse { get; set; }
    }
}