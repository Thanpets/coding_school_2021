using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [MinLength(9, ErrorMessage = "AFM is required,only 9 chars are acceptable")]
        [MaxLength(9,ErrorMessage = "AFM is required,only 9 chars are acceptable")]
        [Required(ErrorMessage ="AFM is required,only 9 chars are acceptable")]
        public string AFM { get; set; }
        public bool Active { get; set; }
    }
}
