﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RV.Models
{
    [Table("tbl_user")]
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [MaxLength(64)]
        [Required]
        public string login { get; set; }

        [MaxLength(128)]
        [Required]
        public string password { get; set; }

        [MaxLength(64)]
        [Required]
        public string firstname { get; set; }

        [MaxLength(64)]
        [Required]
        public string lastname { get; set; }

        public List<News>? News { get; set; } = new();
    }
}
