﻿using System.ComponentModel.DataAnnotations;

namespace RV.Views
{
    public class NewsAddDTO
    {
        [Required]
        public int userId { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string content { get; set; }
    }
}
