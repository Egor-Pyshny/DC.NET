﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RV.Models
{
    [Table("tbl_news")]
    public class News
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [ForeignKey("User")]
        [Required]
        [Column("user_id")]
        public int userId { get; set; }

        [MaxLength(64)]
        public string title { get; set; }

        [MaxLength(2048)]
        public string content { get; set; }

        public DateTime created { get; set; }

        public DateTime modified { get; set; }

        public User User { get; set; }
        public List<Note>? Notes { get; set; } = new();
        public List<Sticker> Stickers { get; set; } = new();
        public List<NewsSticker> NewsStickers { get; set; } = new();
    }
}
