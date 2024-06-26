﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RV.Models
{
    [Table("tbl_sticker")]
    public class Sticker
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [MaxLength(32)]
        [Required]
        public string name { get; set; }

        public List<News> News { get; set; } = new();
        public List<NewsSticker> NewsStickers { get; set; } = new();

    }
}
