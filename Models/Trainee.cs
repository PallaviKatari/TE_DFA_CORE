using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DFA_CORE.Models
{
    public partial class Trainee
    {
        [Key]
        public int Tid { get; set; }
        [Required(ErrorMessage = "Kindly fill your Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name does not satisfy the condition")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Tname { get; set; }
        [Range(21, 45, ErrorMessage = "Not Eligible")]
        public int? Tage { get; set; }
    }
}
