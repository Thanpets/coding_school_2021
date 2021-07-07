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
        public string AFM { get; set; }
        public bool Active { get; set; }
    }
}
