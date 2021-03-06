﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DashBoard.Models
{
    public class Block
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name should be less than 10 characters.")]
        [MaxLength(10)]
        public string Name { get; set; }
        public List<Apartment> Apartments { get; set; }
        public Community Community { get; set; }
    }
}