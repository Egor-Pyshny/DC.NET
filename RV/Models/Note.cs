﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RV.Models;

namespace RV.Models
{
    [Table("tbl_note")]
    public class Note
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [ForeignKey("News")]
        [Required]
        public int newsId { get; set; }

        [MaxLength(2048)]
        public string content { get; set; }

        public News New { get; set; }
    }
}
